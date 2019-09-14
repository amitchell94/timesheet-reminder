using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mshtml;
using System.Windows.Forms;

namespace ReminderApp
{
    public partial class OvertimeFormGenerator : Form
    {
        HTMLDocument timesheet;
        HTMLTable bookingsTable;
        string bookingsTableInnerHTML;
        bool thisMonth = false;
        List<OvertimeBooking> currentBookings = new List<OvertimeBooking>();

        SHDocVw.WebBrowser_V1 Web_V1;

        public OvertimeFormGenerator()
        {
            InitializeComponent();
        }

        private void thisMonthButton_Click(object sender, EventArgs e)
        {
            thisMonth = true;
            thisMonthButton.Enabled = false;
            lastMonthButton.Enabled = false;

            listView1.Items.Clear();
            currentBookings.Clear();
            loadingText.Visible = true;

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                if (webBrowser1.Url.ToString() == "http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx")
                {
                    Web_V1 = (SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance;

                    timesheet = (HTMLDocument)Web_V1.Document;

                    bookingsTable = (HTMLTable)timesheet.all.item("ContentPlaceHolder1_GridViewSessions", 0);

                    if (bookingsTable != null)
                    {
                        bookingsTableInnerHTML = bookingsTable.innerHTML;
                    }
                    else
                    {
                        bookingsTableInnerHTML = "";
                    }

                    if (!thisMonth)
                    {
                        var anchorElements = timesheet.getElementsByTagName("a");

                        foreach (HTMLAnchorElement item in anchorElements)
                        {
                            if (item.title == "Go to the previous month")
                            {
                                item.click();
                            }
                        }

                        timer1.Start();
                    }
                    else
                    {
                        HTMLInputElement monthRadioButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListSessions_2", 0);
                        monthRadioButton.click();
                        timer1.Start();
                    }


                }
            }
        }


        private OvertimeBooking parseRow(HTMLTableRow row)
        {
            OvertimeBooking overtimeBooking = new OvertimeBooking();

            List<string> cells = new List<string>();

            foreach (var item in row.all)
            {
                cells.Add(item.innerText);
            }

            if (cells.Count > 9 && (cells[10] == "OT1" || cells[10] == "OT2" || cells[10] == "OT3"))
            {
                overtimeBooking.date = cells[0].Substring(4);
                overtimeBooking.projectNo = cells[1];
                overtimeBooking.description = cells[6];
                overtimeBooking.hours = cells[9];
                if (cells[10] == "OT1")
                {
                    overtimeBooking.multiplier = "1";
                }
                if (cells[10] == "OT2")
                {
                    overtimeBooking.multiplier = "1.5";
                }
                if (cells[10] == "OT3")
                {
                    overtimeBooking.multiplier = "2";
                }

                return overtimeBooking;
            }
            else
            {
                return null;
            }

        }


        private void populateListView ()
        {
            bookingsTable = (HTMLTable)timesheet.all.item("ContentPlaceHolder1_GridViewSessions", 0);

            foreach (var table in bookingsTable.all)
            {
                foreach (var row in table.all)
                {
                    if (row is HTMLTableRow)
                    {
                        OvertimeBooking timesheetBooking = parseRow(row);
                        if (timesheetBooking != null)
                        {
                            currentBookings.Add(timesheetBooking);
                            string[] bookingArray = { timesheetBooking.date, timesheetBooking.projectNo, timesheetBooking.description, timesheetBooking.hours, timesheetBooking.multiplier };
                            ListViewItem item = new ListViewItem(bookingArray);
                            listView1.Items.Add(item);
                        }
                    }
                }

            }
            AdjustDescColumnToFill(listView1);
            thisMonthButton.Enabled = true;
            lastMonthButton.Enabled = true;
            loadingText.Visible = false;
        }

        private void lastMonthButton_Click(object sender, EventArgs e)
        {
            thisMonth = false;
            thisMonthButton.Enabled = false;
            lastMonthButton.Enabled = false;

            listView1.Items.Clear();
            currentBookings.Clear();

            loadingText.Visible = true;

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bookingsTable == null)
            {
                bookingsTable = (HTMLTable)timesheet.all.item("ContentPlaceHolder1_GridViewSessions", 0);
            }
            else
            {
                if (bookingsTableInnerHTML != bookingsTable.innerHTML)
                {
                    timer1.Stop();
                    populateListView();
                }
            }
        }

        private void OvertimeFormGenerator_Load(object sender, EventArgs e)
        {
            AdjustDescColumnToFill(listView1);
            loadingText.Visible = false;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string copyText = String.Empty;
            foreach (var booking in currentBookings)
            {
                copyText += booking.date + "\t" + booking.projectNo + "\t" + "Working/travelling more than 7.5 hours" + "\t" + booking.description + "\t\t" + booking.hours + "\t" + booking.multiplier + "\n";
            }

            //Remove final return character
            copyText = copyText.Substring(0, copyText.Length - 1);

            System.Windows.Forms.Clipboard.SetText(copyText);
        }

        private void AdjustDescColumnToFill(ListView lvw)
        {
            Int32 nWidth = lvw.ClientSize.Width; // Get width of client area.

            // Loop through all columns except the last one.
            for (Int32 i = 0; i < lvw.Columns.Count; i++)
            {
                // Subtract width of the column from the width
                // of the client area.
                if (!(i == 2))
                {
                    nWidth -= lvw.Columns[i].Width;
                }

                // If the width goes below 1, then no need to keep going
                // because the last column can't be sized to fit due to
                // the widths of the columns before it.
                if (nWidth < 1)
                    break;
            };

            // If there is any width remaining, that will
            // be the width of the last column.

            if (nWidth > 0)
                lvw.Columns[2].Width = nWidth;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

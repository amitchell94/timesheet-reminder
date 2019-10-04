using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using System.IO;



namespace ReminderApp
{
    public partial class TimesheetEntry : Form
    {
        private SHDocVw.WebBrowser_V1 Web_V1;
        private HTMLDocument timesheet = new HTMLDocument();

        HTMLSelectElement projectList;
        HTMLSelectElement codeList;
        HTMLSelectElement extensionList;
        HTMLSelectElement technologyList;
        HTMLInputElement descTextInput;
        HTMLInputElement hoursTextInput;
        HTMLInputElement normalOvertimeInput;
        HTMLInputElement oneOvertimeInput;
        HTMLInputElement oneAndAHalfOvertimeInput;
        HTMLInputElement twoOvertimeInput;
        HTMLInputElement addButton;

        bool technologyComboUpdateRequired = false;
        string selectedTechnology = String.Empty;

        string jsCompleteTestText = String.Empty;

        List<Booking> bookingList = new List<Booking>();

        public TimesheetEntry()
        {
            InitializeComponent();
        }

        private void TimesheetEntry_Load(object sender, EventArgs e)
        {

            bookingsListView.Enabled = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(new Uri("http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx"));

            if (Properties.Settings.Default.prevTenBookings != null)
            {
                bookingList.Clear();
                foreach (string booking in Properties.Settings.Default.prevTenBookings)
                {
                    string[] bookingArray = booking.Split('\n');

                    Booking parsedBooking = new Booking();

                    parsedBooking.project = bookingArray[0];
                    parsedBooking.code = bookingArray[1];
                    parsedBooking.description = bookingArray[2];
                    parsedBooking.bookedHours = bookingArray[3];
                    if (bookingArray.Length > 4)
                    {
                        parsedBooking.technology = bookingArray[4];
                    }
                    if (bookingArray.Length > 5)
                    {
                        parsedBooking.extension = bookingArray[5];
                    }
                    if (bookingArray.Length > 6)
                    {
                        parsedBooking.overtime = bookingArray[6];
                    }

                    bookingList.Add(parsedBooking);

                    string[] bookingRow = { parsedBooking.project, parsedBooking.code, parsedBooking.technology, parsedBooking.description, parsedBooking.bookedHours };
                    ListViewItem item = new ListViewItem(bookingRow);
                    bookingsListView.Items.Add(item);
                    AdjustDescColumnToFill(bookingsListView);

                    if (bookingList.Count >= 10) { break; }
                }
            }
            else
            {
                Properties.Settings.Default.prevTenBookings = new System.Collections.Specialized.StringCollection();
            }

            button1.Enabled = false;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                {
                    if (webBrowser1.Url.ToString() == "http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx")
                    {
                        Web_V1 = (SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance;

                        timesheet = (HTMLDocument)Web_V1.Document;

                        selectedTechnology = Properties.Settings.Default.lastBookedTechnology;

                        if (!String.IsNullOrEmpty(selectedTechnology))
                        {
                            technologyComboUpdateRequired = true;
                        }

                        projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);

                        projectComboBox.Items.Clear();
                        foreach (var item in projectList.options)
                        {
                            projectComboBox.Items.Add(item.innerText);
                        }
                        string lastProject = Properties.Settings.Default.lastBookedProject;

                        if (!String.IsNullOrEmpty(lastProject) && projectComboBox.Items.Contains(lastProject))
                        {
                            projectComboBox.SelectedItem = lastProject;
                        }
                        else
                        {
                            projectComboBox.SelectedIndex = 0;
                        }

                        codeList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListCode", 0);
                        codeComboBox.Items.Clear();
                        foreach (var item in codeList.options)
                        {
                            codeComboBox.Items.Add(item.innerText);
                        }
                        string lastCode = Properties.Settings.Default.lastBookedCode;

                        if (!String.IsNullOrEmpty(lastCode) && codeComboBox.Items.Contains(lastCode))
                        {
                            codeComboBox.SelectedItem = lastCode;
                        }
                        else
                        {
                            codeComboBox.SelectedIndex = 0;
                        }

                        descTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxDescription", 0);
                        string lastDesc = Properties.Settings.Default.lastBookedDesc;

                        if (!String.IsNullOrEmpty(lastDesc))
                        {
                            descTextBox.Text = lastDesc;
                        }

                        extensionList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListExtension", 0);
                        extensionComboBox.Items.Clear();
                        foreach (var item in extensionList.options)
                        {
                            extensionComboBox.Items.Add(item.innerText);
                        }
                        string lastExtension = Properties.Settings.Default.lastBookedExtension;

                        if (!String.IsNullOrEmpty(lastExtension) && extensionComboBox.Items.Contains(lastExtension))
                        {
                            extensionComboBox.SelectedItem = lastExtension;
                        }
                        else
                        {
                            extensionComboBox.SelectedIndex = 0;
                        }

                        hoursTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxHours", 0);

                        string lastHours = Properties.Settings.Default.lastBookedHours;

                        if (!String.IsNullOrEmpty(lastHours))
                        {
                            hoursTextBox.Text = lastHours;
                        }

                        normalOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_0", 0);
                        oneOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_1", 0);
                        oneAndAHalfOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_2", 0);
                        twoOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_3", 0);

                        string lastBookedOT = Properties.Settings.Default.lastBookedOvertime;


                        if (lastBookedOT == "1")
                        {
                            Overtime1radioButton.Checked = true;
                        }
                        else if (lastBookedOT == "1.5")
                        {
                            overtime15radioButton.Checked = true;
                        }
                        else if (lastBookedOT == "2")
                        {
                            overtimer2radioButton.Checked = true;
                        }
                        else
                        {
                            normalRadioButton.Checked = true;
                        }

                        addButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_ButtonAdd", 0);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to connect to timesheet page, please check your connection");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            float hoursFloat;
            try
            {
                hoursFloat = float.Parse(hoursTextBox.Text);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Invalid hours format.");
                return;
            }
            hoursFloat = float.Parse(hoursTextBox.Text);
            if ((hoursFloat % 0.25) != 0)
            {
                MessageBox.Show("Invalid hours format. Must be a multiple of 0.25");
                return;
            }

            projectList.selectedIndex = projectComboBox.SelectedIndex;
            if (technologyComboBox.Items.Count > 0)
            {
                technologyList.selectedIndex = technologyComboBox.SelectedIndex;
            }
            codeList.selectedIndex = codeComboBox.SelectedIndex;
            descTextInput.value = descTextBox.Text;

            extensionList.selectedIndex = extensionComboBox.SelectedIndex;

            hoursTextInput.value = hoursTextBox.Text;
            string overtimeText = "Normal";

            if (normalRadioButton.Checked)
            {
                normalOvertimeInput.@checked = true;
                overtimeText = "Normal";
            }
            if (Overtime1radioButton.Checked)
            {
                oneOvertimeInput.@checked = true;
                overtimeText = "1";
            }
            if (overtime15radioButton.Checked)
            {
                oneAndAHalfOvertimeInput.@checked = true;
                overtimeText = "1.5";
            }
            if (overtimer2radioButton.Checked)
            {
                twoOvertimeInput.@checked = true;
                overtimeText = "2";
            }

            addButton.click();

            Properties.Settings.Default.lastBookedProject = projectComboBox.Text;
            Properties.Settings.Default.lastBookedCode = codeComboBox.Text;
            Properties.Settings.Default.lastBookedTechnology = technologyComboBox.Text;
            Properties.Settings.Default.lastBookedExtension = extensionComboBox.Text;
            Properties.Settings.Default.lastBookedDesc = descTextBox.Text;
            Properties.Settings.Default.lastBookedHours = hoursTextBox.Text;
            Properties.Settings.Default.lastBookedOvertime = overtimeText;


            Properties.Settings.Default.Save();

            string booking = projectComboBox.Text + "\n" + codeComboBox.Text + "\n" +
                descTextBox.Text + "\n" + hoursTextBox.Text + "\n" + technologyComboBox.Text + "\n" + extensionComboBox.Text + "\n" + overtimeText;
            if (!Properties.Settings.Default.prevTenBookings.Contains(booking))
            {
                Properties.Settings.Default.prevTenBookings.Insert(0, booking);
            }
            else
            {
                if (Properties.Settings.Default.prevTenBookings.IndexOf(booking) != 0)
                {
                    Properties.Settings.Default.prevTenBookings.Remove(booking);
                    Properties.Settings.Default.prevTenBookings.Insert(0, booking);
                }
            }
            while (Properties.Settings.Default.prevTenBookings.Count > 10)
            {
                Properties.Settings.Default.prevTenBookings.RemoveAt(10);
            }


            /*
        } else
        {
            try
            {
                if (!String.IsNullOrEmpty(Properties.Settings.Default.filePath))
                {
                    string selectedFilePath = Properties.Settings.Default.filePath;
                    File.AppendAllText(selectedFilePath + "\\Timesheet.txt",
                        DateTime.Now.DayOfWeek.ToString().Substring(0,3) + "\t" +
                        DateTime.Now.ToString() + "\t" + noteTextBox.Text + Environment.NewLine);
                } else
                {
                    MessageBox.Show("Error: No file path selected");
                }
            }
            catch (Exception exception)
            {
                System.Console.Write(exception.StackTrace);
            }
        }
        */
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);


            projectList.selectedIndex = projectComboBox.SelectedIndex;

            projectList.FireEvent("onchange");

            projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);
            //This tests to see if the elements have now been updated by the AJAX code, a bit messy but it works...
            jsCompleteTestText += "test";
            descTextInput.value = jsCompleteTestText;

            HTMLInputElement tempDescTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxDescription", 0);
            //Once the desc text input is no longer updated, then we know we have refreshed elements.
            if (tempDescTextInput.value != jsCompleteTestText)
            {
                jsCompleteTestText = String.Empty;

                technologyList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListTechnology", 0);

                technologyComboBox.Items.Clear();
                foreach (var item in technologyList.options)
                {
                    technologyComboBox.Items.Add(item.innerText);
                }
                if (technologyComboBox.Items.Count > 0)
                {
                    technologyComboBox.Enabled = true;
                    technologyComboBox.SelectedIndex = 0;
                }
                else
                {
                    technologyComboBox.Enabled = false;
                }

                if (technologyComboUpdateRequired)
                {
                    technologyComboBox.SelectedItem = selectedTechnology;
                    selectedTechnology = String.Empty;
                }

                codeList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListCode", 0);

                descTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxDescription", 0);
                extensionList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListExtension", 0);

                hoursTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxHours", 0);

                normalOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_0", 0);
                oneOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_1", 0);
                oneAndAHalfOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_2", 0);
                twoOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_3", 0);

                addButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_ButtonAdd", 0);
                button1.Enabled = true;
                bookingsListView.Enabled = true;
                timer1.Stop();
            }
        }

        private void codeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeList.selectedIndex = codeComboBox.SelectedIndex;
        }

        private void AdjustDescColumnToFill(ListView lvw)
        {
            Int32 nWidth = lvw.ClientSize.Width; // Get width of client area.

            // Loop through all columns except the last one.
            for (Int32 i = 0; i < lvw.Columns.Count; i++)
            {
                // Subtract width of the column from the width
                // of the client area.
                if (!(i == 3))
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
                lvw.Columns[3].Width = nWidth;
        }

        private void bookingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProject = bookingList[bookingsListView.FocusedItem.Index].project;
            string selectedCode = bookingList[bookingsListView.FocusedItem.Index].code;
            string selectedExtension = bookingList[bookingsListView.FocusedItem.Index].extension;
            string selectedDesc = bookingList[bookingsListView.FocusedItem.Index].description;
            selectedTechnology = bookingList[bookingsListView.FocusedItem.Index].technology;
            string selectedHours = bookingList[bookingsListView.FocusedItem.Index].bookedHours;
            string selectedOvertime = bookingList[bookingsListView.FocusedItem.Index].overtime;

            if (!String.IsNullOrEmpty(selectedProject) && projectComboBox.Items.Contains(selectedProject))
            {
                technologyComboUpdateRequired = true;

                projectComboBox.SelectedItem = selectedProject;
            }
            else
            {
                projectComboBox.SelectedIndex = 0;
            }

            if (!String.IsNullOrEmpty(selectedCode) && codeComboBox.Items.Contains(selectedCode))
            {
                codeComboBox.SelectedItem = selectedCode;
            }
            else
            {
                codeComboBox.SelectedIndex = 0;
            }

            if (!String.IsNullOrEmpty(selectedDesc))
            {
                descTextBox.Text = selectedDesc;
            }

            if (!String.IsNullOrEmpty(selectedExtension) && extensionComboBox.Items.Contains(selectedExtension))
            {
                extensionComboBox.SelectedItem = selectedExtension;
            }
            else
            {
                extensionComboBox.SelectedIndex = 0;
            }

            if (!String.IsNullOrEmpty(selectedHours))
            {
                hoursTextBox.Text = selectedHours;
            }

            if (selectedOvertime == "1")
            {
                Overtime1radioButton.Checked = true;
            }
            else if (selectedOvertime == "1.5")
            {
                overtime15radioButton.Checked = true;
            }
            else if (selectedOvertime == "2")
            {
                overtimer2radioButton.Checked = true;
            }
            else
            {
                normalRadioButton.Checked = true;
            }

        }

    }
}

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
        HTMLInputElement allRadioInput;
        HTMLInputElement regionRadioInput;
        HTMLInputElement teamRadioInput;
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
        bool lastBookedRadioButtonUpdateRequired = false;

        string selectedTechnology = String.Empty;
        string lastProject = String.Empty;
        string lastCode = String.Empty;
        string lastDesc = String.Empty;
        string lastExtension = String.Empty;
        string lastHours = String.Empty;
        string lastBookedOT = String.Empty;

        string jsCompleteTestText = String.Empty;
        int projectListCount = 0;
        List<Booking> bookingList = new List<Booking>();

        public TimesheetEntry()
        {
            InitializeComponent();
        }

        private void TimesheetEntry_Load(object sender, EventArgs e)
        {

            bookingsListView.Enabled = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(new Uri("http://intranet.cougarautomation.net/Timesheet/Timesheet.aspx"));

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
                    if (bookingArray.Length > 7)
                    {
                        parsedBooking.radioButton = bookingArray[7];
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
                    if (webBrowser1.Url.ToString() == "http://intranet.cougarautomation.net/Timesheet/Timesheet.aspx")
                    {
                        Web_V1 = (SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance;

                        timesheet = (HTMLDocument)Web_V1.Document;

                        selectedTechnology = Properties.Settings.Default.lastBookedTechnology;

                        if (!String.IsNullOrEmpty(selectedTechnology))
                        {
                            //This lets us know that we need to update the technology after we have selected the project.
                            technologyComboUpdateRequired = true;
                        }

                        initaliseElements();

                        string lastBookedRadioButton = Properties.Settings.Default.lastBookedRadioButton;
                        if (!String.IsNullOrEmpty(lastBookedRadioButton) && lastBookedRadioButton != "team")
                        {
                            //This lets us know that we need to update the radio button after we have selected the project.
                            lastBookedRadioButtonUpdateRequired = true;
                            if (lastBookedRadioButton == "all")
                            {
                                allRadioButton.Checked = true;
                            } else if (lastBookedRadioButton == "region") {
                                regionRadioButton.Checked = true;
                            }
                        }
                        else
                        {
                            teamRadioButton.Checked = true;
                        }                       

                        projectComboBox.Items.Clear();
                        foreach (var item in projectList.options)
                        {
                            projectComboBox.Items.Add(item.innerText);
                        }
                        lastProject = Properties.Settings.Default.lastBookedProject;

                        if (!String.IsNullOrEmpty(lastProject))
                        {
                            if (projectComboBox.Items.Contains(lastProject)) {
                                projectComboBox.SelectedItem = lastProject;
                            } else
                            {
                                MessageBox.Show(lastProject + " is no longer in project list");
                            }
                        }
                        else
                        {
                            if (projectComboBox.Items.Count > 0)
                            {
                                projectComboBox.SelectedIndex = 0;
                            }
                        }

                        codeComboBox.Items.Clear();
                        foreach (var item in codeList.options)
                        {
                            codeComboBox.Items.Add(item.innerText);
                        }
                        lastCode = Properties.Settings.Default.lastBookedCode;

                        if (!String.IsNullOrEmpty(lastCode) && codeComboBox.Items.Contains(lastCode))
                        {
                            codeComboBox.SelectedItem = lastCode;
                        }
                        else
                        {
                            if (codeComboBox.Items.Count > 0)
                            {
                                codeComboBox.SelectedIndex = 0;
                            }
                        }

                        lastDesc = Properties.Settings.Default.lastBookedDesc;

                        if (!String.IsNullOrEmpty(lastDesc))
                        {
                            descTextBox.Text = lastDesc;
                        }

                        extensionComboBox.Items.Clear();
                        foreach (var item in extensionList.options)
                        {
                            extensionComboBox.Items.Add(item.innerText);
                        }
                        lastExtension = Properties.Settings.Default.lastBookedExtension;

                        if (!String.IsNullOrEmpty(lastExtension) && extensionComboBox.Items.Contains(lastExtension))
                        {
                            extensionComboBox.SelectedItem = lastExtension;
                        }
                        else
                        {
                            if (extensionComboBox.Items.Count > 0)
                            {
                                extensionComboBox.SelectedIndex = 0;
                            }
                        }


                        lastHours = Properties.Settings.Default.lastBookedHours;

                        if (!String.IsNullOrEmpty(lastHours))
                        {
                            hoursTextBox.Text = lastHours;
                        }

                        lastBookedOT = Properties.Settings.Default.lastBookedOvertime;


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

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to connect to timesheet page, please check your connection");
                this.Close();
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
                normalOvertimeInput.click();
                overtimeText = "Normal";
            }
            if (Overtime1radioButton.Checked)
            {
                oneOvertimeInput.click();
                overtimeText = "1";
            }
            if (overtime15radioButton.Checked)
            {
                oneAndAHalfOvertimeInput.click();
                overtimeText = "1.5";
            }
            if (overtimer2radioButton.Checked)
            {
                twoOvertimeInput.click();
                overtimeText = "2";
            }

            string radioButtonChecked = String.Empty;
            if (allRadioButton.Checked)
            {
                radioButtonChecked = "all";
            }
            if (regionRadioButton.Checked)
            {
                radioButtonChecked = "region";
            }
            if (teamRadioButton.Checked)
            {
                radioButtonChecked = "team";
            }

            addButton.click();

            Properties.Settings.Default.lastBookedProject = projectComboBox.Text;
            Properties.Settings.Default.lastBookedCode = codeComboBox.Text;
            Properties.Settings.Default.lastBookedTechnology = technologyComboBox.Text;
            Properties.Settings.Default.lastBookedExtension = extensionComboBox.Text;
            Properties.Settings.Default.lastBookedDesc = descTextBox.Text;
            Properties.Settings.Default.lastBookedHours = hoursTextBox.Text;
            Properties.Settings.Default.lastBookedOvertime = overtimeText;
            Properties.Settings.Default.lastBookedRadioButton = radioButtonChecked;

            Properties.Settings.Default.Save();

            string booking = projectComboBox.Text + "\n" + codeComboBox.Text + "\n" +
                descTextBox.Text + "\n" + hoursTextBox.Text + "\n" + technologyComboBox.Text + "\n" + 
                extensionComboBox.Text + "\n" + overtimeText + "\n" + radioButtonChecked;
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

                initaliseElements();

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

     

        private void regionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!regionRadioInput.@checked)
            {
                disableAllInputs();
                regionRadioInput.click();

                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            projectListCount = projectList.length;

            HTMLSelectElement tempProjectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);
            //Once the desc text input is no longer updated, then we know we have refreshed elements.
            if (tempProjectList.length != projectList.length)
            {
                jsCompleteTestText = String.Empty;

                initaliseElements();

                projectComboBox.Items.Clear();
                foreach (var item in projectList.options)
                {
                    projectComboBox.Items.Add(item.innerText);
                }

                codeComboBox.Items.Clear();
                foreach (var item in codeList.options)
                {
                    codeComboBox.Items.Add(item.innerText);
                }
                if (codeComboBox.Items.Count == 0)
                {
                    codeComboBox.Enabled = false;
                }

                extensionComboBox.Items.Clear();
                foreach (var item in extensionList.options)
                {
                    extensionComboBox.Items.Add(item.innerText);
                }
                if (extensionComboBox.Items.Count == 0)
                {
                    extensionComboBox.Enabled = false;
                }

                if (lastBookedRadioButtonUpdateRequired)
                {
                    fillLastBooking(lastProject, lastCode, lastDesc, lastExtension, lastHours, lastBookedOT);
                } else
                {
                    projectComboBox.SelectedIndex = 0;
                    if (codeComboBox.Enabled)
                    {
                        codeComboBox.SelectedIndex = 0;
                    }
                    
                    if (extensionComboBox.Enabled)
                    {
                        extensionComboBox.SelectedIndex = 0;
                    }
                    normalRadioButton.Checked = true;
                }
                checkAndEnableAllInputs();
                lastBookedRadioButtonUpdateRequired = false;
                timer2.Stop();
            }

        }

        private void initaliseElements()
        {
            allRadioInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListProjects_0", 0);
            regionRadioInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListProjects_1", 0);
            teamRadioInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListProjects_2", 0);

            projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);
            technologyList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListTechnology", 0);
            codeList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListCode", 0);
            descTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxDescription", 0);
            extensionList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListExtension", 0);

            hoursTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxHours", 0);

            normalOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_0", 0);
            oneOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_1", 0);
            oneAndAHalfOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_2", 0);
            twoOvertimeInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListHoursType_3", 0);

            addButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_ButtonAdd", 0);
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!allRadioInput.@checked)
            {
                disableAllInputs();
                allRadioInput.click();

                timer2.Start();
            }
            
        }

        private void teamRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!teamRadioInput.@checked)
            {
                disableAllInputs();
                teamRadioInput.click();

                timer2.Start();
            }                        
        }

        private void disableAllInputs()
        {
            button1.Enabled = false;
            projectComboBox.Enabled = false;
            codeComboBox.Enabled = false;
            technologyComboBox.Enabled = false;
            Overtime1radioButton.Enabled = false;
            overtime15radioButton.Enabled = false;
            overtimer2radioButton.Enabled = false;
            normalRadioButton.Enabled = false;
            //bookingsListView.Enabled = false;
        }

        private void checkAndEnableAllInputs()
        {
            button1.Enabled = true;
            projectComboBox.Enabled = true;
            if (codeComboBox.Items.Count == 0)
            {
                codeComboBox.Enabled = false;
            } else
            {
                codeComboBox.Enabled = true;
            }
            if (technologyComboBox.Items.Count == 0)
            {
                technologyComboBox.Enabled = false;
            }
            else
            {
                technologyComboBox.Enabled = true;
            }
            if (extensionComboBox.Items.Count == 0)
            {
                extensionComboBox.Enabled = false;
            }
            else
            {
                extensionComboBox.Enabled = true;
            }
            Overtime1radioButton.Enabled = true;
            overtime15radioButton.Enabled = true;
            overtimer2radioButton.Enabled = true;
            normalRadioButton.Enabled = true;
           // bookingsListView.Enabled = true;
        }

        private void fillLastBooking(string project, string code,  string desc, string extension, string hours, string overtime)
        {
            if (!String.IsNullOrEmpty(project) && projectComboBox.Items.Contains(project))
            {
                projectComboBox.SelectedItem = project;
            }
            else
            {
                projectComboBox.SelectedIndex = 0;
            }

            if (!String.IsNullOrEmpty(code) && codeComboBox.Items.Contains(code))
            {
                codeComboBox.SelectedItem = code;
            }
            else
            {
                if (codeComboBox.Items.Count == 0)
                {
                    codeComboBox.Enabled = false;
                }
                else
                {
                    codeComboBox.SelectedIndex = 0;
                }
            }

            if (!String.IsNullOrEmpty(desc))
            {
                descTextBox.Text = desc;
            }

            if (!String.IsNullOrEmpty(hours))
            {
                hoursTextBox.Text = hours;
            }

            if (!String.IsNullOrEmpty(extension) && extensionComboBox.Items.Contains(extension))
            {
                extensionComboBox.SelectedItem = extension;
            }
            else
            {
                if (extensionComboBox.Items.Count == 0)
                {
                    extensionComboBox.Enabled = false;
                }
                else
                {
                    extensionComboBox.SelectedIndex = 0;
                }
            }

            if (overtime == "1")
            {
                Overtime1radioButton.Checked = true;
            }
            else if (overtime == "1.5")
            {
                overtime15radioButton.Checked = true;
            }
            else if (overtime == "2")
            {
                overtimer2radioButton.Checked = true;
            }
            else
            {
                normalRadioButton.Checked = true;
            }
        }

        private void bookingsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            if (e.IsSelected)
            {
                //Keep going as we have selected something
            }
            else
            {
                return;
            }

            string radioButton = bookingList[bookingsListView.FocusedItem.Index].radioButton;

            lastProject = bookingList[bookingsListView.FocusedItem.Index].project;
            lastCode = bookingList[bookingsListView.FocusedItem.Index].code;
            lastExtension = bookingList[bookingsListView.FocusedItem.Index].extension;
            lastDesc = bookingList[bookingsListView.FocusedItem.Index].description;
            selectedTechnology = bookingList[bookingsListView.FocusedItem.Index].technology;
            lastHours = bookingList[bookingsListView.FocusedItem.Index].bookedHours;
            lastBookedOT = bookingList[bookingsListView.FocusedItem.Index].overtime;

            if (radioButton == "all" && allRadioInput.@checked != true)
            {
                lastBookedRadioButtonUpdateRequired = true;
                allRadioButton.Checked = true;
            }
            else if (radioButton == "region" && regionRadioInput.@checked != true)
            {
                lastBookedRadioButtonUpdateRequired = true;
                regionRadioButton.Checked = true;
            }
            else if (radioButton == "team" && teamRadioInput.@checked != true)
            {
                lastBookedRadioButtonUpdateRequired = true;
                teamRadioButton.Checked = true;
            }
            else
            {

                if (!String.IsNullOrEmpty(lastProject))
                {
                    if (projectComboBox.Items.Contains(lastProject))
                    {

                        technologyComboUpdateRequired = true;

                        projectComboBox.SelectedItem = lastProject;
                    }
                    else
                    {
                        MessageBox.Show(lastProject + " is no longer in project list");

                        if (projectComboBox.Items.Count > 0)
                        {
                            projectComboBox.SelectedIndex = 0;
                        }
                    }
                }

                if (!String.IsNullOrEmpty(lastCode) && codeComboBox.Items.Contains(lastCode))
                {
                    codeComboBox.SelectedItem = lastCode;
                }
                else
                {
                    if (codeComboBox.Items.Count > 0)
                    {
                        codeComboBox.SelectedIndex = 0;
                    }
                }

                if (!String.IsNullOrEmpty(lastDesc))
                {
                    descTextBox.Text = lastDesc;
                }

                if (!String.IsNullOrEmpty(lastExtension) && extensionComboBox.Items.Contains(lastExtension))
                {
                    extensionComboBox.SelectedItem = lastExtension;
                }
                else
                {
                    if (extensionComboBox.Items.Count > 0)
                    {
                        extensionComboBox.SelectedIndex = 0;
                    }
                }

                if (!String.IsNullOrEmpty(lastHours))
                {
                    hoursTextBox.Text = lastHours;
                }

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
            }
        }
    }
}

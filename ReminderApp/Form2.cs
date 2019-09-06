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
    public partial class Form2 : Form
    {
        private SHDocVw.WebBrowser_V1 Web_V1;
        private HTMLDocument timesheet = new HTMLDocument();
        HTMLInputElement teamCheckBox;
        HTMLSelectElement projectList;
        HTMLSelectElement codeList;
        HTMLSelectElement technologyList;
        HTMLInputElement descTextInput;
        HTMLInputElement hoursTextInput;
        HTMLInputElement addButton;

        bool technologyComboUpdateRequired = false;
        string selectedTechnology = String.Empty;

        List<Booking> bookingList = new List<Booking>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(new Uri("http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx"));

            if (Properties.Settings.Default.prevTenBookings != null) {
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

                    bookingList.Add(parsedBooking);

                    recentListBox.Items.Add(parsedBooking.project + ", " + parsedBooking.description + ", " + parsedBooking.bookedHours + " hrs");
                    if (bookingList.Count >= 10) { break; }
                }
            } else
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

                        teamCheckBox = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListProjects_2", 0);

                        teamCheckBox.@checked = true;

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

                        hoursTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxHours", 0);

                        string lastHours = Properties.Settings.Default.lastBookedHours;

                        if (!String.IsNullOrEmpty(lastHours))
                        {
                            hoursTextBox.Text = lastHours;
                        }

                        addButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_ButtonAdd", 0);
                    }
                }
            } catch (Exception exception)
            {
                MessageBox.Show("Unable to connect to timesheet page, please check your connection");
                noteRadioButton.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timesheetRadioButton.Checked)
            {

                projectList.selectedIndex = projectComboBox.SelectedIndex;
                if (technologyComboBox.Items.Count > 0)
                {
                    technologyList.selectedIndex = technologyComboBox.SelectedIndex;
                }
                codeList.selectedIndex = codeComboBox.SelectedIndex;
                descTextInput.value = descTextBox.Text;
                hoursTextInput.value = hoursTextBox.Text;

                addButton.click();

                Properties.Settings.Default.lastBookedProject = projectComboBox.Text;
                Properties.Settings.Default.lastBookedCode = codeComboBox.Text;
                Properties.Settings.Default.lastBookedTechnology = technologyComboBox.Text;
                Properties.Settings.Default.lastBookedDesc = descTextBox.Text;
                Properties.Settings.Default.lastBookedHours = hoursTextBox.Text;
                Properties.Settings.Default.Save();

                string booking = projectComboBox.Text + "\n" + codeComboBox.Text + "\n" +
                    descTextBox.Text + "\n" + hoursTextBox.Text + "\n" + technologyComboBox.Text;
                if (!Properties.Settings.Default.prevTenBookings.Contains(booking))
                {
                    Properties.Settings.Default.prevTenBookings.Insert(0,booking);
                } else
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
            this.Close();
        }

        private void timesheetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeVisibility();
        }

        private void noteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeVisibility();
        }

        private void changeVisibility ()
        {
            if (timesheetRadioButton.Checked)
            {
                noteTextBox.Visible = false;

                recentListBox.Visible = true;
                projectComboBox.Visible = true;
                codeComboBox.Visible = true;
                descTextBox.Visible = true;
                hoursTextBox.Visible = true;

                bookingsLabel.Text = "Recent Bookings";
                projectLabel.Visible = true;
                codeLabel.Visible = true;
                descriptionLabel.Visible = true;
                hoursLabel.Visible = true;
            }
            else
            {
                noteTextBox.Visible = true;

                recentListBox.Visible = false;
                projectComboBox.Visible = false;
                codeComboBox.Visible = false;
                descTextBox.Visible = false;
                hoursTextBox.Visible = false;

                bookingsLabel.Text = "Note";
                projectLabel.Visible = false;
                codeLabel.Visible = false;
                descriptionLabel.Visible = false;
                hoursLabel.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void recentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProject = bookingList[recentListBox.SelectedIndex].project;
            string selectedCode = bookingList[recentListBox.SelectedIndex].code;
            string selectedDesc = bookingList[recentListBox.SelectedIndex].description;
            selectedTechnology = bookingList[recentListBox.SelectedIndex].technology;
            string selectedHours = bookingList[recentListBox.SelectedIndex].bookedHours;



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

            if (!String.IsNullOrEmpty(selectedHours))
            {
                hoursTextBox.Text = selectedHours;
            }
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

            technologyList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListTechnology", 0);

            technologyComboBox.Items.Clear();
            foreach (var item in technologyList.options)
            {
                technologyComboBox.Items.Add(item.innerText);
            }
            if (technologyComboBox.Items.Count > 0)
            {
                technologyComboBox.SelectedIndex = 0;
            }

            if (technologyComboUpdateRequired)
            {
                technologyComboBox.SelectedItem = selectedTechnology;
                selectedTechnology = String.Empty;
            }

            codeList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListCode", 0);

            descTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxDescription", 0);

            hoursTextInput = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_TextBoxHours", 0);

            addButton = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_ButtonAdd", 0);
            button1.Enabled = true;
            timer1.Stop();
        }

        private void codeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeList.selectedIndex = codeComboBox.SelectedIndex;

            //timer1.Start();
        }
    }
}

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
        HTMLInputElement descTextInput;
        HTMLInputElement hoursTextInput;
        HTMLInputElement addButton;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(new Uri("http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx"));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                if (webBrowser1.Url.ToString() == "http://intranet.cougar-automation.co.uk/Timesheet/Timesheet.aspx")
                {
                    Web_V1 = (SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance;
                    
                    timesheet = (HTMLDocument)Web_V1.Document;

                    teamCheckBox = (HTMLInputElement)timesheet.all.item("ContentPlaceHolder1_RadioButtonListProjects_2", 0);

                    teamCheckBox.@checked = true;

                    projectList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListProject", 0);

                    foreach (var item in projectList.options)
                    { 
                        projectComboBox.Items.Add(item.innerText); 
                    }
                    string lastProject = Properties.Settings.Default.lastBookedProject;

                    if (!String.IsNullOrEmpty(lastProject) && projectComboBox.Items.Contains(lastProject))
                    {
                        projectComboBox.SelectedItem = lastProject;
                    } else
                    {
                        projectComboBox.SelectedIndex = 0;
                    }

                    codeList = (HTMLSelectElement)timesheet.all.item("ContentPlaceHolder1_DropDownListCode", 0);
                
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timesheetRadioButton.Checked)
            {

                projectList.selectedIndex = projectComboBox.SelectedIndex;
                codeList.selectedIndex = codeComboBox.SelectedIndex;
                descTextInput.value = descTextBox.Text;
                hoursTextInput.value = hoursTextBox.Text;
                addButton.click();
            } else
            {
                try
                {
                    if (!String.IsNullOrEmpty(Properties.Settings.Default.filePath))
                    {
                        string selectedFilePath = Properties.Settings.Default.filePath;
                        File.AppendAllText(selectedFilePath + "\\Timesheet.txt",
                            DateTime.Now.DayOfWeek.ToString() + "\t" +
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
            Properties.Settings.Default.lastBookedProject = projectComboBox.Text;
            Properties.Settings.Default.lastBookedCode = codeComboBox.Text;
            Properties.Settings.Default.lastBookedDesc = descTextBox.Text;
            Properties.Settings.Default.lastBookedHours = hoursTextBox.Text;
            Properties.Settings.Default.Save();

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

                projectComboBox.Visible = true;
                codeComboBox.Visible = true;
                descTextBox.Visible = true;
                hoursTextBox.Visible = true;

                projectLabel.Text = "Project";
                codeLabel.Visible = true;
                descriptionLabel.Visible = true;
                hoursLabel.Visible = true;
            }
            else
            {
                noteTextBox.Visible = true;

                projectComboBox.Visible = false;
                codeComboBox.Visible = false;
                descTextBox.Visible = false;
                hoursTextBox.Visible = false;

                projectLabel.Text = "Note";
                codeLabel.Visible = false;
                descriptionLabel.Visible = false;
                hoursLabel.Visible = false;
            }
        }

        
    }
}

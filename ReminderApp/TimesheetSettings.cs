using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReminderApp
{
    public partial class TimesheetSettings : Form
    {
        string messageTime;
        string selectedFilePath;

        public TimesheetSettings()
        {
            InitializeComponent();
        }


        private void addTimeButton_Click(object sender, EventArgs e)
        {

            messageTime = reminderTimePicker.Text;
            if (!MainWindow.reminderTimes.ContainsKey(messageTime))
            {
                MainWindow.reminderTimes.Add(messageTime, DateTime.MinValue);
                timesListBox.Items.Add(messageTime);

                Properties.Settings.Default.selectedTimes.Add(messageTime);
                Properties.Settings.Default.Save();

                errorText.Text = "";
            }
            else
            {
                errorText.Text = "Time already added";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (timesListBox.SelectedIndex != -1)
            {
                MainWindow.reminderTimes.Remove(timesListBox.Items[timesListBox.SelectedIndex].ToString());
                Properties.Settings.Default.selectedTimes.Remove(timesListBox.Items[timesListBox.SelectedIndex].ToString());
                timesListBox.Items.Remove(timesListBox.Items[timesListBox.SelectedIndex]);

                Properties.Settings.Default.Save();
                errorText.Text = "";
            }
            else
                errorText.Text = "No time to remove.";
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = folderBrowserDialog.SelectedPath;
                filePath.Text = selectedFilePath;
                Properties.Settings.Default.filePath = selectedFilePath;
                Properties.Settings.Default.Save();
            }
        }

        private void TimesheetSettings_Load(object sender, EventArgs e)
        {
            reminderTimePicker.Format = DateTimePickerFormat.Time;
            reminderTimePicker.ShowUpDown = true;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.filePath))
            {
                filePath.Text = Properties.Settings.Default.filePath;
                selectedFilePath = Properties.Settings.Default.filePath;
            }
            if (Properties.Settings.Default.selectedTimes != null)
            {
                foreach (var item in Properties.Settings.Default.selectedTimes)
                {
                    timesListBox.Items.Add(item);
                }

                foreach (var item in timesListBox.Items)
                {
                    MainWindow.reminderTimes.Add(item.ToString(), DateTime.MinValue);
                }
            }
            else
            {
                Properties.Settings.Default.selectedTimes = new System.Collections.Specialized.StringCollection();
            }
        }
    }
}

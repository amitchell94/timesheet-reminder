using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace ReminderApp
{

    
    public partial class Form1 : Form
    {
        string currentTime;
        string messageTime;
        string selectedFilePath;
        private Dictionary<string, DateTime> reminderTimes = new Dictionary<string, DateTime>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = currentTime;
            TimeSpan fiveMinutes = new TimeSpan(0, 5 ,0);
            DateTime fiveMinutesAgo = DateTime.Now.Subtract(fiveMinutes);

            //Check whether the current time is in the list, if so then check that last time it was checked was longer than 5 minutes ago.
            if (reminderTimes.ContainsKey(currentTime) && ((DateTime.Compare(reminderTimes[currentTime], fiveMinutesAgo)) < 0) 
                && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                reminderTimes[currentTime] = DateTime.Now;

                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            messageTime = reminderTimePicker.Text;
            if (!reminderTimes.ContainsKey(messageTime))
            {
                reminderTimes.Add(messageTime, DateTime.MinValue);
                timesListBox.Items.Add(messageTime);

                Properties.Settings.Default.selectedTimes.Add(messageTime);
                Properties.Settings.Default.Save();

                errorText.Text = "";
            } else
            {
                errorText.Text = "Time already added";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timesListBox.SelectedIndex != -1)
            {
                reminderTimes.Remove(timesListBox.Items[timesListBox.SelectedIndex].ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            reminderTimePicker.Format = DateTimePickerFormat.Time;
            reminderTimePicker.ShowUpDown = true;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.filePath)) { 
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
                    reminderTimes.Add(item.ToString(), DateTime.MinValue);
                }
            }
            else
            {
                Properties.Settings.Default.selectedTimes = new System.Collections.Specialized.StringCollection();
            }

            minimiseCheckbox.Checked = Properties.Settings.Default.minimiseOnStart;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void minimiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimiseOnStart = minimiseCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.minimiseOnStart)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

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

            currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            label1.Text = currentTime;
            TimeSpan fiveMinutes = new TimeSpan(0, 5 ,0);
            DateTime fiveMinutesAgo = DateTime.Now.Subtract(fiveMinutes);

            //Check whether the current time is in the list, if so then check that last time it was checked was longer than 5 minutes ago.
            if (reminderTimes.ContainsKey(currentTime) && ((DateTime.Compare(reminderTimes[currentTime], fiveMinutesAgo)) < 0))
            {
                reminderTimes[currentTime] = DateTime.Now;
                string res = Interaction.InputBox("What are you doing right now?");

                try
                {
                    File.AppendAllText(selectedFilePath + "\\Sample.txt",
                        DateTime.Now.DayOfWeek.ToString() + "\t" +
                        DateTime.Now.ToString() + "\t" + res + Environment.NewLine);

                }
                catch (Exception exception)
                {
                    System.Console.Write(exception.StackTrace);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            messageTime = maskedTextBox1.Text + " " + comboBox1.Text;
            if (!reminderTimes.ContainsKey(messageTime))
            {
                reminderTimes.Add(messageTime, DateTime.MinValue);
                timesListBox.Items.Add(messageTime);
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
                timesListBox.Items.Remove(timesListBox.Items[timesListBox.SelectedIndex]);
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
            }
        }
    }
}

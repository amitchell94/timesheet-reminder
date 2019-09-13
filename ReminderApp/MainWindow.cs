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

    
    public partial class MainWindow : Form
    {
        string currentTime;
        string messageTime;
        string selectedFilePath;
        public static Dictionary<string, DateTime> reminderTimes = new Dictionary<string, DateTime>() ;

        public MainWindow()
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

                TimesheetEntry timesheetEntry = new TimesheetEntry();
                timesheetEntry.Show();
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


        private void Form1_Load(object sender, EventArgs e)
        {
            minimiseCheckbox.Checked = Properties.Settings.Default.minimiseOnStart;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimesheetEntry timesheetEntry = new TimesheetEntry();
            timesheetEntry.Show();
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
            TimesheetEntry timesheetEntry = new TimesheetEntry();
            timesheetEntry.Show();
        }

        private void movementSettingsButton_Click(object sender, EventArgs e)
        {
            MovementSettings movementSettings = new MovementSettings();
            movementSettings.Show();
        }

        private void timesheetSettingsButton_Click(object sender, EventArgs e)
        {
            TimesheetSettings timesheetSettings = new TimesheetSettings();
            timesheetSettings.Show();
        }

        private void generateOvertimeButton_Click(object sender, EventArgs e)
        {
            OvertimeFormGenerator overtimeFormGenerator = new OvertimeFormGenerator();
            overtimeFormGenerator.Show();
        }
    }
}

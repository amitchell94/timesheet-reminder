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

        public static Dictionary<string, DateTime> reminderTimes = new Dictionary<string, DateTime>() ;
        DateTime lastTimeMovementsReminded = DateTime.MinValue;
        DateTime lastTimeMovementsFilled = DateTime.MinValue;
        DateTime lastTimeMovementsFillAttempted = DateTime.MinValue;
        
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
            //This is to stop us having loads of windows pop up at one time.
            if (reminderTimes.ContainsKey(currentTime) && ((DateTime.Compare(reminderTimes[currentTime], fiveMinutesAgo)) < 0) 
                && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                reminderTimes[currentTime] = DateTime.Now;
                if (enableTimesheetReminder.Checked)
                {
                    TimesheetEntry timesheetEntry = new TimesheetEntry();
                    timesheetEntry.Show();
                }
            }

            if (enableMovements.Checked && DateTime.Now.ToString("dddd") == Properties.Settings.Default.movementDay && Properties.Settings.Default.movementTime == currentTime &&
                ((DateTime.Compare(lastTimeMovementsReminded, fiveMinutesAgo)) < 0))
            {
                MovementEntry movementEntry = new MovementEntry(Properties.Settings.Default.movementCurrentWeek);
                movementEntry.Show();
                lastTimeMovementsReminded = DateTime.Now;
            }


            if (Properties.Settings.Default.movementsAutofill)
            {
                DateTime lastSaturday = DateTime.Now.AddDays(-1);
                while (lastSaturday.DayOfWeek != DayOfWeek.Saturday)
                {
                    lastSaturday = lastSaturday.AddDays(-1);
                }
          
                //This is to make sure we only attempt to fill in movements once per hour.
                TimeSpan oneHour = new TimeSpan(1, 0, 0);
                DateTime oneHourAgo = DateTime.Now.Subtract(oneHour);

                if (((DateTime.Compare(lastTimeMovementsFilled, lastSaturday) < 0)) && (DateTime.Compare(lastTimeMovementsFillAttempted, oneHourAgo) < 0))
                {
                    lastTimeMovementsFillAttempted = DateTime.Now;
                    webBrowser1.ScriptErrorsSuppressed = true;
                    webBrowser1.Navigate(new Uri("http://intranet.cougarautomation.net/Cats/Movements/MyMovements.aspx"));
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            minimiseCheckbox.Checked = Properties.Settings.Default.minimiseOnStart;
            enableMovements.Checked = Properties.Settings.Default.enableMovementReminders;
            enableTimesheetReminder.Checked = Properties.Settings.Default.enableTimesheetReminders;

            reminderTimes.Clear();
            if (Properties.Settings.Default.selectedTimes != null)
            {
                foreach (var item in Properties.Settings.Default.selectedTimes)
                {
                    reminderTimes.Add(item.ToString(), DateTime.MinValue);
                }
            }
            else
            {
                Properties.Settings.Default.selectedTimes = new System.Collections.Specialized.StringCollection();
            }
        }

        private void bookNowButton_Click(object sender, EventArgs e)
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

        private void enableTimesheetReminder_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.enableTimesheetReminders = true;
            Properties.Settings.Default.Save();
        }

        private void fillThisWeek_Click(object sender, EventArgs e)
        {
            MovementEntry movementEntry = new MovementEntry(true);
            movementEntry.Show();
        }

        private void fillNextWeek_Click(object sender, EventArgs e)
        {
            MovementEntry movementEntry = new MovementEntry(false);
            movementEntry.Show();
        }

        private void enableMovements_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.enableMovementReminders = true;
            Properties.Settings.Default.Save();
        }

        private void timesheetBooking_Click(object sender, EventArgs e)
        {
            TimesheetEntry timesheetEntry = new TimesheetEntry();
            timesheetEntry.Show();
        }

        private void movementsThisWeek_Click(object sender, EventArgs e)
        {
            MovementEntry movementEntry = new MovementEntry(true);
            movementEntry.Show();
        }

        private void movementsNextWeek_Click(object sender, EventArgs e)
        {
            MovementEntry movementEntry = new MovementEntry(false);
            movementEntry.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                {
                    if (webBrowser1.Url.ToString() == "http://intranet.cougarautomation.net/Cats/Movements/MyMovements.aspx")
                    {
                        MovementFiller.fillAllMovements((SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance);
                    }
                }
            } catch (Exception exception)
            {
                lastTimeMovementsFilled = DateTime.MinValue;
                return;
            }

            lastTimeMovementsFilled = DateTime.Now;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(3000);
                e.Cancel = true;
            }
        }
    }
}

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
        //List<ReminderTime> reminderTimes = new List<ReminderTime>();
        private Dictionary<string, DateTime> reminderTimes = new Dictionary<string, DateTime>();
        bool complete = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 

            currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            label1.Text = currentTime;
            TimeSpan fiveMinutes = new TimeSpan(0, 5 ,0);
            DateTime fiveMinutesAgo = DateTime.Now.Subtract(fiveMinutes);

            if (reminderTimes.ContainsKey(currentTime) && ((DateTime.Compare(reminderTimes[currentTime], fiveMinutesAgo)) < 0))
            {
                reminderTimes[currentTime] = DateTime.Now;
                string res = Interaction.InputBox("What are you doing right now?");

                try
                {

                    if (!complete)
                    {
                        StreamWriter sw = new StreamWriter("C:\\Users\\andym\\Documents\\Sample.txt");

                        sw.WriteLine("Timesheet entries");
                        sw.Close();
                        complete = true;
                    }

                    File.AppendAllText(@"C:\\Users\\andym\\Documents\\Sample.txt",
                        DateTime.Now.DayOfWeek.ToString() + "\t" +
                        DateTime.Now.ToString() + "\t" + res + Environment.NewLine);

                }
                catch (Exception exception)
                {
                    System.Console.Write(exception.StackTrace);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            messageTime = maskedTextBox1.Text + " " + comboBox1.Text;
            reminderTimes.Add(messageTime, DateTime.MinValue);
            timesListBox.Items.Add(messageTime);
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
    }
}

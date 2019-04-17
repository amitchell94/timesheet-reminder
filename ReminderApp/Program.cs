using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //TODO:
        //Add checkbox to ask if user wants app to start minimised to tray
        //Deal with filePath errors
        //Add recently selected projects
        //Add other dropdowns from timesheet page
        //Deal with connection errors
        //Add time reminded in popup title
        //Backlog unsubmitted timesheet entries?
        //Add context menu to notificon
        //Reduce the amount of times checked?
    }
}

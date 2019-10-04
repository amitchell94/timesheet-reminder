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
            Application.Run(new MainWindow());
        }

        //TODO:
        //Delete note taking file path
        //Confirm recently booked projects is working as expected.
        //Add radio buttons for all, teams, projects.
        //Add help file?
        //Add version no.?
        //Backlog unsubmitted timesheet entries?
        //Reduce the amount of times checked?
    }
}

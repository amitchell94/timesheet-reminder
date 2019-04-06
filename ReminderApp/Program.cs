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
        //1) Need to add ability to remove added times
        //2) Clean up form layout
        //3) Have application start minimised to tray
        //4) Store times on next start of application
        //5) Ask if user is still doing a certain task intead of typing in everytime
        //6) Perhaps try to use toast notifications instead of inputBoxes


    }
}

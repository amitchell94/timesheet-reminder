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
    public partial class MovementSettings : Form
    {
        public MovementSettings()
        {
            InitializeComponent();
        }

        private void MovementSettings_Load(object sender, EventArgs e)
        {

            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.ShowUpDown = true;

            if (Properties.Settings.Default.movementCurrentWeek )
            {
                nextWeekRadioButton.Checked = false;
                thisWeekRadioButton.Checked = true;
            }
            else
            {
                nextWeekRadioButton.Checked = true;
                thisWeekRadioButton.Checked = false;
            }

            if (Properties.Settings.Default.movementDay != String.Empty)
            {
                dayComboBox.SelectedItem = Properties.Settings.Default.movementDay;
            } else
            {
                dayComboBox.SelectedItem = "Friday";
            }

            if (Properties.Settings.Default.movementTime != String.Empty)
            {
                dateTimePicker.Text = Properties.Settings.Default.movementTime;
            }
            else
            {
                dayComboBox.SelectedItem = "16:00:00";
            }

            if (Properties.Settings.Default.movementsAutofill)
            {
                autofillCheckBox.Checked = true;
            }
            else
            {
                autofillCheckBox.Checked = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.movementCurrentWeek = thisWeekRadioButton.Checked;
            Properties.Settings.Default.movementDay = dayComboBox.Text;
            Properties.Settings.Default.movementTime = dateTimePicker.Text;
            Properties.Settings.Default.movementsAutofill = autofillCheckBox.Checked;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

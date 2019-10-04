using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mshtml;
using System.Windows.Forms;

namespace ReminderApp
{
    public partial class MovementEntry : Form
    {
        private SHDocVw.WebBrowser_V1 Web_V1;
     
        private List<HTMLInputElement> movementInputs = new List<HTMLInputElement>();

        HTMLInputElement submitButton;
        HTMLInputElement htmlMonInput;
        HTMLInputElement htmlTueInput;
        HTMLInputElement htmlWedInput;
        HTMLInputElement htmlThuInput;
        HTMLInputElement htmlFriInput;

        bool thisWeek;

        public MovementEntry(bool thisWeek)
        {
            this.thisWeek = thisWeek;
            InitializeComponent();
        }

        private void MovementEntry_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(new Uri("http://intranet.cougar-automation.co.uk/Cats/Movements/MyMovements.aspx"));

            okButton.Enabled = false;
            mondayInput.Enabled = false;
            tuesdayInput.Enabled = false;
            wednesdayInput.Enabled = false;
            thursdayInput.Enabled = false;
            fridayInput.Enabled = false;

            if (thisWeek)
            {
                movementsGroupBox.Text = "This Weeks Movements";
            } else
            {
                movementsGroupBox.Text = "Next Weeks Movements";
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                {
                    if (webBrowser1.Url.ToString() == "http://intranet.cougar-automation.co.uk/Cats/Movements/MyMovements.aspx")
                    {

                        Web_V1 = (SHDocVw.WebBrowser_V1)webBrowser1.ActiveXInstance;

                        HTMLDocument movements = new HTMLDocument();
                        movements = (HTMLDocument)Web_V1.Document;


                        if (thisWeek)
                        {
                            htmlMonInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisMonday", 0);
                            htmlTueInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisTuesday", 0);
                            htmlWedInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisWednesday", 0);
                            htmlThuInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisThursday", 0);
                            htmlFriInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisFriday", 0);
                        }
                        else
                        {
                            htmlMonInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextMonday", 0);
                            htmlTueInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextTuesday", 0);
                            htmlWedInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextWednesday", 0);
                            htmlThuInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextThursday", 0);
                            htmlFriInput = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextFriday", 0);
                        }

                        setDayText(htmlMonInput, mondayInput);
                        setDayText(htmlTueInput, tuesdayInput);
                        setDayText(htmlWedInput, wednesdayInput);
                        setDayText(htmlThuInput, thursdayInput);
                        setDayText(htmlFriInput, fridayInput);

                        submitButton = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_ButtonAccept", 0);

                        okButton.Enabled = true;
                        mondayInput.Enabled = true;
                        tuesdayInput.Enabled = true;
                        wednesdayInput.Enabled = true;
                        thursdayInput.Enabled = true;
                        fridayInput.Enabled = true;
                    }
                }
            } catch (Exception exception)
            {
                MessageBox.Show("Unable to connect to movements page, please check your connection");
                this.Close();
            }
        }

        private void setDayText(HTMLInputElement htmlInput, TextBox textBox)
        {
            if (htmlInput.value != String.Empty)
            {
                textBox.Text = htmlInput.value;
            }
            else
            {
                textBox.Text = "IN";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            htmlMonInput.value = mondayInput.Text;
            htmlTueInput.value =  tuesdayInput.Text;
            htmlWedInput.value =  wednesdayInput.Text;
            htmlThuInput.value =  thursdayInput.Text;
            htmlFriInput.value = fridayInput.Text;

            submitButton.click();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mondayInput_Enter(object sender, EventArgs e)
        {
            // Kick off SelectAll asyncronously so that it occurs after Click
            BeginInvoke((Action)delegate
            {
                mondayInput.SelectAll();
            });
        }

        private void tuesdayInput_Enter(object sender, EventArgs e)
        {
            // Kick off SelectAll asyncronously so that it occurs after Click
            BeginInvoke((Action)delegate
            {
                tuesdayInput.SelectAll();
            });
        }

        private void wednesdayInput_Enter(object sender, EventArgs e)
        {
            // Kick off SelectAll asyncronously so that it occurs after Click
            BeginInvoke((Action)delegate
            {
                wednesdayInput.SelectAll();
            });
        }

        private void thursdayInput_Enter(object sender, EventArgs e)
        {
            // Kick off SelectAll asyncronously so that it occurs after Click
            BeginInvoke((Action)delegate
            {
                thursdayInput.SelectAll();
            });
        }

        private void fridayInput_Enter(object sender, EventArgs e)
        {
            // Kick off SelectAll asyncronously so that it occurs after Click
            BeginInvoke((Action)delegate
            {
                fridayInput.SelectAll();
            });
        }

        private void fillEmptys_Click(object sender, EventArgs e)
        {
            checkAndFillWithIn(mondayInput);
            checkAndFillWithIn(tuesdayInput);
            checkAndFillWithIn(wednesdayInput);
            checkAndFillWithIn(thursdayInput);
            checkAndFillWithIn(fridayInput);
        }

        private void checkAndFillWithIn (TextBox textBox)
        {
            if (textBox.Text == String.Empty)
            {
                textBox.Text = "IN";
            }
        }
    }
}

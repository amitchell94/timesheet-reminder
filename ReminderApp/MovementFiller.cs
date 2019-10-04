using mshtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp
{
    class MovementFiller
    {

        public static void fillAllMovements(SHDocVw.WebBrowser_V1 Web_V1)
        {
            HTMLDocument movements = new HTMLDocument();
            movements = (HTMLDocument)Web_V1.Document;

            HTMLInputElement thisMonBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisMonday", 0);
            HTMLInputElement thisTueBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisTuesday", 0);
            HTMLInputElement thisWedBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisWednesday", 0);
            HTMLInputElement thisThuBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisThursday", 0);
            HTMLInputElement thisFriBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxThisFriday", 0);

            HTMLInputElement nextMonBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextMonday", 0);
            HTMLInputElement nextTueBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextTuesday", 0);
            HTMLInputElement nextWedBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextWednesday", 0);
            HTMLInputElement nextThuBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextThursday", 0);
            HTMLInputElement nextFriBox = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextFriday", 0);

            HTMLInputElement nextMon2Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextMonday2", 0);
            HTMLInputElement nextTue2Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextTuesday2", 0);
            HTMLInputElement nextWed2Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextWednesday2", 0);
            HTMLInputElement nextThu2Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextThursday2", 0);
            HTMLInputElement nextFri2Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextFriday2", 0);

            HTMLInputElement nextMon3Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextMonday3", 0);
            HTMLInputElement nextTue3Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextTuesday3", 0);
            HTMLInputElement nextWed3Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextWednesday3", 0);
            HTMLInputElement nextThu3Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextThursday3", 0);
            HTMLInputElement nextFri3Box = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_TextBoxNextFriday3", 0);

            List<HTMLInputElement> movementInputs = new List<HTMLInputElement>();

            movementInputs.Add(thisMonBox);
            movementInputs.Add(thisTueBox);
            movementInputs.Add(thisWedBox);
            movementInputs.Add(thisThuBox);
            movementInputs.Add(thisFriBox);
            movementInputs.Add(nextMonBox);
            movementInputs.Add(nextTueBox);
            movementInputs.Add(nextWedBox);
            movementInputs.Add(nextThuBox);
            movementInputs.Add(nextFriBox);
            movementInputs.Add(nextMon2Box);
            movementInputs.Add(nextTue2Box);
            movementInputs.Add(nextWed2Box);
            movementInputs.Add(nextThu2Box);
            movementInputs.Add(nextFri2Box);
            movementInputs.Add(nextMon3Box);
            movementInputs.Add(nextTue3Box);
            movementInputs.Add(nextWed3Box);
            movementInputs.Add(nextThu3Box);
            movementInputs.Add(nextFri3Box);

            foreach (var item in movementInputs)
            {
                if (string.IsNullOrEmpty(item.value))
                {
                    item.value = "IN";
                }
            }

            HTMLInputElement submit = (HTMLInputElement)movements.all.item("ContentPlaceHolder1_ButtonAccept", 0);
            submit.click();
        }

    }
}

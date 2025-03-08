using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR: Miles Childress
//COURSE: ISTM 250.501
//FORM: frmChangeCalculator
//PURPOSE: This program is designed to take an input of a number from 0-99 and calculate how many quarters, dimes, nickels, and pennies make up that change amount
//INPUT: This program takes the input from the Amount change due text box.
//PROCESS: This program uses click events to perform the calculations that determine how many quarters,dimes,nickels, and pennies make up the change amount.
//OUTPUT: The output is put into the quarters, dimes, nickels, and pennies text boxes.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress

namespace ChildressMilesChangeCalculator
{
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void BTNCalculate_Click(object sender, EventArgs e)
        {
            int change = int.Parse(TXTAmountChangeDue.Text);
            int quarters = 0, dimes = 0, nickels = 0, pennies = 0;

          //  if (change > 24) ***much easier to do with while loops so these if and if else statements are commented out
          //  {
           //     change -= 25;
           //     quarters++;
           // }
           // else if (change > 9)
            //{
              //  change -= 10;
                //dimes++;
            //}
           // else if (change )

            while(change > 24) //while the input is above 24, 25 is subtracted from change and the quarter variable is incremented by 1
            {
                change -= 25;
                quarters++;
            }
            while(change > 9) //while the input is above 9, 10 is subtracted from change and dimes variables is incremented by 1
            {
                change -= 10;
                dimes++;
            }
            while (change > 4) //while the input is above 4, 5 is subtracted from change and the nickels variables is incremented by 1
            {
                change -= 5;
                nickels++;
            }
            pennies = change; //no need for a while loop for the pennies because the change variable will be acted upon by the while loops until its value is less than a nickel which allows me to set the pennies variable equal to change

            TXTQuarters.Text = quarters.ToString();
            TXTDimes.Text = dimes.ToString();
            TXTNickels.Text = nickels.ToString();
            TXTPennies.Text = pennies.ToString();
            TXTAmountChangeDue.Focus();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }
    }
}

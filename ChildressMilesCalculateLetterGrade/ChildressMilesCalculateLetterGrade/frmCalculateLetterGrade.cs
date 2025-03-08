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
//FORM: frmCalculateLetterGrade
//PURPOSE: This program is designed to take the user's input of their "number grade" and determine which "letter grade" correlates with the number provided and then return that letter when the user clicks the calculate button.
//INPUT: The user must enter a valid number grade for the program to run. 
//PROCESS: This program uses methods such as ToDecimal to turn the letter grade into a decimal to be stored in a variable named decNumberGrade which is used to evaluate the correct letter grade to display. 
//OUTPUT: The letter grade that correlates with the number grade entered by the user is displayed through the variable strLetterGrade. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work." Signature: Miles Childress



namespace ChildressMilesCalculateLetterGrade
{
    public partial class FRMCalculateGrade : Form
    {
        public FRMCalculateGrade()
        {
            InitializeComponent();
        }

        private void TXTNumberGrade_TextChanged(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
            //closes the program when the exit button is clicked or ESC key
            Close();
        }

        private void BTNCalculate_Click(object sender, EventArgs e)
        {
            //converts the input number grade to a decimal and stores it in a decimal variable named decNumberGrade
            //if the input is not a number there is a try catch block to send a message to the user saying "That's not a number!"
            decimal decNumberGrade;
            try
            {
                 decNumberGrade = Convert.ToDecimal(TXTNumberGrade.Text);
            }
            catch
            {
                MessageBox.Show("That's not a number!");
                return;
            }
            //declaring the variable strLetterGrade and initializing it as an empty string
            string strLetterGrade = "";

            //calclulation and interpretation of decNumberGrade to determine the correct letter grade that correlates with decNumberGrade
            if (decNumberGrade >= 88)
            {
                strLetterGrade = "A";
            }
            else if(decNumberGrade >= 80 && decNumberGrade <= 87)
            {
                strLetterGrade = "B";
            }
            else if(decNumberGrade >= 68 && decNumberGrade <= 79)
            {
                strLetterGrade = "C";
            }
            else if(decNumberGrade >= 60 && decNumberGrade <= 67)
            {
                strLetterGrade = "D";
            }
            else if (decNumberGrade < 0)
            {
                //check to see if the grade is above a zero as it is not possible for a grade to be negative
                strLetterGrade = "N/A";
            }
            else
            {
                strLetterGrade = "F";
            }
            TXTLetterGrade.Text = strLetterGrade;
            TXTNumberGrade.Focus();
        }
    }
}

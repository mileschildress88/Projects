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
//FORM: frmFactorial
//PURPOSE: This program is designed to take an input of a number from 1-20 and calculate the factorial of the number that was inputed and place the result into a textbox.
//INPUT: This program takes the input from the number textbox.
//PROCESS: This program uses click events to perform the calculations of the factorial to then put in a text box and change the focus back to the number textbox. 
//OUTPUT: The output is put into the factorial text box. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress

namespace ChildressMilesFactorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void BTNCalculate_Click(object sender, EventArgs e)
        {
            //when the calculate button is clicked it calculates the factorial and places it into the factorial textbox
            Int64 fact = 1; //made Int64 to hold the large factorial numbers. value starts at 1 to allow calculate in for loop to work correctly.
            int num = int.Parse(TXTNumber.Text); //takes the input and places it into num
            for(int i = 1; i <= num; i++) //for loop establishes a counter "i" at 1 and while this counter is less than or equal to the input it takes the int "fact" and sets it equal to itself multiplied by the counter for each loop.
            {
                fact = fact * i;
            }
            TXTFactorial.Text = fact.ToString("#,#"); //use this to string variant to get rid of decimals and place commas in between 
            TXTNumber.Focus();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }
    }
}

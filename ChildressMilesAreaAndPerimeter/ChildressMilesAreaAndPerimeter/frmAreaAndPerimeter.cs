using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR: Miles Childress
//COURSE: ISTM 250.501
//FORM: frmAreaAndPerimeter
//PURPOSE: This program is designed to take the input of a length and width from the user and calculate the area and perimeter.
//INPUT: This program takes the input from the length and width text boxes.
//PROCESS: This program uses click events to register when the calculations of the length and width should be processed. 
//OUTPUT: The output is put in the Area and Perimeter text boxes for the user to see. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress

namespace ChildressMilesAreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void BTNCalculate_Click(object sender, EventArgs e)
            //when the calculate button is clicked, the program takes the text input from the user and stores it in two decimal values. If these decimal values are not entered or are less than 0 a message box will appear
            //prompting them to enter a valid input. Then, the program takes these inputs and calculates the appropriate area and perimeter for the entered length and width values. 
        {
            try
            {
                decimal length = Decimal.Parse(TXTLength.Text);
                decimal width = Decimal.Parse(TXTWidth.Text);
                if (length < 0 || width < 0)
                {
                    MessageBox.Show("Please enter a valid length and width.");
                    TXTArea.Text = "";
                    TXTPerimeter.Text = "";
                }
                else
                {
                    TXTArea.Text = (length * width).ToString();
                    TXTPerimeter.Text = ((2 * length) + (2 * width)).ToString();
                    TXTLength.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid length and width.");
                return;
            }
        
          
        }

        private void BTNExit_Click(object sender, EventArgs e)
            //closes the program
        {
            Close();
        }
    }
}

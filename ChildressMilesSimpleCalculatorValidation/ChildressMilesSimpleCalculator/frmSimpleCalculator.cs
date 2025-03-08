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
//FORM: frmSimpleCalculator
//PURPOSE: This program is desgined to take the users inputs in the text boxes to determine the output of two operands based on an operator the user chooses
//INPUT: The input for this program is the users input into the text boxes for the operators and operands
//PROCESS: This program calculates the answer based upon the inputs of two operands and one operator
//OUTPUT: The output from this program is in the results text box and it shows the result of the operations between the two operands and operator
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work." Signature: Miles Childress
namespace ChildressMilesSimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }


        private decimal Calculate(decimal decOperand1, decimal decOperand2)
        {
            decimal result = 0;
            string Operator = TXTOperator.Text;

            switch(TXTOperator.Text)
            {
                case "+": result = decOperand1 + decOperand2; break; //different cases for the switch statement based on the users input in the text box
                case "-": result = decOperand1 - decOperand2; break;
                case "/": result = decOperand1 / decOperand2; break;
                case "*": result = decOperand1 * decOperand2; break;
                default: result = 0; break;
            }
            TXTResult.Text = Math.Round(result,4).ToString();
            return result;
        }

        private void BTNCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {


                    decimal decOperand1 = decimal.Parse(TXTOperand1.Text);
                    decimal decOperand2 = decimal.Parse(TXTOperand2.Text);
                    decimal result = Calculate(decOperand1, decOperand2);
                    TXTResult.Text = result.ToString();
                    TXTOperand1.Focus();
                }
            }
           
         /*   catch (FormatException)
            {
                MessageBox.Show("A Format Exception has occured. Please check all entries.", "Entry Error");
            }
            catch(OverflowException) 
            {
                MessageBox.Show("An Overflow Exception has occured. Please enter smaller values.", "Entry Error");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("A DivideByZeroException has occured. Please divide by a number other than zero.");
         */   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
             }
        }

            private void BTNExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXTOperand1_TextChanged(object sender, EventArgs e)
        {
            TXTResult.Clear();
            
        }

        private void TXTOperator_TextChanged(object sender, EventArgs e)
        {
            TXTResult.Clear();
            
        }

        private void TXTOperand2_TextChanged(object sender, EventArgs e)
        {
            TXTResult.Clear();
          
        }

        #region
        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if(!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if(Decimal.TryParse(value, out decimal number))
            {
                if(number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

        private string IsOperator(string value, string name)
        {
            string msg = "";
            if (value == "+" || value == "-" || value == "*" || value == "/")
            {
                msg = "";
            }
            else
            {
                msg += name + " must be +, -, *, /";
            }
            return msg;
            
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //validate operand1 and operand2 for IsDecimal and IsWithinRange
            errorMessage += IsDecimal(TXTOperand1.Text, TXTOperand1.Tag.ToString());
            errorMessage += IsDecimal(TXTOperand2.Text, TXTOperand2.Tag.ToString());
            errorMessage += IsWithinRange(TXTOperand1.Text, TXTOperand1.Tag.ToString(),0,99999);
            errorMessage += IsWithinRange(TXTOperand2.Text, TXTOperand2.Tag.ToString(), 1,99999);

            //operator contains a valid operator
            errorMessage += IsOperator(TXTOperator.Text, TXTOperator.Tag.ToString());

            if(errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry error");
            }
            return success;
        }
        #endregion
    }
}

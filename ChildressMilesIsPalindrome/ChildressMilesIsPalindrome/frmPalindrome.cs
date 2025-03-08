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
//FORM: frmPalindrome
//PURPOSE: This program is designed to take a string input from the user and determine if it is a palindrome or not
//INPUT: This program takes the input from the input textbox.
//PROCESS: This program uses click events to check if the string input is a palindrome
//OUTPUT: The output is displayed in a message box describing to the user whether their input is a palindrome or not
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress




namespace ChildressMilesIsPalindrome
{
    public partial class frmPalindrome : Form
    {
        public frmPalindrome()
        {
            InitializeComponent();
        }

        private void BTNCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    string strPalindrome = TXTInput.Text;

                    string strStrippedPalindrome = CharacterStrip(strPalindrome);

                    if (IsPalindrome(strStrippedPalindrome))
                    {
                        MessageBox.Show(TXTInput.Text + " is a Palindrome.", "Success");
                    }
                    else
                    {
                        MessageBox.Show(TXTInput.Text + " is NOT a Palindrome.", "Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        
        }

        private string CharacterStrip(string input)
        {
            //  return input.Trim();
            string strPhrase = "";
            foreach(char c in input)
            {
                strPhrase += c;
            }
            return strPhrase;
        }

        private bool IsPalindrome(string input)
        {
            // string strReverseString = ""; //setting up a variable to put the reverse of the input into
            //string strTrimmedInput = CharacterStrip(input);
            //for(int i = strTrimmedInput.Length -1; i >= 0; i--) //using a for loop to start at the end of the input string and add from right to left the characters in the string
            //{
            //   strReverseString += strTrimmedInput[i];
            //}

            // if (input == strReverseString) 
            //{
            //  return true;
            //}
            //else
            //{
            //  return false;

            int intBeggining = 0;
            int intEnd = input.Length - 1;

            while(intBeggining < intEnd) //checking to see if beggining index is less than ending index to continue loop
            {
                char charBeggining = input[intBeggining]; //checking first character in the string
                char charEnd = input[intEnd]; //checking last character in the string

                if(char.ToLower(charBeggining) != char.ToLower(charEnd)) //checking to see if the chars even when lowercase do not match then return false
                {
                    return false;
                }
                intBeggining++; //if not false increment beggining index
                intEnd--; //if not false decrement ending index
                
            }
            return true;
        }
        

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //validate operand1 and operand2 for IsDecimal and IsWithinRange
            errorMessage += IsPresent(TXTInput.Text, TXTInput.Tag.ToString());
            




            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry error");
            }
            return success;
        }

        #endregion
    }
}

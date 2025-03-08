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
//FORM: Form 1 (didnt want to destroy the program by changing form name)
//PURPOSE: This program is made to take input from the user and split up and parse the text to provide a cleaner version of the information to the user
//INPUT: This program takes the input from multiple text boxes.
//PROCESS: This program uses click events to perform parse and order the text in order to make it look clean. 
//OUTPUT: The output is put into message boxes.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress



namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    string strEmail = txtEmail.Text.Trim();
                    string name = "";
                    string domain = "";

                    if (!strEmail.Contains("@"))
                    {
                        MessageBox.Show("Error:" + " Invalid Email. Please add " + "@" + " and try again.");
                    }

                    int intIndex = strEmail.IndexOf("@");
                    name = strEmail.Substring(0, intIndex);
                    domain = strEmail.Substring(intIndex + 1, strEmail.Length - 1 - intIndex);

                    MessageBox.Show("Username: " + name + "\n" + "Domain name: " + domain);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {

            string strCity = txtCity.Text.Trim();
            string strState = txtState.Text.Trim();
            string strZip = txtZipCode.Text.Trim();

            string strAddress = "";

            string strInsertedAddress = strAddress.Insert(0, " " + strZip).Insert(0, " " + strState).Insert(0, " " + strCity);

            MessageBox.Show("City, State, Zip: " + strInsertedAddress);
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

        private string IsString(string value, string name)
        {
            string msg = "";
            if(value.GetType() != typeof(string))
            {
                msg += name + " must be a valid string value.\n";
            }
            return msg;
        }

        private string IsInt(string value, string name)
        {
            string msg = "";
            if (!int.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //validate
            
            errorMessage += IsPresent(txtEmail.Text, txtEmail.Tag.ToString());
            errorMessage += IsPresent(txtCity.Text, txtCity.Tag.ToString());
            errorMessage += IsPresent(txtState.Text, txtState.Tag.ToString());
            errorMessage += IsPresent(txtZipCode.Text, txtZipCode.Tag.ToString());

            errorMessage += IsString(txtEmail.Text, txtEmail.Tag.ToString());
            errorMessage += IsString(txtCity.Text, txtCity.Tag.ToString());
            errorMessage += IsString(txtCity.Text, txtCity.Tag.ToString());
            errorMessage += IsInt(txtZipCode.Text, txtZipCode.Tag.ToString());




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

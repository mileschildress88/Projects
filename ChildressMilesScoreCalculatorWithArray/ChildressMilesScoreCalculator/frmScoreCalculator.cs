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
//FORM: frmScoreCalculatorWithArray
//PURPOSE: This program is made to take the input of a "score" from the user and then calculate the score total, score count, and the average of the scores that were inputed. 
//INPUT: This program takes the input from the score textbox.
//PROCESS: This program uses click events to perform the calculations of the score total, score count, and average of the scores. 
//OUTPUT: The output is put into the score total textbox, the score count textbox, and the average text box. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress

namespace ChildressMilesScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        //global variables to keep memory of these values for every press of the "add" button
        int scoreTotal;
        int scoreCount;
        int averageScore;
        int[] intScores = new int[20];

        public frmScoreCalculator()
        {
            InitializeComponent();


        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //adds score to scoreTotal and increments scoreCount by 1 every time this button is pressed. Also calculates the average score and displays all of this information in the score total, score count, and average text boxes.
                    scoreTotal += int.Parse(TXTScore.Text);
                    intScores[scoreCount] = int.Parse(TXTScore.Text);
                    scoreCount++;
                    averageScore = scoreTotal / scoreCount;
                    TXTScoreTotal.Text = scoreTotal.ToString();
                    TXTScoreCount.Text = scoreCount.ToString();
                    TXTAverage.Text = averageScore.ToString();
                    TXTScore.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void BTNClearScores_Click(object sender, EventArgs e)
        {
            //clears the global variables and clears the text boxes.
            scoreTotal = 0;
            scoreCount = 0;
            averageScore = 0;
            TXTScore.Text = "";
            TXTScoreTotal.Text = "";
            TXTScoreCount.Text = "";
            TXTAverage.Text = "";
            TXTScore.Focus();
            intScores = new int[20];
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }

        private void BTNDisplayScores_Click(object sender, EventArgs e)
        {
            string message = "";
            Array.Sort(intScores);
            foreach (int score in intScores)
            {
                if (score == 0)
                {
                    message += "";
                }
                else
                {
                    message += score + "\n";
                }
            }
            MessageBox.Show(message, "Sorted Scores");
            TXTScore.Focus();
        }

        #region 
        //validation
        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
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

            //validate operand1 and operand2 for IsDecimal and IsWithinRange
            errorMessage += IsInt(TXTScore.Text, TXTScore.Tag.ToString());
            errorMessage += IsPresent(TXTScore.Text, TXTScore.Tag.ToString());
            

            

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
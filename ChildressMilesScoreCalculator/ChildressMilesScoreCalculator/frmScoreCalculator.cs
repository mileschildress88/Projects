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
//FORM: frmScoreCalculator
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

        public frmScoreCalculator()
        {
            InitializeComponent();
          

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            //adds score to scoreTotal and increments scoreCount by 1 every time this button is pressed. Also calculates the average score and displays all of this information in the score total, score count, and average text boxes.
            scoreTotal += int.Parse(TXTScore.Text);
            scoreCount++;
            averageScore = scoreTotal / scoreCount;
            TXTScoreTotal.Text = scoreTotal.ToString();
            TXTScoreCount.Text = scoreCount.ToString();
            TXTAverage.Text = averageScore.ToString();
            TXTScore.Focus();
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
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }
    }
}

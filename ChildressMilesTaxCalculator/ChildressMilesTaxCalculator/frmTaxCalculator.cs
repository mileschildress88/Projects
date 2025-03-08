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
//FORM: frmTaxCalculator
//PURPOSE: This program is designed to take an input from the user and determine the Income tax owed based on the input
//INPUT: This program takes the input from the Taxable income text box
//PROCESS: This program uses click events to calculate which tax bracket the input falls into and then returns the tax income owed
//OUTPUT: The output is put in the income tax owed textbox. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.” Signature: Miles Childress

namespace ChildressMilesTaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void BTNCalculate_Click(object sender, EventArgs e) //this method uses if and if else statements to determine which tax bracket the users input falls into and then puts it on the screen
        {
            decimal taxIncome = Decimal.Parse(TXTTaxableIncome.Text); 
            decimal taxIncomeOwed = 0m;
            if(taxIncome>0 && taxIncome < 9075) //first tax bracket
            {
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if(taxIncome>=9075 && taxIncome < 36900)
            {
                taxIncomeOwed = 907.5m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if(taxIncome>=36900 && taxIncome < 89350)
            {
                taxIncomeOwed = 5081.25m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if(taxIncome>=89350 && taxIncome < 186350)
            {
                taxIncomeOwed = 18193.75m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if(taxIncome>=186350 && taxIncome < 405100)
            {
                taxIncomeOwed = 45353.75m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if(taxIncome>=405100 && taxIncome <= 406750)
            {
                taxIncomeOwed = 117541.25m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            else if (taxIncome > 406750)
            {
                taxIncomeOwed = 118118.75m;
                TXTIncomeTaxOwed.Text = taxIncomeOwed.ToString("c");
            }
            TXTTaxableIncome.Focus();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }
    }
}

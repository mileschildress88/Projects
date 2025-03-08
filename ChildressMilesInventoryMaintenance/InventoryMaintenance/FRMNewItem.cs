using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class FRMNewItem : Form
    {
        public FRMNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares a new inventory item.
        public InvItem InvItem = null; 
        // Add a method here that gets and returns a new item.
        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return InvItem;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    // Add code here that populates a new item with the appropriate information and then closes the form.
                    InvItem = new InvItem(int.Parse(txtItemNo.Text), txtDescription.Text, decimal.Parse(txtPrice.Text));

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private bool IsValidData()
        {
            string strErrorMessage = ""; //this may or may not grow larger as we test our inputs.

            //add code here that checks each of the input textboxes and validates their input.
            //ispresent
            strErrorMessage += Validator.IsPresent(txtItemNo.Text,txtItemNo.Tag.ToString());
            strErrorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            strErrorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());

            //isint
            strErrorMessage += Validator.IsInteger(txtItemNo.Text, txtItemNo.Tag.ToString());

            //isdec
            strErrorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());
            


            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage);
                return false; 
            }
            else
            {
                return true; 
            }
        }
    }
}

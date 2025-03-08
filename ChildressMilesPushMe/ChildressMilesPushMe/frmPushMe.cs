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
//FORM: frmPushMe.cs
//PURPOSE: This program allows the user to click on four identical "Push Me" buttons. When one of these buttons is pressed, it will disappear while making the other buttons reappear.
// There is also an exit button that ends the program.
//INPUT: The data that this program will be collected is from the click input from the user on the buttons mentioned above.
//PROCESS: The click methods change the visibility trait of the buttons and the exit button utilizes the close() method to end the program. 
//OUTPUT: There is no output for this program.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work." Signature: Miles Childress

namespace ChildressMilesPushMe
{
    public partial class FRMPushMe : Form
    {
        public FRMPushMe()
        {
            InitializeComponent();
        }

        private void BTNPushMe1_Click(object sender, EventArgs e)
        {
            //Makes Button 1 disappear and the other buttons visible
            BTNPushMe1.Visible = false;
            BTNPushMe2.Visible = true;
            BTNPushMe3.Visible = true;
            BTNPushMe4.Visible = true;
        }

        private void BTNPushMe2_Click(object sender, EventArgs e)
        {
            //Makes Button 2 disappear and the other buttons visible
            BTNPushMe2.Visible = false;
            BTNPushMe1.Visible = true;
            BTNPushMe3.Visible = true;
            BTNPushMe4.Visible = true;
        }

        private void BTNPushMe3_Click(object sender, EventArgs e)
        {
            //Makes Button 3 disappear and the other buttons visible
            BTNPushMe3.Visible = false;
            BTNPushMe1.Visible = true;
            BTNPushMe2.Visible = true;
            BTNPushMe4.Visible = true;
        }

        private void BTNPushMe4_Click(object sender, EventArgs e)
        {
            //Makes Button 4 disappear and the other buttons visible
            BTNPushMe4.Visible = false;
            BTNPushMe1.Visible = true;
            BTNPushMe2.Visible = true;
            BTNPushMe3.Visible = true;
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //Closes the program when the exit button is pressed
            this.Close();
        }
    }
}

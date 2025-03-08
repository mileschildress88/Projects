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
//FORM: frmTrafficLight
//PURPOSE: This program is designed to take the users input from clicks and the "tab" key to change the color of the buttons on the "traffic light"
//INPUT: The input for this program is from the "tab" key and the user's clicks
//PROCESS: This program changes the buttons BackColor whenever the user inputs the "tab" key or clicks on one of the buttons
//OUTPUT: The output from this program is just the color changing on the buttons of the "traffic light" to their associated color.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work." Signature: Miles Childress



namespace ChildressMilesTrafficLight
{
    public partial class frmTrafficLight : Form
    {
        public frmTrafficLight()
        {
            InitializeComponent();
            //Initially sets the color of TXTGreenLight to green
            TXTGreenLight.BackColor = Color.Green;
            //If the textbox has focus, then the correlating callback to the event is called
            TXTRedLight.GotFocus += TXTRedLight_GotFocus;
            TXTGreenLight.GotFocus += TXTGreenLight_GotFocus;
            TXTYellowLight.GotFocus += TXTYellowLight_GotFocus;
          //  TXTRedLight.Click += TXTRedLight_GotFocus;
           // TXTYellowLight.Click += TXTYellowLight_GotFocus;
           // TXTGreenLight.Click += TXTGreenLight_GotFocus;

            //sets BTNGreenLight color to green initially and the BTNRedLight and BTN YellowLight to Dark Grey
           // BTNGreenLight.BackColor = Color.Green;
           // BTNRedLight.BackColor = Color.DarkGray;
           // BTNYellowLight.BackColor = Color.DarkGray;

            //this was my solution to the changing colors as if the button is in focus then it changes the colors of the buttons accordingly 
          //  if (BTNGreenLight.Focus())
         //   {
           //     BTNGreenLight.BackColor= Color.Green;
          //      BTNRedLight.BackColor = Color.DarkGray;
           //     BTNYellowLight.BackColor = Color.DarkGray;
          //  }
          //  if (BTNYellowLight.Focus())
          //  {
           //     BTNGreenLight.BackColor = Color.DarkGray;
            //    BTNRedLight.BackColor = Color.DarkGray;
             //   BTNYellowLight.BackColor = Color.Yellow;
//          }
          //  if(BTNRedLight.Focus())
          //  {
            //    BTNGreenLight.BackColor = Color.DarkGray;
           //     BTNRedLight.BackColor = Color.Red;
            //    BTNYellowLight.BackColor = Color.DarkGray;
          //  }
      //  }


        //Below is code trying to change the colors with the event of a tab key pressed but I can use the .focus with an if statement to solve this issue *************
       // void BTNRedLight_Enter(object sender, EventArgs e)
      //  {
       //     BTNRedLight.BackColor = Color.Red;
      //      BTNGreenLight.BackColor = Color.DarkGray;
       //     BTNYellowLight.BackColor = Color.DarkGray;
      //  }

      //  void BTNYellowLight_Enter(object sender, EventArgs e)
      //  {
       //     BTNRedLight.BackColor = Color.DarkGray;
        //    BTNGreenLight.BackColor = Color.DarkGray;
        //    BTNYellowLight.BackColor = Color.DarkGray;
      //  }

       // void BTNGreenLight_Enter(object sender, EventArgs e)
       // {
         //   BTNRedLight.BackColor = Color.DarkGray;
         //   BTNGreenLight.BackColor = Color.Green;
          //  BTNYellowLight.BackColor = Color.DarkGray;
        }

      //  private void TXTYellowLight_Click(object sender, EventArgs e)
       // {
       //     throw new NotImplementedException();
      //  }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //closes the program when the exit button is clicked
            Close();
        }

        private void TXTRedLight_GotFocus(object sender, EventArgs e)
        {
            //If the TXTRedLight has focus, then it sets it color to red and the other text boxes to dark gray
            TXTRedLight.BackColor = Color.Red;
            TXTGreenLight.BackColor = Color.DarkGray;
            TXTYellowLight.BackColor = Color.DarkGray;
        }

        private void TXTYellowLight_GotFocus(Object sender, EventArgs e)
        {
            //If the TXTYellowLight has focus, then it sets the color to yellow and the other text boxes to dark gray
            TXTRedLight.BackColor = Color.DarkGray;
            TXTGreenLight.BackColor = Color.DarkGray;
            TXTYellowLight.BackColor = Color.Yellow;
        }

        private void TXTGreenLight_GotFocus(Object sender, EventArgs e)
        {
            //If the TXTGreenLight has focus, then it sets the color to green and the other text boxes to dark gray
            TXTRedLight.BackColor = Color.DarkGray;
            TXTGreenLight.BackColor = Color.Green;
            TXTYellowLight.BackColor = Color.DarkGray;
        }

      //  private void TXTRedLight_Click(object sender, EventArgs e)
      //  {
       //     TXTRedLight_GotFocus();
      //  }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: JOSELYN MUNGUIA MEJIA
 * Date: 10-27-2023
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int UserInput;

            // INPUT
            UserInput = Convert.ToInt32(xInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            xOutputLabel.Text = "The square of " + UserInput + " is " + (UserInput * UserInput).ToString() + ".";
            

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            xOutputLabel.Text += "\nThe cube of " + UserInput + " is " + (UserInput * UserInput * UserInput).ToString() + ".";
            xOutputLabel.Visible = true;

            // OUTPUT
            // set the output to visible
            xOutputLabel.Visible = true;

            // turn the Go button off
            xGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return 0;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return 0;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            xInputTextBox.Text = " ";

            // turn the output to invisible
            xOutputLabel.Visible = false;

            // turn the Go button back on
            xGoButton.Enabled = true;
        }

    }
}

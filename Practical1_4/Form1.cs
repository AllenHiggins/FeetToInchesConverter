using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Allen Higgins 

namespace Practical1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaer a var for storing the value
        static double value = 0.0;
        //method for clearing the textBox field when changing to a diffrent conversion
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void feetToInchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for feet to inches is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Feet to Inches";
            label1.Text = "Feet";
            clear();
        }

        private void inchesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for inches to feet is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Inches to Feet";
            label1.Text = "Inches";
            clear();
        }

        private void poundToEuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for pound to euro is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Pound to Euro";
            label1.Text = "Pound";
            clear();
        }

        private void euroToPoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for euro to pound is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Euro to Pound";
            label1.Text = "Euro";
            clear();
        }

        private void celsiusToFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for cel to far is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Celsius to Fahrenheit";
            label1.Text = "Celsius";
            clear();
        }

        private void fahrenheitToCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu option for far to cel is clicked
            //set heading and label1 to a string related to the menu option that was pressed
            //and reset the textbox's to null for new input entery
            heading.Text = "Fahrenheit to Celsius";
            label1.Text = "Fahrenheit";
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //try to get the num entered and store in var value
                value = double.Parse(textBox1.Text);
                //send the current text value of the label named heading into the switch
                switch(heading.Text)
                {
                    //find the rigth case and return the result into textBox2
                    case "Feet to Inches":
                        textBox2.Text = Math.Round((value * 12), 2).ToString();
                        break;
                    case "Inches to Feet":
                        textBox2.Text = Math.Round((value / 12), 2).ToString();
                        break;
                    case "Pound to Euro":
                        textBox2.Text = Math.Round((value * 1.17), 2).ToString();
                        break;
                    case "Euro to Pound":
                        textBox2.Text = Math.Round((value * 0.89), 2).ToString();
                        break;
                    case "Celsius to Fahrenheit":
                        textBox2.Text = Math.Round((value * 9 / 5) + 32, 2).ToString();
                        break;
                    case "Fahrenheit to Celsius":
                        textBox2.Text = Math.Round((value - 32) * 5 / 9, 2).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                //the value is null
                if(textBox1.Text == "")
                {
                    //prompt the user to enter a number for conversion
                    MessageBox.Show("Please Enter a value to convert", "Notic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //otherwise user did not enter a valied number ie: 1.2.2 or AC12 ....
                    //show error msg
                    MessageBox.Show("Invalied Input","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}

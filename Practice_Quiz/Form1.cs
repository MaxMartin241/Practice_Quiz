using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        string nameInput;
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            nameInput = question2TextBox.Text;
            question2OutputLabel.Text = "hello " + nameInput;
        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy Hump Day";
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt16(q3Int1Text.Text);
            num2 = Convert.ToInt16(q3int2Text.Text);
            question3OutputLabel.Text = num1 + " X " + num2 + " = " + (num1 * num2);
        }
    }
}

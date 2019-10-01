using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);

            double a = 2.0 * Math.PI * radius;
            double c  = Math.PI * radius * radius;

            label1.Text = "a = " + c;
            label2.Text = "c = " + a;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

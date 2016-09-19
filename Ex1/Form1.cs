using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true; //make label1 visible.
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int f = Convert.ToInt32(textBox5.Text);
            int sum = a + b + c + d + f;
            int dozen = sum / 12; //declaring fraction as an int drops the decimal part.
            int remain = sum - (dozen*12);

            label1.Text = string.Format("{0} eggs is {1} dozen with {2} Left-overs", sum, dozen, remain);

        }
    }
}

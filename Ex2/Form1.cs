using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            double t1 = Convert.ToDouble(textBox1.Text);
            double t2 = Convert.ToDouble(textBox2.Text);
            double t3 = Convert.ToDouble(textBox3.Text);
            double t4 = Convert.ToDouble(textBox4.Text);
            double t5 = Convert.ToDouble(textBox5.Text);
            double average = (t1 + t2 + t3 + t4 + t5) / 5;

            label2.Text = string.Format("Average score of {0} tests is {1:f}", 5, average);
        }
    }
}

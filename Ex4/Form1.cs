using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToUpper();
            int sin = Convert.ToInt32(textBox2.Text);
            double rate = Convert.ToDouble(textBox3.Text);
            double hrs = Convert.ToDouble(textBox4.Text);
            double gross = rate * hrs;
            double net = gross - ((gross * 0.15) + (gross * 0.05));


            label2.Text = string.Format("Your information is:\nName:{0}\nSIN#:{1:###-###-###}\nHourly Pay Rate:{2:c}\nGross Salary:{3:c}\nFederal Tax:{4}%\nState Tax:{5}%\nNet Salary:{6:c}", name,sin,rate,gross,15,5,net);

            label2.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
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
            label3.Visible = true;
            label4.Visible = true;

            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            /*to eliminate cap/small letter confusion add >> 
            string name1Cap=name1.ToUpper() etc here, and compare name1Cap etc to eachother*/



            //three ways to compare strings:
            int nameComparison = string.Compare(name1, name2);
            bool nameEquality = string.Equals(name1, name2);
            int nameCompareTo = name1.CompareTo(name2);


            label2.Text = nameComparison.ToString();
            label3.Text = string.Format("Two names are the same?"+nameEquality);
            label4.Text = nameCompareTo.ToString();

            


        }
    }
}

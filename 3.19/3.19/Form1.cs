using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double c;
            if ((x - y) == 0)
                c = Math.Sin(x * x) + Math.Cos(y * y);
            else if ((x - y) < 0)
                c = Math.Tan(x * x + y * y);
            else
                c = Math.Pow(Math.Sin(x * x), 2) + Math.Pow(Math.Cos(y * y), 2);


            textBoxgensh.Text += "Результат работы программы" + " Субцирел Д.В" + Environment.NewLine;
            textBoxgensh.Text += "При Х =" + textBox1.Text + Environment.NewLine;
            textBoxgensh.Text += "При Y =" + textBox2.Text + Environment.NewLine;
            textBoxgensh.Text += "c=" + c.ToString() + Environment.NewLine;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxgensh.Text = ("");
        }
    }
}

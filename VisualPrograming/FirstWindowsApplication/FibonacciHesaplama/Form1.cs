using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adet,x, y, z;
            x = 0;
            y = 1;
            z = 0;
            adet = Convert.ToDouble(textBox1.Text);
            for (int i = 2; i < adet; i++)
            {
                z = x + y;
                label1.Text = label1.Text + (" , " + z.ToString());
                x = y;
                y = z;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Aquamarine;
        }
    }
}

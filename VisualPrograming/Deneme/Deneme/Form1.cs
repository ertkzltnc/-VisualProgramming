using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    
    public partial class Form1 : Form
    {
        int zaman= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
         
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman += 1;
            lblSonuc.Text = "" + zaman;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblSonuc.Text = "" + zaman;
        }

        private void btnSıfır_Click(object sender, EventArgs e)
        {
            zaman = 0;
            lblSonuc.Text = "" + zaman;
        }
    }
}

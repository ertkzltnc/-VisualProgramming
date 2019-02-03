using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DünyaSaatleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            txtİst.Text = "" + zaman.ToShortTimeString();
            txtT.Text = "" + zaman.AddHours(6).ToShortTimeString();
            txtN.Text = "" + zaman.AddHours(-8).ToShortTimeString();
            txtL.Text = "" + zaman.AddHours(-3).ToShortTimeString();

        }
    }
}

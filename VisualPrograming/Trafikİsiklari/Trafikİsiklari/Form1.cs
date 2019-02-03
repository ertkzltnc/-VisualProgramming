using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafikİsiklari
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbKirmizi.Visible = true;
            pcbSari.Visible = false;
            pcbYesil.Visible = false;
            pcbdur.Visible = true;
            pcbgec.Visible = false;
            sayac++;
            if (sayac >= 0 && sayac <= 6)
            {
                pcbKirmizi.Visible = true;
                pcbSari.Visible = false;
                pcbYesil.Visible = false;
                pcbdur.Visible = false;
                pcbgec.Visible = true;

            }
            else if (sayac > 6 && sayac <= 9)
            {
                pcbKirmizi.Visible = false;
                pcbSari.Visible = true;
                pcbYesil.Visible = false;
                pcbdur.Visible = true;
                pcbgec.Visible = false;
            }
            else if (sayac > 9 && sayac <= 15)
            {
                pcbKirmizi.Visible = false;
                pcbSari.Visible = false;
                pcbYesil.Visible = true;
                pcbdur.Visible = true;
                pcbgec.Visible = false;

            }
            else if (sayac > 15 && sayac <= 18)
            {
                pcbKirmizi.Visible = false;
                pcbSari.Visible = true;
                pcbYesil.Visible = false;
                pcbdur.Visible = true;
                pcbgec.Visible = false;

            }
            else sayac = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

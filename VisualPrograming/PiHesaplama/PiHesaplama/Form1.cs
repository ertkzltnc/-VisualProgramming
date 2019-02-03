using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int basamak = Convert.ToInt32(txtGiris.Text);
                double pi=0.0;
                int j = 1;
                for (int i = 0; i < basamak; i++)
                {
                    if (i%2==0)
                    {
                        pi = pi + 4.0 / j;

                    }
                    else
                    {
                        pi = pi - 4.0 / j;
                    }
                    j+=2;

                }
                lblSonuc.Text = "" + pi;

            }
            catch (Exception ex)
            {

                lblSonuc.Text = "" + ex.Message;
            }
        }
    }
}

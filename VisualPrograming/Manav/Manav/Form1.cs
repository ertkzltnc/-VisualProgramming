using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            double hesap = 0;

            try
            {
                if (chArmut.Checked)
                {
                    hesap += Convert.ToDouble(txtArmut.Text) * Convert.ToDouble(lblArmut.Text);

                }
                if (chElma.Checked)
                {
                    hesap += Convert.ToDouble(txtElma.Text) * Convert.ToDouble(lblElma.Text);

                }
                if (chKivi.Checked)
                {
                    hesap += Convert.ToDouble(txtKivi.Text) * Convert.ToDouble(lblKivi.Text);

                }
                if (chPortakal.Checked)
                {
                    hesap += Convert.ToDouble(txtPortakal.Text) * Convert.ToDouble(lblPortakal.Text);

                }
                if (chMuz.Checked)
                {
                    hesap += Convert.ToDouble(txtMuz.Text) * Convert.ToDouble(lblMuz.Text);

                }
                if (chBamya.Checked)
                {
                    hesap += Convert.ToDouble(txtBamya.Text) * Convert.ToDouble(lblBamya.Text);

                }
                if (chBezelye.Checked)
                {
                    hesap += Convert.ToDouble(txtBezelye.Text) * Convert.ToDouble(lblBezelye.Text);

                }
                if (chDomates.Checked)
                {
                    hesap += Convert.ToDouble(txtDomates.Text) * Convert.ToDouble(lblDomates.Text);

                }
                if (chBiber.Checked)
                {
                    hesap += Convert.ToDouble(txtBiber.Text) * Convert.ToDouble(lblBiber.Text);

                }
                if (chFasulye.Checked)
                {
                    hesap += Convert.ToDouble(txtFasulye.Text) * Convert.ToDouble(lblFasulye.Text);

                }
                lblHesap.Text = "Toplam Tutarınız: " + hesap;



            }
            catch (Exception ex)
            {

                lblHesap.Text = "" + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chArmut.Enabled = false;
            chBamya.Enabled = false;
            chBezelye.Enabled = false;
            chBiber.Enabled = false;
            chDomates.Enabled = false;
            chElma.Enabled = false;
            chFasulye.Enabled = false;
            chKivi.Enabled = false;
            chMuz.Enabled = false;
            chPortakal.Enabled = false;

        }

        private void rdbSebze_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSebze.Checked)
            {
                chBamya.Enabled = true;
                chBezelye.Enabled = true;
                chBiber.Enabled = true;
                chDomates.Enabled = true;
                chFasulye.Enabled = true;
            }
            else
            {
                chBamya.Enabled = false;
                chBezelye.Enabled = false;
                chBiber.Enabled = false;
                chDomates.Enabled = false;
                chFasulye.Enabled = false;

            }

        }

        private void rdMeyve_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMeyve.Checked)
            {
                chArmut.Enabled = true;
                chElma.Enabled = true;
                chKivi.Enabled = true;
                chMuz.Enabled = true;
                chPortakal.Enabled = true;
            }
            else
            {
                chArmut.Enabled = false;
                chElma.Enabled = false;
                chKivi.Enabled = false;
                chMuz.Enabled = false;
                chPortakal.Enabled = false;
            }


        }
    }
}

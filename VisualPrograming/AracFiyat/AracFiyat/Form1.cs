using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracFiyat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            double gelis=0, satis=0;
            bool motor;
            try
            {
                gelis = Convert.ToDouble(txtGelis.Text);
                satis += gelis;
                if (rM.Checked)
                {
                    motor = false;
                }
                else motor = true;
                if (chÖ.Checked && motor==true)
                {
                    chÖ.Text = "ÖTV (%45)";
                    satis += gelis * 0.45;
                    txtÖ.Text = "" + gelis * 0.45;
                }
                else if (chÖ.Checked && motor == false)
                {
                    chÖ.Text = "ÖTV (%60)";
                    satis += gelis * 0.60;
                    txtÖ.Text = "" + gelis * 0.60;

                }
                else txtÖ.Text = "0";
                if (chK.Checked)
                {
                    satis += gelis * 0.18;
                    txtK.Text = "" + gelis * 0.18;

                }
                else txtK.Text = "0";
                if (chD.Checked)
                {
                    satis += gelis * 0.001;
                    txD.Text = "" + gelis * 0.001;
                } else txD.Text = "0";
                
                
                txSatis.Text = "" + satis;
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnTemiz_Click(object sender, EventArgs e)
        {
            txtÖ.Text = "";
            txtK.Text = "";
            txD.Text = "";
            
            txtGelis.Text = "";
            txSatis.Text = "";
            chÖ.Checked = false;
            chK.Checked = false;
            chD.Checked = false;
            rdMa.Checked = false;
            rM.Checked = false;
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiYuvarla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = Convert.ToDouble(txtGiris.Text);
                
                if (rdbÜst.Checked)
                {
                    lblSonuc.Text = "" + Math.Ceiling(sayi);

                }
                if (rdbAlt.Checked)
                {
                    lblSonuc.Text = "" + Math.Floor(sayi);

                }
                if (rdbRound.Checked)
                {
                    int r = Convert.ToInt32(txtHassas.Text);
                    lblSonuc.Text = "" + Math.Round(sayi, r);

                }
            }
            catch (Exception ex)
            {

                lblSonuc.Text = "" + ex.Message;
            }
        }
    }
}

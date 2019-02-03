using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasariTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dogru = 0, oran = 0;
        
        

        private void btnSonuç_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (rd1.Checked) { dogru++; }
                if (rd2.Checked) { dogru++; }
                if (rd3.Checked) { dogru++; }
                if (rd4.Checked) { dogru++; }
                if (rd5.Checked) { dogru++; }
                if (rd6.Checked) { dogru++; }
                txtD.Text = "" + dogru;
                txtY.Text = "" + (6 - dogru);
                oran = Convert.ToDouble((dogru / 6) * 100);
                txtO.Text = "" + oran;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
          



        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        
    }
}

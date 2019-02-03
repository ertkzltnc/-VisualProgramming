using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            grbCinsiyet.Enabled = true;
            grbMedeniDurum.Enabled = true;
            grbYas.Enabled = true;
            btnBitir.Enabled = false;
            btnTemizle.Enabled = false;
           
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            try
            {
                btnBitir.Enabled = true;
                btnTemizle.Enabled = false;
                if (rdbEvli.Checked)
                {
                    grbSoru1.Enabled = true;
                    grbSoru2.Enabled = true;
                    grbSoru3.Enabled = true;
                }
                if (rdbBekar.Checked)
                {
                    grbSoru3.Enabled = true;
                    grbSoru1.Enabled = false;
                    grbSoru2.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                txtSonuc.Text = "" + ex.Message;
            }
            
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            btnTemizle.Enabled = true;
            int durum = 0;
            try
            {
                btnTemizle.Enabled = true;
                btnBasla.Enabled = false;
                grbSoru1.Enabled = false;
                grbSoru2.Enabled = false;
                grbSoru3.Enabled = false;
                grbCinsiyet.Enabled = false;
                grbMedeniDurum.Enabled = false;
                grbYas.Enabled = false;

                if (rdbBeslenme1.Checked) durum++;
                if (rdbBeslenme2.Checked) durum+=2;
                if (rdbBeslenme3.Checked) durum+=3;
                if (rdbBeslenme4.Checked) durum+=4;
                if (rdbBeslenme5.Checked) durum+=5;
                if (rdbEbeveyn1.Checked) durum++;
                if (rdbEbeveyn2.Checked) durum+=2;
                if (rdbEbeveyn3.Checked) durum+=3;
                if (rdbEbeveyn4.Checked) durum+=4;
                if (rdbEbeveyn5.Checked) durum+=5;
                if (rdbİletisim1.Checked) durum++;
                if (rdbİletisim2.Checked) durum+=2;
                if (rdbİletisim3.Checked) durum+=3;
                if (rdbİletisim4.Checked) durum+=4;
                if (rdbİletisim5.Checked) durum+=5;
                if (rdbBekar.Checked)
                {
                    if (durum >= 3) txtSonuc.Text = "Siz ve Ailenize Mutluluklar";
                    else txtSonuc.Text = "Lütfen Evlenmeyiniz!!";
                 
                }
                if (rdbEvli.Checked)
                {
                    if (durum <= 9) txtSonuc.Text = "Lütfen cocuklarınız ile daha çok vakit geçirin!!";
                    else txtSonuc.Text = "Mutluluğunuz Daim Olsun :)";
                }
               

            }
            catch (Exception ex)
            {

                txtSonuc.Text = "" + ex.Message;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            grbCinsiyet.Enabled = true;
            grbMedeniDurum.Enabled = true;
            grbYas.Enabled = true;
            btnBasla.Enabled = true;
            btnBitir.Enabled = false;
            txtSonuc.Text = "";
            rdbBekar.Checked = false;
            rdbEvli.Checked = false;
            rdbOrtaYasli.Checked = false;
            rdbYasli.Checked = false;
            rdbGenc.Checked = false;
            rdbKadın.Checked = false;
            rdbErkek.Checked = false;
            rdbBeslenme1.Checked = false;
            rdbBeslenme2.Checked = false;
            rdbBeslenme3.Checked = false;
            rdbBeslenme4.Checked = false;
            rdbBeslenme5.Checked = false;
            rdbİletisim1.Checked = false;
            rdbİletisim2.Checked = false;
            rdbİletisim3.Checked = false;
            rdbİletisim4.Checked = false;
            rdbİletisim5.Checked = false;
            rdbEbeveyn1.Checked = false;
            rdbEbeveyn2.Checked = false;
            rdbEbeveyn3.Checked = false;
            rdbEbeveyn4.Checked = false;
            rdbEbeveyn5.Checked = false;

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Katılımınız İçin Teşekkür Ederiz");
            this.Close();
            Application.Exit();
        }
    }
}

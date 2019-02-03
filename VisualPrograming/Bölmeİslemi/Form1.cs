using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// tammalanacak 

namespace Bölmeİslemi
{
    public partial class Bölmeİslemi : Form
    {
        public Bölmeİslemi()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            string ad, soyAd, email;
            string numara;
            int  sayacAd = 0, sayacSoyAd = 0;
            double telNo;
            try
            {
                ad = txtAd.Text;
                soyAd = txtSoyAd.Text;
                email = txtEmail.Text;
                numara = txtTelefon.Text;
               
                char[] karakterAd = ad.ToCharArray();
                char[] karakterSoyAd = soyAd.ToCharArray();
                for (int j = 0; j < ad.Length; j++)
                {
                    if (Char.IsSymbol(karakterAd[j]) || Char.IsNumber(karakterAd[j]))
                    {
                        sayacAd++;

                    }
                                                                                                         }
                if (sayacAd!=0)MessageBox.Show("isim hatali giris"); sayacAd=0;
                for (int k= 0; k < ad.Length; k++)
                {
                    if (Char.IsSymbol(karakterSoyAd[k]) || Char.IsNumber(karakterSoyAd[k]))
                    {
                        sayacSoyAd++;

                    }
                }
                if (sayacSoyAd != 0) MessageBox.Show("Soy isim hatali giris"); sayacSoyAd= 0;
                int i = email.IndexOf("@");
                if (i == -1) MessageBox.Show("Mail Adresi Hatalı!");
                if (numara.Length != 10) MessageBox.Show("Telefon Numarası Hatalı!");
                telNo = Convert.ToDouble(numara);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
                    
                       

        }
    }
}

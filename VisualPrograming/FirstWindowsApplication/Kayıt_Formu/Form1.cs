using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayıt_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            int dogumyili = dateTimePicker1.Value.Year;
            int simdikiyil = DateTime.Today.Year;
            int yas = simdikiyil - dogumyili;



            Regex r = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");

            Regex r2 = new Regex("^[a-zA-Z]*$");


                string pattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
                Regex r3 = new Regex(pattern);


            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "")
            {
                lblYas.Text = ("Lütfen Boş olan kısımları doldurunuz.");
                lblAd.Text = "";
                lblSoyAd.Text = "";
                lblEmail.Text = "";
                lblTel.Text = "";
            }
            else if (!r.IsMatch(txtTelefon.Text))
            {
                lblTel.Text = " Lütfen telefon formatını düzgün giriniz. ";
                lblAd.Text = "";
                lblSoyAd.Text = "";
                lblEmail.Text = "";
                lblYas.Text = "";
            }
            else if (!r2.IsMatch(txtAd.Text))
            {
                lblAd.Text = "Lütfen ad veya soyad bilgisini doğru giriniz.";
                lblYas.Text = "";
                lblEmail.Text = "";
                lblTel.Text = "";
                lblSoyAd.Text = "";
            }

            else if (!r3.IsMatch(txtEmail.Text))
            {
                lblEmail.Text = "Lütfen mail adresini doğru giriniz.";
                lblTel.Text = "";
                lblSoyAd.Text = "";
                lblAd.Text = "";
                lblYas.Text = "";

            }
            else if (yas >= 18)
            {
                lblSoyAd.Text = ("Kayıt Başarılı.... :)");
                lblAd.Text = "";
                lblYas.Text = "";
                lblEmail.Text = "";
                lblTel.Text = "";
            }
            else
            {
                lblYas.Text = "18 Yasindan Küçük OLamaz";
                lblEmail.Text = "";
                lblTel.Text = "";
                lblSoyAd.Text = "";
                lblAd.Text = "";
            }


             
              


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}

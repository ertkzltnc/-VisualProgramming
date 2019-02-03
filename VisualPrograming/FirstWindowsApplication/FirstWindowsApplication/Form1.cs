using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApplication
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2,sonuc;

                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sonuc =  sayi1 / sayi2;
                MessageBox.Show("Sonucumuz :"+ sonuc.ToString());

            }
            catch (DivideByZeroException nesne)
            {

                MessageBox.Show("Sorun oluştu : "  + nesne.Message);
              
            }
            catch (FormatException nesne2)
            {

                MessageBox.Show("Lütfen doğru formatta girin : " + nesne2.Message);
            }
            
        }
    }
}

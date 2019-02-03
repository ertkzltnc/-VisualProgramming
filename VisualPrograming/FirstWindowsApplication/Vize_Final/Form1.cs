using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double vizeOran, finalOran, projeOran, quizOran;
                double vizePuan, finalPuan, projePuan, quizPuan;

                vizeOran = Convert.ToDouble(txtVizeOran.Text);
                finalOran = Convert.ToDouble(txtFinalOran.Text);
                projeOran = Convert.ToDouble(txtProjeOran.Text);
                quizOran = Convert.ToDouble(txtQuizOran.Text);


                vizePuan = Convert.ToDouble(txtVizePuan.Text);
                finalPuan = Convert.ToDouble(txtFinalPuan.Text);
                projePuan = Convert.ToDouble(txtProjePuan.Text);
                quizPuan = Convert.ToDouble(txtQuizPuan.Text);

                double sonuc;

                sonuc = (vizePuan * vizeOran / 100) + (finalPuan * finalOran / 100) +
                   (projePuan * projeOran / 100) + (quizPuan * quizOran / 100);
             

                if (vizeOran + finalOran + projeOran + quizOran != 100 || vizePuan > 100 || finalPuan > 100 || projePuan > 100 || quizPuan > 100)
                {
                    MessageBox.Show("Lütfen Oranları Doğru Giriniz");
                }
                else if (finalPuan < 50)
                {
                    MessageBox.Show("Final Notu 50'den küçük olamaz.");

                }

                else
                {
                    if (sonuc < 50)
                    {
                        MessageBox.Show("Ortalama 50'den küçük, Kaldınız...");
                    }
                    else
                    {
                        MessageBox.Show("Sonucumuz :" + sonuc);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Boş veya geçersiz değer girildi");  
            }
         

    

        }
    }
}

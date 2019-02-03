using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulPuanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vizeOran, vizeNot, finalOran, finalNot, projeOran, projeNot, quizOran, quizNot;
            double oranToplam, Sonuc;
            
            try
            {
                vizeOran = Convert.ToDouble(txtVizeOran.Text);
                finalOran = Convert.ToDouble(txtFinalOran.Text);
                quizOran = Convert.ToDouble(txtQuizOran.Text);
                projeOran = Convert.ToDouble(txtProjeOran.Text);
                vizeNot = Convert.ToDouble(txtVizeNot.Text);
                finalNot = Convert.ToDouble(txtFinalNot.Text);
                projeNot = Convert.ToDouble(txtProjeNot.Text);
                quizNot = Convert.ToDouble(txtQuizNot.Text);
                Sonuc = (vizeNot * vizeOran / 100) + (finalNot * finalOran / 100) + (projeNot *projeOran / 100) + (quizNot * quizOran / 100);
                oranToplam = vizeOran + finalOran + projeOran + quizOran;
                if (oranToplam != 100)
                {
                    lblHarfNotu.Text="Oranlar Hatalı Tekrar Giris Yapınız.";
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox tbox = (TextBox)item;
                            tbox.Clear();


                        }
                    }

                }
                else
                {
                    if (finalNot < 50)
                    {
                        lblHarfNotu.Text = "Harf Notunuz: FF";
                    }
                    else
                    {

                        if (Sonuc >= 95)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: AA";
                        }
                        else if (Sonuc >= 90)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: BA";
                        }
                        else if (Sonuc >= 80)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: BB";
                        }
                        else if (Sonuc >= 70)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: CB";
                        }
                        else if (Sonuc >= 65)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: CC";
                        }
                        else if (Sonuc >=55)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: DC";
                        }
                        else if (Sonuc>=50)
                        {
                            lblHarfNotu.Text = "Harf Notunuz: DD";
                        }
                        else
                        {
                            lblHarfNotu.Text = "Harf Notunuz: FF";
                        }




                    }

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

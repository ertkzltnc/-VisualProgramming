using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Kimlik_No_Doğrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {

            string tcNo;
            tcNo = textBox1.Text;
            int toplam = 0; int toplam2 = 0; int toplam3 = 0;
            if (tcNo.Length == 11)
            {
                if (Convert.ToInt32(tcNo[0].ToString()) != 0) //tc kimlik numaranın ilk hanesi 0 değilse
                {
                    for (int i = 0; i < 10; i++)
                    {
                        toplam = toplam + Convert.ToInt32(tcNo[i].ToString());
                        if (i % 2 == 0)
                        {
                            if (i != 10)
                            {
                                toplam2 = toplam2 + Convert.ToInt32(tcNo[i].ToString()); // 7 ile çarpılacak sayıları topluyoruz
                            }

                        }
                        else
                        {
                            if (i != 9)
                            {
                                toplam3 = toplam3 + Convert.ToInt32(tcNo[i].ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tc Kimlik Numaranızın ilk hanesi 0 olamaz.");
                }
            }
            else
            {
                MessageBox.Show("Tc Kimlik Numarınız 11 haneli olmak zorunda.Eksik ya da fazla değer girdiniz.");
            }
            if (((toplam2 * 7) - toplam3) % 10 == Convert.ToInt32(tcNo[9].ToString()) && toplam % 10 == Convert.ToInt32(tcNo[10].ToString()))
            {
                MessageBox.Show("Tc Kimlik Numarası Doğru.");
            }
            else
            {
                MessageBox.Show("Tc Kimlik Numarası Yanlış!");
            }

   

        }

        private void yeniTcUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int yeniTC, toplam = 0, toplam2 = 0, toplam3 = 0, geciciDegisken;
            string[] a = new string[11];
            for (int i = 1; i <=7; i = i + 2)
            {
                geciciDegisken = rnd.Next(0, 9);
                a[i] = Convert.ToString(geciciDegisken);
                toplam += geciciDegisken;

            }
            for (int k = 2; k <=8; k=k+2)
            {
                geciciDegisken = rnd.Next(0, 9);
                a[k] = Convert.ToString(geciciDegisken);
                toplam2 += geciciDegisken;

            }

            geciciDegisken = rnd.Next(1, 9);
            toplam2 += geciciDegisken;
            a[0] = Convert.ToString(geciciDegisken);
            a[9] = Convert.ToString((toplam2 * 7 - toplam) % 10);
            geciciDegisken = Convert.ToInt32(a[9]);
            a[10] = Convert.ToString((toplam + geciciDegisken + toplam2) % 10);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSerisi
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
                
                int boyut = Convert.ToInt32(txtGiris.Text); 
                long[] fibonacciDizisi = new long[boyut];
                string gösterme = "";
                fibonacciDizisi[0]= 0;
                fibonacciDizisi[1] = 1;
                for (int i = 2; i < boyut; i++)
                {
                    fibonacciDizisi[i] = fibonacciDizisi[i - 1] + fibonacciDizisi[i - 2];

                }
                foreach (var item in fibonacciDizisi)
                {
                    gösterme =gösterme+" "+ Convert.ToString(item);

                }
                lblSonuc.Text = "" + gösterme;
                lblSonSayi.Text = "" + fibonacciDizisi[boyut - 1];
                


            }
            catch (Exception ex)
            {

                lblSonuc.Text = "" + ex.Message;
            }
        }
    }
}

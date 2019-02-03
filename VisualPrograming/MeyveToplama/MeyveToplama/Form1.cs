using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeyveToplama
{
    public partial class Form1 : Form
    {
        int sepet = 0; // agac elma sayısı
        //int sayac = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pcB1.Location = new Point(rnd.Next(150, 400), rnd.Next(100, 300));
            pcB5.Location = new Point(rnd.Next(150, 400), rnd.Next(100, 300));
            pcB4.Location = new Point(rnd.Next(150, 400), rnd.Next(100, 300));
            pcB3.Location = new Point(rnd.Next(150, 400), rnd.Next(100, 300));
            pcB2.Location = new Point(rnd.Next(150, 400), rnd.Next(100, 300));

        }
        
        private void pcBAgac_MouseClick(object sender, MouseEventArgs e)
        { /* Agaca Tıklanma Durumu İcin 
            switch (sayac)
            {
                case 1:
                    pcB1.Visible = false;
                    sayac--;
                    sepet++;
                    lblSepet.Text = "" + sayac;
                    break;
                case 2:
                    pcB2.Visible = false;
                    sayac--;
                    sepet++;
                    lblSepet.Text = "" + sayac;
                    break;
                case 3:
                    pcB3.Visible = false;
                    sayac--;
                    sepet++;
                    lblSepet.Text = "" + sayac;
                    break;
                case 4:
                    pcB4.Visible = false;
                    sayac--;
                    sepet++;
                    lblSepet.Text = "" + sayac;
                    break;
                case 5:
                    pcB5.Visible = false;
                    sayac--;
                    sepet++;
                    lblSepet.Text = "" + sayac;
                    break;
                default:
                    lblSepet.Text = "Elma Bitti";
                    break;
                    */
            }

        private void pcB1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sepet<=5)
            {
                sepet++;
                pcB1.Visible = false;
                lblSepet.Text = "" + sepet;
            }
            else lblSepet.Text="Sepet Dolu:" + sepet;

        }

        private void pcB3_MouseClick(object sender, MouseEventArgs e)
        {
            if (sepet <= 5)
            {
                sepet++;
                pcB3.Visible = false;
                lblSepet.Text = "" + sepet;
            }
            else lblSepet.Text = "Sepet Dolu:" + sepet;
        }

        private void pcB2_MouseClick(object sender, MouseEventArgs e)
        {
            if (sepet <= 5)
            {
                sepet++;
                pcB2.Visible = false;
                lblSepet.Text = "" + sepet;
            }
            else lblSepet.Text = "Sepet Dolu:" + sepet;

        }

        private void pcB4_MouseClick(object sender, MouseEventArgs e)
        {
            if (sepet <= 5)
            {
                sepet++;
                pcB4.Visible = false;
                lblSepet.Text = "" + sepet;
            }
            else lblSepet.Text = "Sepet Dolu:" + sepet;
        }

        private void pcB5_MouseClick(object sender, MouseEventArgs e)
        {
            if (sepet <= 5)
            {
                sepet++;
                pcB5.Visible = false;
                lblSepet.Text = "" + sepet;
            }
            else lblSepet.Text = "Sepet Dolu:" + sepet;

        }
    }
    
}

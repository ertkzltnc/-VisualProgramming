using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞehirIlceMahalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad;
        //string ill;
        //string ilce;
        //string mahalle;
        string [] il = { "Istanbul" , "Canakkale"};
        string[] ilceIst = { "Besiktas","Kadiköy","Sisli" };
        string[] ilceCanak = { "Merkez","Gelibolu","Biga"};
        string[] mahallebesik = { "Visnezade", "Sinanpasa" };
        string[] mahallekadiköy = { "caferaga","moda" };
        string[] mahallesisli = {"Cevahir" };
        string[] mahallemerkez = { "Çarşı" };
        string[] mahallegelibolu = {"Yazicizade","Camikebir" };
        string[] mahallebiga = { "bigamerkez", "Bigacarsi" };
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehir.Items.AddRange(il);
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            cmbMahalle.Items.Clear();
            cmbIlce.Text = "";
            cmbMahalle.Text = "";

            if (cmbSehir.SelectedItem == "Istanbul")
            {
                
                cmbIlce.Items.AddRange(ilceIst);
                
            }

            if (cmbSehir.SelectedItem == "Canakkale")
            {
                ;
                cmbIlce.Items.AddRange(ilceCanak);
            }

            //ill = cmbSehir.SelectedText;
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMahalle.Items.Clear();
            cmbMahalle.Text = "";
            if (cmbIlce.SelectedItem == "Besiktas")
            {

                cmbMahalle.Items.AddRange(mahallebesik);
            }
            if (cmbIlce.SelectedItem == "Kadiköy")
            {
                cmbMahalle.Items.AddRange(mahallekadiköy);
            }

            if (cmbIlce.SelectedItem == "Sisli")
            {
                cmbMahalle.Items.AddRange(mahallesisli);
            }
            if (cmbIlce.SelectedItem == "Merkez")
            {
                cmbMahalle.Items.AddRange(mahallemerkez);
            }
            if (cmbIlce.SelectedItem == "Gelibolu")
            {
                cmbMahalle.Items.AddRange(mahallegelibolu);
            }
            if (cmbIlce.SelectedItem == "Biga")
            {
                cmbMahalle.Items.AddRange(mahallebiga);
            }

        }

        private void cmbMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonaccci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] seri = { 0, 1 };
            int boyut = 0;
            boyut = Convert.ToInt32(txtGirdi.Text);
            for (int i = 2; i < boyut; i++)
            {
                seri[i] = seri[i - 1] + seri[i - 2];
            }
            string geciciDegisken = "";
            foreach (var item in seri)
            {
                geciciDegisken += Convert.ToString(item);

            }
            lblSonuc.Text = geciciDegisken;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiprasma
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Form1.ActiveForm.Location.X;
            int y = Form1.ActiveForm.Location.Y;
            sayac++;
            if (sayac >= 0 && sayac <= 3)
            {
                Form1.ActiveForm.Location = new Point(x + 5, y);
            }
            else if (sayac >= 4 && sayac <= 6)
            {
                Form1.ActiveForm.Location = new Point(x - 5, y);


            }
            
            else sayac = 0;


           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavsanYakalama
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Location = new Point(rnd.Next(10, 650), rnd.Next(10, 450));
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
            pictureBox1.Location = new Point(rnd.Next(10, 650), rnd.Next(10, 450));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

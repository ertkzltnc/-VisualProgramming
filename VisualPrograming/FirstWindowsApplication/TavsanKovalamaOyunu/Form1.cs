﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavsanKovalamaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random();

            pictureBox1.Location = new Point(rnd.Next(1,Form1.ActiveForm.Size.Height - pictureBox1.Size.Height), 
                rnd.Next(1,Form1.ActiveForm.Size.Width-pictureBox1.Size.Width));
        }
    }
}

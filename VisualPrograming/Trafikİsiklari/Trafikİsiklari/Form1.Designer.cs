namespace Trafikİsiklari
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbdur = new System.Windows.Forms.PictureBox();
            this.pcbgec = new System.Windows.Forms.PictureBox();
            this.pcbYesil = new System.Windows.Forms.PictureBox();
            this.pcbSari = new System.Windows.Forms.PictureBox();
            this.pcbKirmizi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbdur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbdur
            // 
            this.pcbdur.Image = global::Trafikİsiklari.Properties.Resources.dur;
            this.pcbdur.Location = new System.Drawing.Point(443, 85);
            this.pcbdur.Name = "pcbdur";
            this.pcbdur.Size = new System.Drawing.Size(100, 31);
            this.pcbdur.TabIndex = 4;
            this.pcbdur.TabStop = false;
            // 
            // pcbgec
            // 
            this.pcbgec.Image = global::Trafikİsiklari.Properties.Resources.gec;
            this.pcbgec.Location = new System.Drawing.Point(443, 85);
            this.pcbgec.Name = "pcbgec";
            this.pcbgec.Size = new System.Drawing.Size(100, 31);
            this.pcbgec.TabIndex = 3;
            this.pcbgec.TabStop = false;
            // 
            // pcbYesil
            // 
            this.pcbYesil.Image = global::Trafikİsiklari.Properties.Resources.yesil;
            this.pcbYesil.Location = new System.Drawing.Point(428, 96);
            this.pcbYesil.Name = "pcbYesil";
            this.pcbYesil.Size = new System.Drawing.Size(127, 129);
            this.pcbYesil.TabIndex = 2;
            this.pcbYesil.TabStop = false;
            // 
            // pcbSari
            // 
            this.pcbSari.Image = global::Trafikİsiklari.Properties.Resources.sari;
            this.pcbSari.Location = new System.Drawing.Point(443, 96);
            this.pcbSari.Name = "pcbSari";
            this.pcbSari.Size = new System.Drawing.Size(127, 129);
            this.pcbSari.TabIndex = 1;
            this.pcbSari.TabStop = false;
            // 
            // pcbKirmizi
            // 
            this.pcbKirmizi.Image = global::Trafikİsiklari.Properties.Resources.kirmizi;
            this.pcbKirmizi.Location = new System.Drawing.Point(428, 96);
            this.pcbKirmizi.Name = "pcbKirmizi";
            this.pcbKirmizi.Size = new System.Drawing.Size(127, 129);
            this.pcbKirmizi.TabIndex = 0;
            this.pcbKirmizi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 249);
            this.Controls.Add(this.pcbdur);
            this.Controls.Add(this.pcbgec);
            this.Controls.Add(this.pcbYesil);
            this.Controls.Add(this.pcbSari);
            this.Controls.Add(this.pcbKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbdur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKirmizi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbKirmizi;
        private System.Windows.Forms.PictureBox pcbSari;
        private System.Windows.Forms.PictureBox pcbYesil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbgec;
        private System.Windows.Forms.PictureBox pcbdur;
    }
}


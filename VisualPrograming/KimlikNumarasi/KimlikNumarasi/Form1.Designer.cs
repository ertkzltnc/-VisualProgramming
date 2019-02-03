namespace KimlikNumarasi
{
    partial class KimlikNumarasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KimlikNumarasi));
            this.label1 = new System.Windows.Forms.Label();
            this.txxKimlikGiris = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnÜret = new System.Windows.Forms.Button();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimlik Numarası: ";
            // 
            // txxKimlikGiris
            // 
            this.txxKimlikGiris.Location = new System.Drawing.Point(248, 52);
            this.txxKimlikGiris.Name = "txxKimlikGiris";
            this.txxKimlikGiris.Size = new System.Drawing.Size(100, 20);
            this.txxKimlikGiris.TabIndex = 1;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(248, 102);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnÜret
            // 
            this.btnÜret.Location = new System.Drawing.Point(248, 148);
            this.btnÜret.Name = "btnÜret";
            this.btnÜret.Size = new System.Drawing.Size(75, 23);
            this.btnÜret.TabIndex = 3;
            this.btnÜret.Text = "Yeni TC Üret";
            this.btnÜret.UseVisualStyleBackColor = true;
            this.btnÜret.Click += new System.EventHandler(this.btnÜret_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(456, 102);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(0, 13);
            this.lblKontrol.TabIndex = 4;
            // 
            // KimlikNumarasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.btnÜret);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.txxKimlikGiris);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KimlikNumarasi";
            this.Text = "KimlikNumarasi";
            this.Load += new System.EventHandler(this.KimlikNumarasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txxKimlikGiris;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Button btnÜret;
        private System.Windows.Forms.Label lblKontrol;
    }
}


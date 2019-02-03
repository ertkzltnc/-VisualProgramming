namespace AracFiyat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGelis = new System.Windows.Forms.TextBox();
            this.chÖ = new System.Windows.Forms.CheckBox();
            this.chK = new System.Windows.Forms.CheckBox();
            this.chD = new System.Windows.Forms.CheckBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.rM = new System.Windows.Forms.RadioButton();
            this.txtÖ = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txD = new System.Windows.Forms.TextBox();
            this.txSatis = new System.Windows.Forms.TextBox();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.btnTemiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Fiyatı Hesaplama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geliş Fiyati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÖTV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Damga Vergisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Araç Fiyati";
            // 
            // txtGelis
            // 
            this.txtGelis.Location = new System.Drawing.Point(308, 56);
            this.txtGelis.Name = "txtGelis";
            this.txtGelis.Size = new System.Drawing.Size(100, 20);
            this.txtGelis.TabIndex = 6;
            // 
            // chÖ
            // 
            this.chÖ.AutoSize = true;
            this.chÖ.Location = new System.Drawing.Point(308, 100);
            this.chÖ.Name = "chÖ";
            this.chÖ.Size = new System.Drawing.Size(74, 17);
            this.chÖ.TabIndex = 7;
            this.chÖ.Text = "ÖTV(%45)";
            this.chÖ.UseVisualStyleBackColor = true;
            // 
            // chK
            // 
            this.chK.AutoSize = true;
            this.chK.Location = new System.Drawing.Point(308, 124);
            this.chK.Name = "chK";
            this.chK.Size = new System.Drawing.Size(74, 17);
            this.chK.TabIndex = 8;
            this.chK.Text = "KDV(%18)";
            this.chK.UseVisualStyleBackColor = true;
            // 
            // chD
            // 
            this.chD.AutoSize = true;
            this.chD.Location = new System.Drawing.Point(308, 148);
            this.chD.Name = "chD";
            this.chD.Size = new System.Drawing.Size(135, 17);
            this.chD.TabIndex = 9;
            this.chD.Text = "Damga Vergisi(binde 1)";
            this.chD.UseVisualStyleBackColor = true;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(308, 201);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 10;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // rM
            // 
            this.rM.AutoSize = true;
            this.rM.Location = new System.Drawing.Point(308, 171);
            this.rM.Name = "rM";
            this.rM.Size = new System.Drawing.Size(121, 17);
            this.rM.TabIndex = 11;
            this.rM.TabStop = true;
            this.rM.Text = "Motor Hacim(>1600)";
            this.rM.UseVisualStyleBackColor = true;
            // 
            // txtÖ
            // 
            this.txtÖ.Location = new System.Drawing.Point(308, 243);
            this.txtÖ.Name = "txtÖ";
            this.txtÖ.Size = new System.Drawing.Size(100, 20);
            this.txtÖ.TabIndex = 14;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(308, 272);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 15;
            // 
            // txD
            // 
            this.txD.Location = new System.Drawing.Point(308, 299);
            this.txD.Name = "txD";
            this.txD.Size = new System.Drawing.Size(100, 20);
            this.txD.TabIndex = 16;
            // 
            // txSatis
            // 
            this.txSatis.Location = new System.Drawing.Point(308, 356);
            this.txSatis.Name = "txSatis";
            this.txSatis.Size = new System.Drawing.Size(100, 20);
            this.txSatis.TabIndex = 18;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(461, 171);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(124, 17);
            this.rdMa.TabIndex = 19;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Motor Hacim (<1600)";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // btnTemiz
            // 
            this.btnTemiz.Location = new System.Drawing.Point(397, 201);
            this.btnTemiz.Name = "btnTemiz";
            this.btnTemiz.Size = new System.Drawing.Size(75, 23);
            this.btnTemiz.TabIndex = 20;
            this.btnTemiz.Text = "Temizle";
            this.btnTemiz.UseVisualStyleBackColor = true;
            this.btnTemiz.Click += new System.EventHandler(this.btnTemiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 507);
            this.Controls.Add(this.btnTemiz);
            this.Controls.Add(this.rdMa);
            this.Controls.Add(this.txSatis);
            this.Controls.Add(this.txD);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtÖ);
            this.Controls.Add(this.rM);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.chD);
            this.Controls.Add(this.chK);
            this.Controls.Add(this.chÖ);
            this.Controls.Add(this.txtGelis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGelis;
        private System.Windows.Forms.CheckBox chÖ;
        private System.Windows.Forms.CheckBox chK;
        private System.Windows.Forms.CheckBox chD;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.RadioButton rM;
        private System.Windows.Forms.TextBox txtÖ;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txD;
        private System.Windows.Forms.TextBox txSatis;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.Button btnTemiz;
    }
}


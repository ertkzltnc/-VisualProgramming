namespace SayiYuvarla
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
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtHassas = new System.Windows.Forms.TextBox();
            this.rdbÜst = new System.Windows.Forms.RadioButton();
            this.rdbAlt = new System.Windows.Forms.RadioButton();
            this.rdbRound = new System.Windows.Forms.RadioButton();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(78, 49);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 20);
            this.txtGiris.TabIndex = 0;
            // 
            // txtHassas
            // 
            this.txtHassas.Location = new System.Drawing.Point(228, 48);
            this.txtHassas.Name = "txtHassas";
            this.txtHassas.Size = new System.Drawing.Size(100, 20);
            this.txtHassas.TabIndex = 1;
            // 
            // rdbÜst
            // 
            this.rdbÜst.AutoSize = true;
            this.rdbÜst.Location = new System.Drawing.Point(78, 113);
            this.rdbÜst.Name = "rdbÜst";
            this.rdbÜst.Size = new System.Drawing.Size(103, 17);
            this.rdbÜst.TabIndex = 2;
            this.rdbÜst.TabStop = true;
            this.rdbÜst.Text = "Üst Sayi Yuvarla";
            this.rdbÜst.UseVisualStyleBackColor = true;
            // 
            // rdbAlt
            // 
            this.rdbAlt.AutoSize = true;
            this.rdbAlt.Location = new System.Drawing.Point(204, 113);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(99, 17);
            this.rdbAlt.TabIndex = 3;
            this.rdbAlt.TabStop = true;
            this.rdbAlt.Text = "Alt Sayi Yuvarla";
            this.rdbAlt.UseVisualStyleBackColor = true;
            // 
            // rdbRound
            // 
            this.rdbRound.AutoSize = true;
            this.rdbRound.Location = new System.Drawing.Point(330, 113);
            this.rdbRound.Name = "rdbRound";
            this.rdbRound.Size = new System.Drawing.Size(57, 17);
            this.rdbRound.TabIndex = 4;
            this.rdbRound.TabStop = true;
            this.rdbRound.Text = "Round";
            this.rdbRound.UseVisualStyleBackColor = true;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(78, 181);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 5;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(78, 260);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.rdbRound);
            this.Controls.Add(this.rdbAlt);
            this.Controls.Add(this.rdbÜst);
            this.Controls.Add(this.txtHassas);
            this.Controls.Add(this.txtGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtHassas;
        private System.Windows.Forms.RadioButton rdbÜst;
        private System.Windows.Forms.RadioButton rdbAlt;
        private System.Windows.Forms.RadioButton rdbRound;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label lblSonuc;
    }
}


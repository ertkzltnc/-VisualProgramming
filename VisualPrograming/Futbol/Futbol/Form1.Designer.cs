namespace Futbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbTop = new System.Windows.Forms.PictureBox();
            this.lblGol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbTop
            // 
            this.pcbTop.Image = global::Futbol.Properties.Resources.indir;
            this.pcbTop.Location = new System.Drawing.Point(524, 47);
            this.pcbTop.Name = "pcbTop";
            this.pcbTop.Size = new System.Drawing.Size(52, 45);
            this.pcbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTop.TabIndex = 0;
            this.pcbTop.TabStop = false;
            // 
            // lblGol
            // 
            this.lblGol.AutoSize = true;
            this.lblGol.Location = new System.Drawing.Point(354, 182);
            this.lblGol.Name = "lblGol";
            this.lblGol.Size = new System.Drawing.Size(0, 13);
            this.lblGol.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Futbol.Properties.Resources.saha1_l;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblGol);
            this.Controls.Add(this.pcbTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HALI SAHA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTop;
        private System.Windows.Forms.Label lblGol;
    }
}


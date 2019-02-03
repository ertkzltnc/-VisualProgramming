namespace BalıkAvı
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
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcBTimsah = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBTimsah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb1
            // 
            this.pcb1.Image = global::BalıkAvı.Properties.Resources.icons8_fish_food_50;
            this.pcb1.Location = new System.Drawing.Point(384, 91);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(49, 45);
            this.pcb1.TabIndex = 1;
            this.pcb1.TabStop = false;
            // 
            // pcBTimsah
            // 
            this.pcBTimsah.Image = global::BalıkAvı.Properties.Resources.icons8_alligator_24;
            this.pcBTimsah.Location = new System.Drawing.Point(175, 110);
            this.pcBTimsah.Name = "pcBTimsah";
            this.pcBTimsah.Size = new System.Drawing.Size(28, 26);
            this.pcBTimsah.TabIndex = 0;
            this.pcBTimsah.TabStop = false;
            // 
            // pcb2
            // 
            this.pcb2.Image = global::BalıkAvı.Properties.Resources.icons8_fish_food_50;
            this.pcb2.Location = new System.Drawing.Point(231, 236);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(52, 47);
            this.pcb2.TabIndex = 2;
            this.pcb2.TabStop = false;
            // 
            // pcb3
            // 
            this.pcb3.Image = global::BalıkAvı.Properties.Resources.icons8_fish_food_50;
            this.pcb3.Location = new System.Drawing.Point(440, 206);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(53, 46);
            this.pcb3.TabIndex = 3;
            this.pcb3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcb3);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.pcBTimsah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBTimsah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBTimsah;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.PictureBox pcb3;
    }
}


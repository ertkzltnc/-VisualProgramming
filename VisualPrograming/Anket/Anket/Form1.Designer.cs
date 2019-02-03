namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbMedeniDurum = new System.Windows.Forms.GroupBox();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.grbYas = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbYasli = new System.Windows.Forms.RadioButton();
            this.rdbOrtaYasli = new System.Windows.Forms.RadioButton();
            this.rdbGenc = new System.Windows.Forms.RadioButton();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblAnket = new System.Windows.Forms.Label();
            this.grbSoru1 = new System.Windows.Forms.GroupBox();
            this.lblSoru1 = new System.Windows.Forms.Label();
            this.rdbİletisim1 = new System.Windows.Forms.RadioButton();
            this.rdbİletisim2 = new System.Windows.Forms.RadioButton();
            this.rdbİletisim3 = new System.Windows.Forms.RadioButton();
            this.rdbİletisim5 = new System.Windows.Forms.RadioButton();
            this.rdbİletisim4 = new System.Windows.Forms.RadioButton();
            this.grbSoru2 = new System.Windows.Forms.GroupBox();
            this.rdbBeslenme4 = new System.Windows.Forms.RadioButton();
            this.rdbBeslenme5 = new System.Windows.Forms.RadioButton();
            this.rdbBeslenme3 = new System.Windows.Forms.RadioButton();
            this.rdbBeslenme2 = new System.Windows.Forms.RadioButton();
            this.rdbBeslenme1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.grbSoru3 = new System.Windows.Forms.GroupBox();
            this.rdbEbeveyn4 = new System.Windows.Forms.RadioButton();
            this.rdbEbeveyn5 = new System.Windows.Forms.RadioButton();
            this.rdbEbeveyn3 = new System.Windows.Forms.RadioButton();
            this.rdbEbeveyn2 = new System.Windows.Forms.RadioButton();
            this.rdbEbeveyn1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.pcbDegerler = new System.Windows.Forms.PictureBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.grbCinsiyet.SuspendLayout();
            this.grbMedeniDurum.SuspendLayout();
            this.grbYas.SuspendLayout();
            this.grbSoru1.SuspendLayout();
            this.grbSoru2.SuspendLayout();
            this.grbSoru3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDegerler)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCinsiyet
            // 
            this.grbCinsiyet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCinsiyet.Controls.Add(this.rdbKadın);
            this.grbCinsiyet.Controls.Add(this.rdbErkek);
            this.grbCinsiyet.Controls.Add(this.label1);
            this.grbCinsiyet.Enabled = false;
            this.grbCinsiyet.Location = new System.Drawing.Point(12, 32);
            this.grbCinsiyet.Name = "grbCinsiyet";
            this.grbCinsiyet.Size = new System.Drawing.Size(383, 66);
            this.grbCinsiyet.TabIndex = 0;
            this.grbCinsiyet.TabStop = false;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(114, 30);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(65, 21);
            this.rdbKadın.TabIndex = 2;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(252, 30);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(65, 21);
            this.rdbErkek.TabIndex = 1;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinsiyetiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demogarfik Özellikler";
            // 
            // grbMedeniDurum
            // 
            this.grbMedeniDurum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbMedeniDurum.Controls.Add(this.rdbBekar);
            this.grbMedeniDurum.Controls.Add(this.rdbEvli);
            this.grbMedeniDurum.Controls.Add(this.label3);
            this.grbMedeniDurum.Enabled = false;
            this.grbMedeniDurum.Location = new System.Drawing.Point(12, 104);
            this.grbMedeniDurum.Name = "grbMedeniDurum";
            this.grbMedeniDurum.Size = new System.Drawing.Size(383, 100);
            this.grbMedeniDurum.TabIndex = 2;
            this.grbMedeniDurum.TabStop = false;
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Location = new System.Drawing.Point(223, 49);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(66, 21);
            this.rdbBekar.TabIndex = 2;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "Bekar";
            this.rdbBekar.UseVisualStyleBackColor = true;
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(153, 49);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(51, 21);
            this.rdbEvli.TabIndex = 1;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "Evli";
            this.rdbEvli.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medeni Durumunuz";
            // 
            // grbYas
            // 
            this.grbYas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbYas.Controls.Add(this.rdbGenc);
            this.grbYas.Controls.Add(this.rdbOrtaYasli);
            this.grbYas.Controls.Add(this.rdbYasli);
            this.grbYas.Controls.Add(this.label4);
            this.grbYas.Enabled = false;
            this.grbYas.Location = new System.Drawing.Point(12, 210);
            this.grbYas.Name = "grbYas";
            this.grbYas.Size = new System.Drawing.Size(383, 100);
            this.grbYas.TabIndex = 3;
            this.grbYas.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yaşınız";
            // 
            // rdbYasli
            // 
            this.rdbYasli.AutoSize = true;
            this.rdbYasli.Location = new System.Drawing.Point(102, 37);
            this.rdbYasli.Name = "rdbYasli";
            this.rdbYasli.Size = new System.Drawing.Size(97, 21);
            this.rdbYasli.TabIndex = 1;
            this.rdbYasli.TabStop = true;
            this.rdbYasli.Text = "40 ve Üstü";
            this.rdbYasli.UseVisualStyleBackColor = true;
            // 
            // rdbOrtaYasli
            // 
            this.rdbOrtaYasli.AutoSize = true;
            this.rdbOrtaYasli.Location = new System.Drawing.Point(217, 37);
            this.rdbOrtaYasli.Name = "rdbOrtaYasli";
            this.rdbOrtaYasli.Size = new System.Drawing.Size(66, 21);
            this.rdbOrtaYasli.TabIndex = 2;
            this.rdbOrtaYasli.TabStop = true;
            this.rdbOrtaYasli.Text = "25-40";
            this.rdbOrtaYasli.UseVisualStyleBackColor = true;
            // 
            // rdbGenc
            // 
            this.rdbGenc.AutoSize = true;
            this.rdbGenc.Location = new System.Drawing.Point(303, 35);
            this.rdbGenc.Name = "rdbGenc";
            this.rdbGenc.Size = new System.Drawing.Size(66, 21);
            this.rdbGenc.TabIndex = 3;
            this.rdbGenc.TabStop = true;
            this.rdbGenc.Text = "18-25";
            this.rdbGenc.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBasla.Location = new System.Drawing.Point(13, 379);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(107, 36);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "Ankete Basla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBitir.Location = new System.Drawing.Point(152, 379);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(101, 37);
            this.btnBitir.TabIndex = 5;
            this.btnBitir.Text = "Anket Bitir";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTemizle.Enabled = false;
            this.btnTemizle.Location = new System.Drawing.Point(297, 379);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(98, 37);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Yeni Anket";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblAnket
            // 
            this.lblAnket.AutoSize = true;
            this.lblAnket.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAnket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnket.Location = new System.Drawing.Point(687, 91);
            this.lblAnket.Name = "lblAnket";
            this.lblAnket.Size = new System.Drawing.Size(128, 20);
            this.lblAnket.TabIndex = 8;
            this.lblAnket.Text = "Anket Soruları";
            // 
            // grbSoru1
            // 
            this.grbSoru1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbSoru1.Controls.Add(this.rdbİletisim4);
            this.grbSoru1.Controls.Add(this.rdbİletisim5);
            this.grbSoru1.Controls.Add(this.rdbİletisim3);
            this.grbSoru1.Controls.Add(this.rdbİletisim2);
            this.grbSoru1.Controls.Add(this.rdbİletisim1);
            this.grbSoru1.Controls.Add(this.lblSoru1);
            this.grbSoru1.Enabled = false;
            this.grbSoru1.Location = new System.Drawing.Point(497, 132);
            this.grbSoru1.Name = "grbSoru1";
            this.grbSoru1.Size = new System.Drawing.Size(642, 57);
            this.grbSoru1.TabIndex = 9;
            this.grbSoru1.TabStop = false;
            // 
            // lblSoru1
            // 
            this.lblSoru1.AutoSize = true;
            this.lblSoru1.Location = new System.Drawing.Point(20, 18);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(162, 17);
            this.lblSoru1.TabIndex = 0;
            this.lblSoru1.Text = "Cocuğum ile İletişimim İyi";
            // 
            // rdbİletisim1
            // 
            this.rdbİletisim1.AutoSize = true;
            this.rdbİletisim1.Location = new System.Drawing.Point(420, 13);
            this.rdbİletisim1.Name = "rdbİletisim1";
            this.rdbİletisim1.Size = new System.Drawing.Size(17, 16);
            this.rdbİletisim1.TabIndex = 1;
            this.rdbİletisim1.TabStop = true;
            this.rdbİletisim1.UseVisualStyleBackColor = true;
            // 
            // rdbİletisim2
            // 
            this.rdbİletisim2.AutoSize = true;
            this.rdbİletisim2.Location = new System.Drawing.Point(466, 13);
            this.rdbİletisim2.Name = "rdbİletisim2";
            this.rdbİletisim2.Size = new System.Drawing.Size(17, 16);
            this.rdbİletisim2.TabIndex = 2;
            this.rdbİletisim2.TabStop = true;
            this.rdbİletisim2.UseVisualStyleBackColor = true;
            // 
            // rdbİletisim3
            // 
            this.rdbİletisim3.AutoSize = true;
            this.rdbİletisim3.Location = new System.Drawing.Point(504, 13);
            this.rdbİletisim3.Name = "rdbİletisim3";
            this.rdbİletisim3.Size = new System.Drawing.Size(17, 16);
            this.rdbİletisim3.TabIndex = 3;
            this.rdbİletisim3.TabStop = true;
            this.rdbİletisim3.UseVisualStyleBackColor = true;
            // 
            // rdbİletisim5
            // 
            this.rdbİletisim5.AutoSize = true;
            this.rdbİletisim5.Location = new System.Drawing.Point(586, 13);
            this.rdbİletisim5.Name = "rdbİletisim5";
            this.rdbİletisim5.Size = new System.Drawing.Size(17, 16);
            this.rdbİletisim5.TabIndex = 4;
            this.rdbİletisim5.TabStop = true;
            this.rdbİletisim5.UseVisualStyleBackColor = true;
            // 
            // rdbİletisim4
            // 
            this.rdbİletisim4.AutoSize = true;
            this.rdbİletisim4.Location = new System.Drawing.Point(538, 13);
            this.rdbİletisim4.Name = "rdbİletisim4";
            this.rdbİletisim4.Size = new System.Drawing.Size(17, 16);
            this.rdbİletisim4.TabIndex = 5;
            this.rdbİletisim4.TabStop = true;
            this.rdbİletisim4.UseVisualStyleBackColor = true;
            // 
            // grbSoru2
            // 
            this.grbSoru2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbSoru2.Controls.Add(this.rdbBeslenme4);
            this.grbSoru2.Controls.Add(this.rdbBeslenme5);
            this.grbSoru2.Controls.Add(this.rdbBeslenme3);
            this.grbSoru2.Controls.Add(this.rdbBeslenme2);
            this.grbSoru2.Controls.Add(this.rdbBeslenme1);
            this.grbSoru2.Controls.Add(this.label5);
            this.grbSoru2.Enabled = false;
            this.grbSoru2.Location = new System.Drawing.Point(497, 211);
            this.grbSoru2.Name = "grbSoru2";
            this.grbSoru2.Size = new System.Drawing.Size(642, 57);
            this.grbSoru2.TabIndex = 10;
            this.grbSoru2.TabStop = false;
            // 
            // rdbBeslenme4
            // 
            this.rdbBeslenme4.AutoSize = true;
            this.rdbBeslenme4.Location = new System.Drawing.Point(538, 13);
            this.rdbBeslenme4.Name = "rdbBeslenme4";
            this.rdbBeslenme4.Size = new System.Drawing.Size(17, 16);
            this.rdbBeslenme4.TabIndex = 5;
            this.rdbBeslenme4.TabStop = true;
            this.rdbBeslenme4.UseVisualStyleBackColor = true;
            // 
            // rdbBeslenme5
            // 
            this.rdbBeslenme5.AutoSize = true;
            this.rdbBeslenme5.Location = new System.Drawing.Point(586, 13);
            this.rdbBeslenme5.Name = "rdbBeslenme5";
            this.rdbBeslenme5.Size = new System.Drawing.Size(17, 16);
            this.rdbBeslenme5.TabIndex = 4;
            this.rdbBeslenme5.TabStop = true;
            this.rdbBeslenme5.UseVisualStyleBackColor = true;
            // 
            // rdbBeslenme3
            // 
            this.rdbBeslenme3.AutoSize = true;
            this.rdbBeslenme3.Location = new System.Drawing.Point(504, 13);
            this.rdbBeslenme3.Name = "rdbBeslenme3";
            this.rdbBeslenme3.Size = new System.Drawing.Size(17, 16);
            this.rdbBeslenme3.TabIndex = 3;
            this.rdbBeslenme3.TabStop = true;
            this.rdbBeslenme3.UseVisualStyleBackColor = true;
            // 
            // rdbBeslenme2
            // 
            this.rdbBeslenme2.AutoSize = true;
            this.rdbBeslenme2.Location = new System.Drawing.Point(466, 13);
            this.rdbBeslenme2.Name = "rdbBeslenme2";
            this.rdbBeslenme2.Size = new System.Drawing.Size(17, 16);
            this.rdbBeslenme2.TabIndex = 2;
            this.rdbBeslenme2.TabStop = true;
            this.rdbBeslenme2.UseVisualStyleBackColor = true;
            // 
            // rdbBeslenme1
            // 
            this.rdbBeslenme1.AutoSize = true;
            this.rdbBeslenme1.Location = new System.Drawing.Point(420, 13);
            this.rdbBeslenme1.Name = "rdbBeslenme1";
            this.rdbBeslenme1.Size = new System.Drawing.Size(17, 16);
            this.rdbBeslenme1.TabIndex = 1;
            this.rdbBeslenme1.TabStop = true;
            this.rdbBeslenme1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cocuğumun Beslenme Takibini Yapıyorum";
            // 
            // grbSoru3
            // 
            this.grbSoru3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbSoru3.Controls.Add(this.rdbEbeveyn4);
            this.grbSoru3.Controls.Add(this.rdbEbeveyn5);
            this.grbSoru3.Controls.Add(this.rdbEbeveyn3);
            this.grbSoru3.Controls.Add(this.rdbEbeveyn2);
            this.grbSoru3.Controls.Add(this.rdbEbeveyn1);
            this.grbSoru3.Controls.Add(this.label6);
            this.grbSoru3.Enabled = false;
            this.grbSoru3.Location = new System.Drawing.Point(497, 288);
            this.grbSoru3.Name = "grbSoru3";
            this.grbSoru3.Size = new System.Drawing.Size(642, 57);
            this.grbSoru3.TabIndex = 11;
            this.grbSoru3.TabStop = false;
            // 
            // rdbEbeveyn4
            // 
            this.rdbEbeveyn4.AutoSize = true;
            this.rdbEbeveyn4.Location = new System.Drawing.Point(538, 13);
            this.rdbEbeveyn4.Name = "rdbEbeveyn4";
            this.rdbEbeveyn4.Size = new System.Drawing.Size(17, 16);
            this.rdbEbeveyn4.TabIndex = 5;
            this.rdbEbeveyn4.TabStop = true;
            this.rdbEbeveyn4.UseVisualStyleBackColor = true;
            // 
            // rdbEbeveyn5
            // 
            this.rdbEbeveyn5.AutoSize = true;
            this.rdbEbeveyn5.Location = new System.Drawing.Point(586, 13);
            this.rdbEbeveyn5.Name = "rdbEbeveyn5";
            this.rdbEbeveyn5.Size = new System.Drawing.Size(17, 16);
            this.rdbEbeveyn5.TabIndex = 4;
            this.rdbEbeveyn5.TabStop = true;
            this.rdbEbeveyn5.UseVisualStyleBackColor = true;
            // 
            // rdbEbeveyn3
            // 
            this.rdbEbeveyn3.AutoSize = true;
            this.rdbEbeveyn3.Location = new System.Drawing.Point(504, 13);
            this.rdbEbeveyn3.Name = "rdbEbeveyn3";
            this.rdbEbeveyn3.Size = new System.Drawing.Size(17, 16);
            this.rdbEbeveyn3.TabIndex = 3;
            this.rdbEbeveyn3.TabStop = true;
            this.rdbEbeveyn3.UseVisualStyleBackColor = true;
            // 
            // rdbEbeveyn2
            // 
            this.rdbEbeveyn2.AutoSize = true;
            this.rdbEbeveyn2.Location = new System.Drawing.Point(466, 13);
            this.rdbEbeveyn2.Name = "rdbEbeveyn2";
            this.rdbEbeveyn2.Size = new System.Drawing.Size(17, 16);
            this.rdbEbeveyn2.TabIndex = 2;
            this.rdbEbeveyn2.TabStop = true;
            this.rdbEbeveyn2.UseVisualStyleBackColor = true;
            // 
            // rdbEbeveyn1
            // 
            this.rdbEbeveyn1.AutoSize = true;
            this.rdbEbeveyn1.Location = new System.Drawing.Point(420, 13);
            this.rdbEbeveyn1.Name = "rdbEbeveyn1";
            this.rdbEbeveyn1.Size = new System.Drawing.Size(17, 16);
            this.rdbEbeveyn1.TabIndex = 1;
            this.rdbEbeveyn1.TabStop = true;
            this.rdbEbeveyn1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "İyi Bir Ebeveynim(Olabilirim)";
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSonuc.Location = new System.Drawing.Point(497, 379);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(370, 193);
            this.txtSonuc.TabIndex = 12;
            // 
            // pcbResim
            // 
            this.pcbResim.Image = global::Anket.Properties.Resources.images;
            this.pcbResim.Location = new System.Drawing.Point(885, 379);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(254, 193);
            this.pcbResim.TabIndex = 13;
            this.pcbResim.TabStop = false;
            // 
            // pcbDegerler
            // 
            this.pcbDegerler.BackColor = System.Drawing.SystemColors.Control;
            this.pcbDegerler.Image = global::Anket.Properties.Resources._1;
            this.pcbDegerler.Location = new System.Drawing.Point(897, 24);
            this.pcbDegerler.Name = "pcbDegerler";
            this.pcbDegerler.Size = new System.Drawing.Size(220, 87);
            this.pcbDegerler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDegerler.TabIndex = 7;
            this.pcbDegerler.TabStop = false;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCıkıs.Location = new System.Drawing.Point(74, 473);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(285, 35);
            this.btnCıkıs.TabIndex = 14;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1156, 613);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.pcbResim);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.grbSoru3);
            this.Controls.Add(this.grbSoru2);
            this.Controls.Add(this.grbSoru1);
            this.Controls.Add(this.lblAnket);
            this.Controls.Add(this.pcbDegerler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.grbYas);
            this.Controls.Add(this.grbMedeniDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbCinsiyet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.Text = "Ebeveyn Anketi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCinsiyet.ResumeLayout(false);
            this.grbCinsiyet.PerformLayout();
            this.grbMedeniDurum.ResumeLayout(false);
            this.grbMedeniDurum.PerformLayout();
            this.grbYas.ResumeLayout(false);
            this.grbYas.PerformLayout();
            this.grbSoru1.ResumeLayout(false);
            this.grbSoru1.PerformLayout();
            this.grbSoru2.ResumeLayout(false);
            this.grbSoru2.PerformLayout();
            this.grbSoru3.ResumeLayout(false);
            this.grbSoru3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDegerler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCinsiyet;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbMedeniDurum;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbYas;
        private System.Windows.Forms.RadioButton rdbGenc;
        private System.Windows.Forms.RadioButton rdbOrtaYasli;
        private System.Windows.Forms.RadioButton rdbYasli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pcbDegerler;
        private System.Windows.Forms.Label lblAnket;
        private System.Windows.Forms.GroupBox grbSoru1;
        private System.Windows.Forms.RadioButton rdbİletisim4;
        private System.Windows.Forms.RadioButton rdbİletisim5;
        private System.Windows.Forms.RadioButton rdbİletisim3;
        private System.Windows.Forms.RadioButton rdbİletisim2;
        private System.Windows.Forms.RadioButton rdbİletisim1;
        private System.Windows.Forms.Label lblSoru1;
        private System.Windows.Forms.GroupBox grbSoru2;
        private System.Windows.Forms.RadioButton rdbBeslenme4;
        private System.Windows.Forms.RadioButton rdbBeslenme5;
        private System.Windows.Forms.RadioButton rdbBeslenme3;
        private System.Windows.Forms.RadioButton rdbBeslenme2;
        private System.Windows.Forms.RadioButton rdbBeslenme1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbSoru3;
        private System.Windows.Forms.RadioButton rdbEbeveyn4;
        private System.Windows.Forms.RadioButton rdbEbeveyn5;
        private System.Windows.Forms.RadioButton rdbEbeveyn3;
        private System.Windows.Forms.RadioButton rdbEbeveyn2;
        private System.Windows.Forms.RadioButton rdbEbeveyn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.Button btnCıkıs;
    }
}


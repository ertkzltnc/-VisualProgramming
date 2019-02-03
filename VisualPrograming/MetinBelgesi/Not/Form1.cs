using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean kayıtKontrol = false;
        Boolean yeniKayıt = true;
        string dosyaAdı = "";
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // not defteri++ hakkında kısmı menu kodları
            MessageBox.Show("Bütün Hakları saklı değildir.", "kzltnc");
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (yeniKayıt)
                {
                    DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek ister misiniz?", "Dosyayı Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            SaveAsFileMenu();

                            break;
                        case DialogResult.No:

                            break;
                    }
                }
                kayıtKontrol = false;
                yeniKayıt = false;
                dosyaAdı = "";

                geriAlToolStripMenuItem.Enabled = false;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }
        private void SaveAsFileMenu() // farklı kaydet icinde kullanılacak
        {
            //farklı kaydet fonksiyonu
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            DialogResult result = saveFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                        rctText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    if (Path.GetExtension(saveFileDialog.FileName) == ".rft")
                        rctText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    this.Text = Path.GetFileName(saveFileDialog.FileName) + " - Not Defteri++";
                    kayıtKontrol = true;
                    yeniKayıt = false;
                    dosyaAdı = saveFileDialog.FileName;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //kaydet'in fonksiyon kodları
                if (kayıtKontrol)
                {
                    if (Path.GetExtension(dosyaAdı) == ".txt")
                        rctText.SaveFile(dosyaAdı, RichTextBoxStreamType.PlainText);
                    if (Path.GetExtension(dosyaAdı) == ".rft")
                        rctText.SaveFile(dosyaAdı, RichTextBoxStreamType.RichText);
                    yeniKayıt = false;

                }
                else
                {
                    if (yeniKayıt)
                    {
                        SaveAsFileMenu();
                    }
                    else
                    {
                        //ekranı temizleme kodları
                        rctText.Clear();
                        this.Text = "İsimsiz ";
                        yeniKayıt = false;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //var olan herhangi bir dosyayı açmak için kullanılan kodlar
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                        rctText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                        rctText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);

                    this.Text = Path.GetFileName(openFileDialog.FileName) + " - Not Defteri++";
                    kayıtKontrol = true;
                    yeniKayıt = false;
                    dosyaAdı = openFileDialog.FileName;

                    //İleri-geri al aktif/pasif
                    geriAlToolStripMenuItem.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //farklı kaydet
            SaveAsFileMenu();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(); // yazıcı
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // cıkıs
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Undo();// geri al
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Cut(); // kes
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Copy(); // kopyala
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Paste(); // yapıştır
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Clear(); // sil
        }

        

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctText.Text = string.Format(" {0}", DateTime.Now); // tarih
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); // font
            rctText.SelectionFont = fontDialog1.Font;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            DialogResult result = colordialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (rctText.SelectionLength > 0)
                {
                    rctText.SelectionColor = colordialog.Color;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_DialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            //Bütün dialog pencerelerinin show veya showDialog isminde metotları bulunur
            //Bu metotlar diaolg pencerelerini açmayı saplar
            DialogResult sonuc = fontDialog1.ShowDialog();
            //Tüm dialog pencereleri geriye DialogResult tipinde değer döndereri
            //MessageBox.show da yine bir diaolg penceresidr
            if (sonuc == DialogResult.OK)
            {
                //fontDialog1.Font özelliği içerisinde fontDialog penceresinden seçilen fontu deneme tahtasına aktarı
                lblDenemeTahtasi.Font = fontDialog1.Font;
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            //sen openfiledialog'un initialDirectory adresine masaustünü tanımlarsan default olarak orayı açar
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpeg)|*.jpeg|Jpg Dosyası (*.jpg)|*.jpg|Png Dosyası (*.png)|*.png|Gif Dosyası (*.gif)|*.gif";//Bu şekilde seçilebilecek dosyaları filtreleyebiliyoruz
            openFileDialog1.Title = "Resim Dosyası Seçiniz";//Dosya seçme ekranın üstünde yazar
            DialogResult sonuc = openFileDialog1.ShowDialog();//Bu kısım görüntüde bişey göstermeyen ama aşağıya gelen kısım varya onun sayesinde geliyor ismi btn ile başlamıyor dikkat et
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = openFileDialog1.FileName;//seçtiğimiz dosyanın yolunu alıyoruz
                lblDeneme2.Text = openFileDialog1.SafeFileName;//Seçilen dosyanın sadece ismini verir
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydedilecek dosyayı seçiniz";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = saveFileDialog1.FileName;
            }

        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();//Klasör seçebileceğin bir dialog
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.ForeColor = colorDialog1.Color;
                lblDeneme2.BackColor = colorDialog1.Color;
            }
        }
    }
}


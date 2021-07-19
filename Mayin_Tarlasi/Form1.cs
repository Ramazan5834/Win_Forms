using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(10, 10);
        }

        void TarlaOlustur(int satir, int sutun)
        {
            flowLayoutPanel1.Controls.Clear();//Her yeni oyun başlattığımızda önceki oyundan butonları siliip yeniden aşapıda üretmesi lazım
            int mayin = (satir * sutun) / 10;
            int[] mayinlar = new int[mayin];
            Random rnd = new Random();
            for (int i = 0; i < mayinlar.Length; i++)
            {
                int secilen = rnd.Next(0, satir * sutun);
                if (mayinlar.Contains(secilen) == true)//mayinlar dizisi içerisinde daha önceden seçilen değeri içeriyormu yani aynı yere iki kere üst üste mayın koymamak için
                {
                    i--;
                }
                else
                {
                    mayinlar[i] = secilen;
                }
            }

            for (int i = 0; i < satir * sutun; i++)
            {
                Button btn = new Button();
                btn.Width = btn.Height = 30;
                btn.BackColor = Color.Green;
                if (mayinlar.Contains(i) == true)
                {
                    btn.Tag = true;//Tag özelliği her element için vardır ve içine bir değer koyabilirsin
                }
                else
                {
                    btn.Tag = false;
                }

                btn.Click += btn_Click;
                btn.Margin = new Padding(5, 5, 0, 0);
                flowLayoutPanel1.Controls.Add(btn);

            }

            flowLayoutPanel1.Width = sutun * 35;
            flowLayoutPanel1.Height = satir * 35;
            this.Width = flowLayoutPanel1.Width + 50;
            this.Height = flowLayoutPanel1.Height + 80;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;//Castleme yöntemi
            if ((bool)tiklanan.Tag == true)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    Button btn = item as Button;
                    if ((bool)btn.Tag == true)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }
                }
                MessageBox.Show("Oyun BİTTİ");
                flowLayoutPanel1.Controls.Clear();
            }
            else
            {
                tiklanan.BackColor = Color.Gray;
            }
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(13, 13);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(16, 16);
        }
    }
}

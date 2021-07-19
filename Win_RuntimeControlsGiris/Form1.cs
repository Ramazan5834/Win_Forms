using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_RuntimeControlsGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Text = sayac.ToString();
            Random rnd = new Random();
            btn.Width = 50;
            btn.Height = 30;
            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);
            btn.Left = x;
            int y = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Top = y;
            btn.Click += btn_Click;//Runtime anında üretilen bir kontrol'e event atama yöntemi += ile olur daha sonra iki kez tab tuşuna basılır
            this.Controls.Add(btn);
            sayac++;
        }

        //object sendeer içerisinde bu metodu çağıran elementi yani butonu getirir
        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            //MessageBox.Show(tiklanan.Text);
            //this.Controls.Remove(tiklanan);
            tiklanan.BringToFront();//En öne getir(Butonlar üst üste binince tıklayınca öne gelsin diye)
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10 satır 20 kolonluk bir buton koleksiyonu oluşturacğız
          ButtonOlustur(10);

            //this.Width = 50 * 20; Auto size demeyip böylede yapabilirsin
        }

        void ButtonOlustur(int satirSayisi)
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    this.Controls.Remove(ctrl);
                    goto yavaslat;//Filanca yere git demek oluyor geldiğinde ise döngü kaldığı yerden çalışıyor sıkınıt yok

                }
            }
            //ilk döngü satır için ilem yapacak
            for (int i = 0; i < satirSayisi; i++)
            {
                //İkinci döngümüz sutun için işlem yapacak
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);
                    btn.Width = 50;
                    btn.Height = 20;
                    btn.Left = j * 50;
                    btn.Top = (i * 20) + 30;//Menünün altında kaldığı için 30 px ekliyoruz
                    this.Controls.Add(btn);
                }
            }
        }

        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ButtonOlustur(20);
        }
    }
}

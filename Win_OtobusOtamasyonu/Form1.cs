using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_OtobusOtamasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "Travego":
                    KoltukDoldur(8, false);
                    break;
                case "Setra":
                    KoltukDoldur(12, true);
                    break;
                case "Neoplan":
                    KoltukDoldur(10, false);
                    break;
                default: break;
            }
        }

        private void KoltukDoldur(int sira, bool arkaBesliMi)
        {
        yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Kaydet")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);//Önceki koltukları siliyoruz otobus değişince önceden kalanları yani
                        goto yavaslat;
                    }
                }
            }
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == sira / 2 && j > 2)
                    {
                        continue;
                    }
                    if (arkaBesliMi == true)
                    {
                        if (i != sira - 1 && j == 2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (j == 2)
                        {
                            continue;
                        }
                    }
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += koltuk_MouseDown;//MouseDown eventi sağ tık sol tık farketmez çalışır click eventi sadece sol tıkda çalışır
                    this.Controls.Add(koltuk);
                }
            }
        }

        private Button tiklanan;
        private void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOtobus,"Otobüs Seçiniz");
            }
            if (cmbNereden.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbNereden, "Boş Geçilemez");
            }
            if (cmbNereye.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbNereye, "Boş Geçilemez");
            }

            if (cmbOtobus.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz");
                return;
            }
            KayitFormu kf = new KayitFormu();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}", kf.txtIsim, kf.txtSoyisim);
                lvi.SubItems.Add(kf.mskdTelefon.Text);
                if (kf.rdbBay.Checked)
                {
                    lvi.SubItems.Add("BAY");
                    tiklanan.BackColor = Color.Blue;
                }
                if (kf.rdbBayan.Checked)
                {
                    lvi.SubItems.Add("BAYAN");
                    tiklanan.BackColor = Color.Pink;
                }
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                listView1.Items.Add(lvi);

            }
        }
    }
}

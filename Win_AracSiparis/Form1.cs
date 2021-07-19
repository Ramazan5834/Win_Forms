using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_AracSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":
                    cmbModel.Items.Add("JETTA");
                    cmbModel.Items.Add("PASSAT");
                    cmbModel.Items.Add("CC");
                    break;
                case "AUDI":
                    cmbModel.Items.Add("A7");
                    cmbModel.Items.Add("Q7");
                    cmbModel.Items.Add("R8");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("CLIO");
                    cmbModel.Items.Add("LAGUNA");
                    cmbModel.Items.Add("SYMBOL");
                    break;

                case "BMW":
                    cmbModel.Items.Add("M6 COUPE");
                    cmbModel.Items.Add("X6");
                    cmbModel.Items.Add("5.25");
                    break;
                case "HYUNDAİ":
                    cmbModel.Items.Add("ACCENT");
                    cmbModel.Items.Add("İ 30");
                    cmbModel.Items.Add("İX 35");
                    break;
                case "MERCEDES":
                    cmbModel.Items.Add("200 AMG");
                    cmbModel.Items.Add("E 250");
                    cmbModel.Items.Add("CLA 200");
                    break;
                case "FİAT":

                    break;
                case "HONDA":
                    cmbModel.Items.Add("CIVIC");
                    cmbModel.Items.Add("CITY");
                    cmbModel.Items.Add("CRV");
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;//default olarak listviewın alt elemanlarının özellikleri değiştirilemez olarak gelir onun için buna müdahale edebilme yetkisi açmalıyız
            lvi.Text = cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYakitTipi.Text);
            lvi.SubItems.Add(cmbKasaTipi.Text);
            lvi.SubItems.Add(cmbVitesTipi.Text);
            lvi.SubItems.Add(cmbMotorTipi.Text);
            lvi.SubItems.Add("");
            lvi.SubItems[6].BackColor = btnRenk.BackColor;//olmayan bi yere renk veremeyiz o yüzden yukarıda boş bi şekilde ilk önce o kolonu oluşturduk
            lvi.SubItems.Add(dtpYili.Text);

            listView1.Items.Add(lvi);

            foreach (Control ctrl in this.Controls)//yani formun içine sen birşey attığın zaman yani kontrol attığında orada bi collection yapısı oluşur ve biz o kontrolleri bu şekilde geziyrouz
            //Buraya control değilde combobox yazsaydık hata vermezdi ama çalışırken hata verirdi çünkü sadece combobox yok label fln da var orada
            {
                //gelen ctrl elemanı şu tip mi diye sorgulamak için is komutu kullanılır
                // == değeri kontrol etmek içindir
                if (ctrl is ComboBox)//gelen ctrl Combobox mı
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;//Gelen şey yani ctrl Control olarak geliyor Combobox olarak gelmiyor o yüzden selectedındex vs gibi fonksiyonlarda gelmiyor onun için bu şekilde cast etmek gerekiyor
                }
                else if (ctrl is Button)
                {
                    // ((Button) ctrl).BackColor = Color.Gray; yada
                    Button btn = (Button)ctrl;
                    if (btn.Name == "btnRenk")
                    {
                        btn.BackColor = Color.LightGray;
                    }
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);//Burada bana normalde seçili olanları döndür diyor ama ben[0] diyerek aslında ilk seçilen sil demiş oluyorum
            }

        }

        private ListViewItem secili;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Düzenlemek istediğiniz satırı seçiniz");
                return;
            }

            secili = listView1.SelectedItems[0];
            cmbMarka.Text = secili.Text;
            cmbModel.Text = secili.SubItems[1].Text;
            cmbYakitTipi.Text = secili.SubItems[2].Text;
            cmbKasaTipi.Text = secili.SubItems[3].Text;
            cmbVitesTipi.Text = secili.SubItems[4].Text;
            cmbMotorTipi.Text = secili.SubItems[5].Text;
            btnRenk.BackColor = secili.SubItems[6].BackColor;
            dtpYili.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //secili.Text = cmbMarka.Text;
            secili.SubItems[0].Text = cmbMarka.Text;
            secili.SubItems[1].Text = cmbModel.Text;
            secili.SubItems[2].Text = cmbYakitTipi.Text;
            secili.SubItems[3].Text = cmbKasaTipi.Text;
            secili.SubItems[4].Text = cmbVitesTipi.Text;
            secili.SubItems[5].Text = cmbMotorTipi.Text;
            secili.SubItems[6].BackColor = btnRenk.BackColor;
            secili.SubItems[7].Text = dtpYili.Text;
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count>0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_TcknDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != string.Empty)
            {
                listBox1.Items.Add(txtIsim.Text.ToUpper().Trim());
                txtIsim.Clear();
                txtIsim.Focus();
            }
        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            MessageBox.Show(adet.ToString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtIsimAra.Text != string.Empty)
            {
                string isim = txtIsimAra.Text.ToUpper().Trim();
                if (listBox1.Items.Contains(isim))
                {
                    MessageBox.Show("Aranan İsim Listede Var");
                }
                else
                {
                    MessageBox.Show("Aranan İsim Listede Yok");
                }
            }
        }

        private void txtIsimAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtIsimAra.Text.ToUpper().Trim();
            ArrayList isimler = new ArrayList();//string[] e göre daha esnek bi yapıdadır direk add dersen ekler remove dersen kaldırır indeksleriyle elinle uğraşmana gerek kalmaz
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                isimler.Add(listBox1.Items[i]
                    .ToString()); //Basılan tuşları hesaplarken elimizdeki diziyi bozamayız o yüzden yeni bi dizi oluşturuyoruz kopyalıyoruz
            }

            foreach (string item in isimler)
            {
                if (!item.Contains(aranan))
                {
                    listBox1.Items.Remove(item);
                }
            }
        }
    }
}

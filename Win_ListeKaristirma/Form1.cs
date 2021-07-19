using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace Win_ListeKaristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            if (listBox1.Items.Contains(isim) == true)//Listbox isimi zaten içeriyormu onu kontrol ediyoruz eğer içeriyorsa bidaha ekleme
            {
                MessageBox.Show("Girilen isim listede vardır lütfen farkı bir isim giriniz");
            }
            else
            {
                listBox1.Items.Add(isim);
                textBox1.Clear();
                textBox1.Focus();
            }


        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[listBox1.Items.Count];
            Random rnd = new Random();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = rnd.Next(0, listBox1.Items.Count);
                string rastgele = listBox1.Items[sayi].ToString();

                if (isimler.Contains(rastgele) == false)
                {
                    isimler[i] = rastgele;
                }
                else
                {
                    i--;
                }
            }
            listBox1.Items.Clear();//Listbox un içini temizleme 
            foreach (string item in isimler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek istediğinize eminmisiniz", "Silme Formu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Dialog Kullanmı bu şekilde olabilir ve sonuç olarak DialogResult döndürür
            if (sonuc == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}

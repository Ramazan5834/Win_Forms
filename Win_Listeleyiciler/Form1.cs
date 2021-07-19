using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Listeleyiciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Trim() != string.Empty)
            {
                string isim = string.Format("{0}-{1}",listKisiler.Items.Count+1,txtIsim.Text.Trim());
                int elemanSayisi =listKisiler.Items.Count;//Bu şekilde listbox un içinde kaç eleman var bulabilirz
                listKisiler.Items.Add(isim);// Bu şekilde alta doğru ekleriz
                //listKisiler.Items.Insert(0,isim);//Bu şekilde hep en üste ekleyebiliriz
                txtIsim.Text = "";//yada string(empty); yada txtIsim.Clear();
                txtIsim.Focus();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string[] silinecekler = new string[listKisiler.SelectedItems.Count];
            for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
            {
                silinecekler[i] = (string) listKisiler.SelectedItems[i];
            }

            foreach (var item in silinecekler)
            {
                listKisiler.Items.Remove(item);
            }
            


        }

        private void listKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)//Basılan tuş Keylerden delete ise
            {
                string[] silinecekler = new string[listKisiler.SelectedItems.Count];
                for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
                {
                    silinecekler[i] = (string)listKisiler.SelectedItems[i];
                }

                foreach (var item in silinecekler)
                {
                    listKisiler.Items.Remove(item);
                }

            }
        }
    }
}

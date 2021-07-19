using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();//Listview'ı bu şekilde instance alarak kullanılabilecek hale getiriyoruz
            lvi.Text = txtIsim.Text;//listView için ilk kolonu .text diyerek çağırıyoruz
            lvi.SubItems.Add(txtSoyisim.Text);//İkinci kolonu bu şekilde çağırıyoruz
            lvi.SubItems.Add(mskdTelefon.Text);
            lvi.SubItems.Add(dtpDogumTarihi.Value.ToShortDateString()) ;
            listView1.Items.Add(lvi);
        }
    }
}

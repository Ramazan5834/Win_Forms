using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlAdi.lblControl.Text = "Adı";
            ctrlSoyadi.lblControl.Text = "Soyadı:";
            ctrlAdres.lblControl.Text = "Adres:";
            ctrlTelefon.lblControl.Text = "Telefon:";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ctrlAdi.txtControl.Text;
            lvi.SubItems.Add(ctrlSoyadi.txtControl.Text);
            lvi.SubItems.Add(ctrlAdres.txtControl.Text);
            lvi.SubItems.Add(ctrlTelefon.txtControl.Text);

            listView1.Items.Add(lvi);
        }
    }
}

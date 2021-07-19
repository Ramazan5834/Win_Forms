using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_RuntimeControlsUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipler.SelectedIndex = 0;
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(nudAdet.Value);
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < adet; i++)
            {
                switch (cmbTipler.Text)
                {
                    case "Buton":
                        Button btn = new Button();
                        btn.Height = 30;
                        btn.Width = 80;
                        btn.Text = string.Format("Buton {0}", i + 1);
                        btn.Font = new Font("Tahoma",10);//Butona font verme işini bu şekilde yaparız
                        btn.BackColor = Color.Gray;
                        btn.Click += btn_Click;
                        btn.MouseEnter += btn_MouseEnter;
                        btn.MouseLeave += btn_MouseLeave;
                        flowLayoutPanel1.Controls.Add(btn);
                        break;
                    case "Combobox":
                        ComboBox cmb = new ComboBox();
                        cmb.Items.Add("Item 1");
                        cmb.Items.Add("Item 2");
                        cmb.Items.Add("Item 3");
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmb.SelectedIndexChanged += cmb_SelecctedIndexChanged;
                       flowLayoutPanel1.Controls.Add(cmb);
                        break;
                    case "Textbox": break;
                    case "Listbox": break;
                    default: break;
                }
            }
        }

        private void cmb_SelecctedIndexChanged(object sender, EventArgs e)
        {
          ComboBox secilen = sender as ComboBox;
          MessageBox.Show(secilen.Text);

        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button tikalanan = (Button)sender;
            tikalanan.BackColor = Color.Gray;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            tiklanan.BackColor = Color.Red;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            MessageBox.Show(string.Format("{0}'e tıklandı'", tiklanan.Text));
        }
    }
}

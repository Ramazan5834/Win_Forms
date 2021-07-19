using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.Enabled = atYagiz.Enabled = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.Enabled = atYagiz.Enabled = false;//Atlar yarışa başladığnıda direk koşmasınlar diye enabled larını false yaptık

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            atYagiz.Left += rnd.Next(1,10);
            atRuzgarGulu.Left += rnd.Next(1, 10);
            atPoyraz.Left += rnd.Next(1, 10);
            atGolgeYele.Left += rnd.Next(1, 10);
            atAlver.Left += rnd.Next(1, 10);

            KimKazandi(atYagiz);
            KimKazandi(atRuzgarGulu);
            KimKazandi(atPoyraz);
            KimKazandi(atGolgeYele);
            KimKazandi(atAlver);

        }

        void KimKazandi(PictureBox kazanan)
        {
            if (kazanan.Right -10>= label1.Left)
            {
                timer1.Stop();
                atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.Enabled = atYagiz.Enabled = false;//Atlar yarışa başladığnıda direk koşmasınlar diye enabled larını false yaptık
                MessageBox.Show(kazanan.Name);
            }
        }
    }
}

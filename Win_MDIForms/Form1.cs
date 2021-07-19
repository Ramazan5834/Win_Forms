using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MDIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Eğer herhangi formu mdi form aolarak açmak istiyorsak show ile açmalıyız
            PersonelForm pf = new PersonelForm();
            pf.MdiParent = this;//PersonelFormun mdi parentı bu formdur
            pf.Show();
        }
        MusteriForm mf = new MusteriForm();

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)//müsterilerformu daha önce açıldımı
            {
                mf = new MusteriForm();
            }
            mf.MdiParent = this;
            mf.Show();
        }
    }
}

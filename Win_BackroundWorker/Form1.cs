using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_BackroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//Çapraz thread işlemlerini engelle
        }

        private int sayac1 = 0, sayac2 = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.CancelAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;//Bu thread parçasının iptal edilebilmesi için izin veriyoruz
            backgroundWorker1.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy == false)
            {
                backgroundWorker2.RunWorkerAsync();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)//backroundworker çalışmıyorsa
            {
                backgroundWorker1.RunWorkerAsync();//backrgroundworkerı asenron olarak çalıştır
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac1 < 100000)
            {
                sayac1++;
                label1.Text = sayac1.ToString();
                if (backgroundWorker1.CancellationPending)//Eğer sen backgroundworker1 in cancelAsync özelliğini sen true çalıştırdığın için bu prop true gelir
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac2 < 100000)
            {
                sayac2++;
                label2.Text = sayac2.ToString();
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;//e yi yani doworkeventargs dan gelen e yi iptal et dedim
                    return;
                }
            }
        }
    }
}

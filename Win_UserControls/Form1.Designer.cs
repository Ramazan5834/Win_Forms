namespace Win_UserControls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctrlTelefon = new Win_UserControls.InputControls();
            this.ctrlSoyadi = new Win_UserControls.InputControls();
            this.ctrlAdres = new Win_UserControls.InputControls();
            this.ctrlAdi = new Win_UserControls.InputControls();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(637, 95);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres";
            this.columnHeader3.Width = 242;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 213;
            // 
            // ctrlTelefon
            // 
            this.ctrlTelefon.Location = new System.Drawing.Point(315, 77);
            this.ctrlTelefon.Name = "ctrlTelefon";
            this.ctrlTelefon.Size = new System.Drawing.Size(326, 65);
            this.ctrlTelefon.TabIndex = 1;
            // 
            // ctrlSoyadi
            // 
            this.ctrlSoyadi.Location = new System.Drawing.Point(12, 77);
            this.ctrlSoyadi.Name = "ctrlSoyadi";
            this.ctrlSoyadi.Size = new System.Drawing.Size(326, 65);
            this.ctrlSoyadi.TabIndex = 1;
            // 
            // ctrlAdres
            // 
            this.ctrlAdres.Location = new System.Drawing.Point(315, 24);
            this.ctrlAdres.Name = "ctrlAdres";
            this.ctrlAdres.Size = new System.Drawing.Size(326, 65);
            this.ctrlAdres.TabIndex = 1;
            // 
            // ctrlAdi
            // 
            this.ctrlAdi.Location = new System.Drawing.Point(12, 24);
            this.ctrlAdi.Name = "ctrlAdi";
            this.ctrlAdi.Size = new System.Drawing.Size(326, 65);
            this.ctrlAdi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.ctrlTelefon);
            this.Controls.Add(this.ctrlSoyadi);
            this.Controls.Add(this.ctrlAdres);
            this.Controls.Add(this.ctrlAdi);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private InputControls ctrlAdi;
        private InputControls ctrlAdres;
        private InputControls ctrlSoyadi;
        private InputControls ctrlTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}


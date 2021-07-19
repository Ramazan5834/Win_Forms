namespace Win_TcknDogrulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKisiSayisi = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtIsimAra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(278, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 164);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            // 
            // btnKisiSayisi
            // 
            this.btnKisiSayisi.Location = new System.Drawing.Point(278, 77);
            this.btnKisiSayisi.Name = "btnKisiSayisi";
            this.btnKisiSayisi.Size = new System.Drawing.Size(100, 25);
            this.btnKisiSayisi.TabIndex = 2;
            this.btnKisiSayisi.Text = "Kişi Sayısı";
            this.btnKisiSayisi.UseVisualStyleBackColor = true;
            this.btnKisiSayisi.Click += new System.EventHandler(this.btnKisiSayisi_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(278, 284);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 25);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(81, 40);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(172, 22);
            this.txtIsim.TabIndex = 4;
            // 
            // txtIsimAra
            // 
            this.txtIsimAra.Location = new System.Drawing.Point(81, 283);
            this.txtIsimAra.Name = "txtIsimAra";
            this.txtIsimAra.Size = new System.Drawing.Size(172, 22);
            this.txtIsimAra.TabIndex = 4;
            this.txtIsimAra.TextChanged += new System.EventHandler(this.txtIsimAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.Controls.Add(this.txtIsimAra);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnKisiSayisi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKisiSayisi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtIsimAra;
    }
}


namespace Win_AtYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.atRuzgarGulu = new System.Windows.Forms.PictureBox();
            this.atPoyraz = new System.Windows.Forms.PictureBox();
            this.atYagiz = new System.Windows.Forms.PictureBox();
            this.atGolgeYele = new System.Windows.Forms.PictureBox();
            this.atAlver = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).BeginInit();
            this.SuspendLayout();
            // 
            // atRuzgarGulu
            // 
            this.atRuzgarGulu.Image = ((System.Drawing.Image)(resources.GetObject("atRuzgarGulu.Image")));
            this.atRuzgarGulu.Location = new System.Drawing.Point(32, 65);
            this.atRuzgarGulu.Name = "atRuzgarGulu";
            this.atRuzgarGulu.Size = new System.Drawing.Size(204, 128);
            this.atRuzgarGulu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atRuzgarGulu.TabIndex = 0;
            this.atRuzgarGulu.TabStop = false;
            // 
            // atPoyraz
            // 
            this.atPoyraz.Image = ((System.Drawing.Image)(resources.GetObject("atPoyraz.Image")));
            this.atPoyraz.Location = new System.Drawing.Point(32, 333);
            this.atPoyraz.Name = "atPoyraz";
            this.atPoyraz.Size = new System.Drawing.Size(204, 128);
            this.atPoyraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atPoyraz.TabIndex = 0;
            this.atPoyraz.TabStop = false;
            // 
            // atYagiz
            // 
            this.atYagiz.Image = ((System.Drawing.Image)(resources.GetObject("atYagiz.Image")));
            this.atYagiz.Location = new System.Drawing.Point(32, 199);
            this.atYagiz.Name = "atYagiz";
            this.atYagiz.Size = new System.Drawing.Size(204, 128);
            this.atYagiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atYagiz.TabIndex = 0;
            this.atYagiz.TabStop = false;
            // 
            // atGolgeYele
            // 
            this.atGolgeYele.Image = ((System.Drawing.Image)(resources.GetObject("atGolgeYele.Image")));
            this.atGolgeYele.Location = new System.Drawing.Point(32, 467);
            this.atGolgeYele.Name = "atGolgeYele";
            this.atGolgeYele.Size = new System.Drawing.Size(204, 128);
            this.atGolgeYele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atGolgeYele.TabIndex = 0;
            this.atGolgeYele.TabStop = false;
            // 
            // atAlver
            // 
            this.atAlver.Image = ((System.Drawing.Image)(resources.GetObject("atAlver.Image")));
            this.atAlver.Location = new System.Drawing.Point(32, 600);
            this.atAlver.Name = "atAlver";
            this.atAlver.Size = new System.Drawing.Size(204, 128);
            this.atAlver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atAlver.TabIndex = 0;
            this.atAlver.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(32, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(204, 47);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 716);
            this.label1.TabIndex = 2;
            this.label1.Text = "FINISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1310, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.atAlver);
            this.Controls.Add(this.atGolgeYele);
            this.Controls.Add(this.atYagiz);
            this.Controls.Add(this.atPoyraz);
            this.Controls.Add(this.atRuzgarGulu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox atRuzgarGulu;
        private System.Windows.Forms.PictureBox atPoyraz;
        private System.Windows.Forms.PictureBox atYagiz;
        private System.Windows.Forms.PictureBox atGolgeYele;
        private System.Windows.Forms.PictureBox atAlver;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}


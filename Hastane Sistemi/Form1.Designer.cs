namespace Hastane_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.labelHastaAdi = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelTeshis = new System.Windows.Forms.Label();
            this.labelIlac = new System.Windows.Forms.Label();
            this.labelTedavi = new System.Windows.Forms.Label();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxTeshis = new System.Windows.Forms.TextBox();
            this.textBoxIlac = new System.Windows.Forms.TextBox();
            this.textBoxTedavi = new System.Windows.Forms.TextBox();
            this.listBoxKayitlar = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(198, 540);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(101, 25);
            this.buttonKaydet.TabIndex = 0;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // labelHastaAdi
            // 
            this.labelHastaAdi.AutoSize = true;
            this.labelHastaAdi.Location = new System.Drawing.Point(183, 293);
            this.labelHastaAdi.Name = "labelHastaAdi";
            this.labelHastaAdi.Size = new System.Drawing.Size(66, 16);
            this.labelHastaAdi.TabIndex = 1;
            this.labelHastaAdi.Text = "Hasta Adı";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Location = new System.Drawing.Point(183, 341);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(50, 16);
            this.labelSoyadi.TabIndex = 2;
            this.labelSoyadi.Text = "Soyadı";
            // 
            // labelTeshis
            // 
            this.labelTeshis.AutoSize = true;
            this.labelTeshis.Location = new System.Drawing.Point(183, 391);
            this.labelTeshis.Name = "labelTeshis";
            this.labelTeshis.Size = new System.Drawing.Size(48, 16);
            this.labelTeshis.TabIndex = 3;
            this.labelTeshis.Text = "Teşhis";
            // 
            // labelIlac
            // 
            this.labelIlac.AutoSize = true;
            this.labelIlac.Location = new System.Drawing.Point(185, 440);
            this.labelIlac.Name = "labelIlac";
            this.labelIlac.Size = new System.Drawing.Size(28, 16);
            this.labelIlac.TabIndex = 4;
            this.labelIlac.Text = "İlaç";
            // 
            // labelTedavi
            // 
            this.labelTedavi.AutoSize = true;
            this.labelTedavi.Location = new System.Drawing.Point(183, 488);
            this.labelTedavi.Name = "labelTedavi";
            this.labelTedavi.Size = new System.Drawing.Size(50, 16);
            this.labelTedavi.TabIndex = 5;
            this.labelTedavi.Text = "Tedavi";
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Location = new System.Drawing.Point(291, 290);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(138, 22);
            this.textBoxHastaAdi.TabIndex = 6;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(291, 335);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(138, 22);
            this.textBoxSoyadi.TabIndex = 7;
            // 
            // textBoxTeshis
            // 
            this.textBoxTeshis.Location = new System.Drawing.Point(291, 385);
            this.textBoxTeshis.Name = "textBoxTeshis";
            this.textBoxTeshis.Size = new System.Drawing.Size(138, 22);
            this.textBoxTeshis.TabIndex = 8;
            // 
            // textBoxIlac
            // 
            this.textBoxIlac.Location = new System.Drawing.Point(291, 434);
            this.textBoxIlac.Name = "textBoxIlac";
            this.textBoxIlac.Size = new System.Drawing.Size(138, 22);
            this.textBoxIlac.TabIndex = 9;
            // 
            // textBoxTedavi
            // 
            this.textBoxTedavi.Location = new System.Drawing.Point(291, 482);
            this.textBoxTedavi.Name = "textBoxTedavi";
            this.textBoxTedavi.Size = new System.Drawing.Size(138, 22);
            this.textBoxTedavi.TabIndex = 10;
            // 
            // listBoxKayitlar
            // 
            this.listBoxKayitlar.FormattingEnabled = true;
            this.listBoxKayitlar.ItemHeight = 16;
            this.listBoxKayitlar.Location = new System.Drawing.Point(539, 313);
            this.listBoxKayitlar.Name = "listBoxKayitlar";
            this.listBoxKayitlar.Size = new System.Drawing.Size(319, 180);
            this.listBoxKayitlar.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(316, 540);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(101, 25);
            this.buttonTemizle.TabIndex = 13;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 583);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxKayitlar);
            this.Controls.Add(this.textBoxTedavi);
            this.Controls.Add(this.textBoxIlac);
            this.Controls.Add(this.textBoxTeshis);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.textBoxHastaAdi);
            this.Controls.Add(this.labelTedavi);
            this.Controls.Add(this.labelIlac);
            this.Controls.Add(this.labelTeshis);
            this.Controls.Add(this.labelSoyadi);
            this.Controls.Add(this.labelHastaAdi);
            this.Controls.Add(this.buttonKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label labelHastaAdi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelTeshis;
        private System.Windows.Forms.Label labelIlac;
        private System.Windows.Forms.Label labelTedavi;
        private System.Windows.Forms.TextBox textBoxHastaAdi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxTeshis;
        private System.Windows.Forms.TextBox textBoxIlac;
        private System.Windows.Forms.TextBox textBoxTedavi;
        private System.Windows.Forms.ListBox listBoxKayitlar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTemizle;
    }
}


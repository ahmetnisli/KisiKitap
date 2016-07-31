namespace KisiKitap
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
            this.cmbKisiler = new System.Windows.Forms.ComboBox();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.chkKitapVarMi = new System.Windows.Forms.CheckBox();
            this.numKitapFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtKitapKategori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.txtKisiSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKisiEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKisiTelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKitapFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKisiler
            // 
            this.cmbKisiler.AccessibleName = "";
            this.cmbKisiler.FormattingEnabled = true;
            this.cmbKisiler.Location = new System.Drawing.Point(99, 22);
            this.cmbKisiler.Name = "cmbKisiler";
            this.cmbKisiler.Size = new System.Drawing.Size(176, 24);
            this.cmbKisiler.TabIndex = 0;
            this.cmbKisiler.SelectedIndexChanged += new System.EventHandler(this.cmbKisiler_SelectedIndexChanged);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(99, 62);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(176, 292);
            this.lstKitaplar.TabIndex = 1;
            this.lstKitaplar.SelectedIndexChanged += new System.EventHandler(this.lstKitaplar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kisiler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitaplar :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapSil);
            this.groupBox1.Controls.Add(this.btnKitapGuncelle);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.chkKitapVarMi);
            this.groupBox1.Controls.Add(this.numKitapFiyat);
            this.groupBox1.Controls.Add(this.txtKitapKategori);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKitapYazar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(306, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(168, 248);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(75, 23);
            this.btnKitapSil.TabIndex = 7;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(87, 248);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapGuncelle.TabIndex = 6;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(6, 248);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 5;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // chkKitapVarMi
            // 
            this.chkKitapVarMi.AutoSize = true;
            this.chkKitapVarMi.Location = new System.Drawing.Point(23, 189);
            this.chkKitapVarMi.Name = "chkKitapVarMi";
            this.chkKitapVarMi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkKitapVarMi.Size = new System.Drawing.Size(66, 21);
            this.chkKitapVarMi.TabIndex = 4;
            this.chkKitapVarMi.Text = "VarMı";
            this.chkKitapVarMi.UseVisualStyleBackColor = true;
            // 
            // numKitapFiyat
            // 
            this.numKitapFiyat.Location = new System.Drawing.Point(80, 147);
            this.numKitapFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numKitapFiyat.Name = "numKitapFiyat";
            this.numKitapFiyat.Size = new System.Drawing.Size(150, 22);
            this.numKitapFiyat.TabIndex = 3;
            // 
            // txtKitapKategori
            // 
            this.txtKitapKategori.Location = new System.Drawing.Point(82, 108);
            this.txtKitapKategori.Name = "txtKitapKategori";
            this.txtKitapKategori.Size = new System.Drawing.Size(148, 22);
            this.txtKitapKategori.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori :";
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(82, 68);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(148, 22);
            this.txtKitapYazar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yazar :";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(84, 27);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(148, 22);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Adi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kisi Adi :";
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(715, 46);
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(148, 22);
            this.txtKisiAd.TabIndex = 0;
            // 
            // txtKisiSoyad
            // 
            this.txtKisiSoyad.Location = new System.Drawing.Point(715, 88);
            this.txtKisiSoyad.Name = "txtKisiSoyad";
            this.txtKisiSoyad.Size = new System.Drawing.Size(148, 22);
            this.txtKisiSoyad.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kisi Soyadi :";
            // 
            // txtKisiEmail
            // 
            this.txtKisiEmail.Location = new System.Drawing.Point(715, 128);
            this.txtKisiEmail.Name = "txtKisiEmail";
            this.txtKisiEmail.Size = new System.Drawing.Size(148, 22);
            this.txtKisiEmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kisi Mail :";
            // 
            // txtKisiTelefon
            // 
            this.txtKisiTelefon.Location = new System.Drawing.Point(715, 166);
            this.txtKisiTelefon.Name = "txtKisiTelefon";
            this.txtKisiTelefon.Size = new System.Drawing.Size(148, 22);
            this.txtKisiTelefon.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kisi Telefon :";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(788, 209);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 4;
            this.btnKisiEkle.Text = "Kisi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(617, 249);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(246, 73);
            this.txtMail.TabIndex = 5;
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.Location = new System.Drawing.Point(733, 330);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(130, 23);
            this.btnMailGonder.TabIndex = 6;
            this.btnMailGonder.Text = "Mail Gönder";
            this.btnMailGonder.UseVisualStyleBackColor = true;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(617, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Mail Mesajı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 392);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.cmbKisiler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKisiTelefon);
            this.Controls.Add(this.txtKisiEmail);
            this.Controls.Add(this.txtKisiSoyad);
            this.Controls.Add(this.txtKisiAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKitapFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKisiler;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.CheckBox chkKitapVarMi;
        private System.Windows.Forms.NumericUpDown numKitapFiyat;
        private System.Windows.Forms.TextBox txtKitapKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKisiEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKisiTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.Label label11;
    }
}


namespace PL.Hotel
{
    partial class frmOdemeEkranı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTariheGore = new System.Windows.Forms.RadioButton();
            this.rbAdagore = new System.Windows.Forms.RadioButton();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.gbMüsteriBilgileri = new System.Windows.Forms.GroupBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtOdenenPara = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMüsteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rbTariheGore);
            this.panel1.Controls.Add(this.rbAdagore);
            this.panel1.Controls.Add(this.btnSorgula);
            this.panel1.Controls.Add(this.txtTcKimlikNo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbMüsteriBilgileri);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnOdemeYap);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.btnTC);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbIslemTurleri);
            this.panel1.Controls.Add(this.txtPara);
            this.panel1.Controls.Add(this.txtOdenenPara);
            this.panel1.Controls.Add(this.txtBakiye);
            this.panel1.Controls.Add(this.dgvPayments);
            this.panel1.Controls.Add(this.txtKasaTuru);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 413);
            this.panel1.TabIndex = 2;
            // 
            // rbTariheGore
            // 
            this.rbTariheGore.AutoSize = true;
            this.rbTariheGore.Location = new System.Drawing.Point(540, 14);
            this.rbTariheGore.Name = "rbTariheGore";
            this.rbTariheGore.Size = new System.Drawing.Size(81, 17);
            this.rbTariheGore.TabIndex = 105;
            this.rbTariheGore.TabStop = true;
            this.rbTariheGore.Text = "Tarihe Göre";
            this.rbTariheGore.UseVisualStyleBackColor = true;
            // 
            // rbAdagore
            // 
            this.rbAdagore.AutoSize = true;
            this.rbAdagore.Location = new System.Drawing.Point(6, 245);
            this.rbAdagore.Name = "rbAdagore";
            this.rbAdagore.Size = new System.Drawing.Size(73, 17);
            this.rbAdagore.TabIndex = 104;
            this.rbAdagore.TabStop = true;
            this.rbAdagore.Text = "Misafir Adı";
            this.rbAdagore.UseVisualStyleBackColor = true;
            this.rbAdagore.CheckedChanged += new System.EventHandler(this.rbAdagore_CheckedChanged);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(820, 198);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 22);
            this.btnSorgula.TabIndex = 103;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(85, 244);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(161, 20);
            this.txtTcKimlikNo.TabIndex = 102;
            this.txtTcKimlikNo.TextChanged += new System.EventHandler(this.txtTcKimlikNo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBorc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtKazanc);
            this.groupBox1.Controls.Add(this.txtKalanBorc);
            this.groupBox1.Location = new System.Drawing.Point(634, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 122);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(70, 29);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(90, 20);
            this.txtBorc.TabIndex = 69;
            this.txtBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Borç";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "Kalan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Ödenen";
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(70, 54);
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.ReadOnly = true;
            this.txtKazanc.Size = new System.Drawing.Size(90, 20);
            this.txtKazanc.TabIndex = 85;
            this.txtKazanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Location = new System.Drawing.Point(70, 80);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.ReadOnly = true;
            this.txtKalanBorc.Size = new System.Drawing.Size(90, 20);
            this.txtKalanBorc.TabIndex = 70;
            this.txtKalanBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbMüsteriBilgileri
            // 
            this.gbMüsteriBilgileri.Controls.Add(this.txtOdaNo);
            this.gbMüsteriBilgileri.Controls.Add(this.label15);
            this.gbMüsteriBilgileri.Controls.Add(this.label17);
            this.gbMüsteriBilgileri.Controls.Add(this.txtAdi);
            this.gbMüsteriBilgileri.Controls.Add(this.txtSoyadi);
            this.gbMüsteriBilgileri.Controls.Add(this.label16);
            this.gbMüsteriBilgileri.Location = new System.Drawing.Point(366, 249);
            this.gbMüsteriBilgileri.Name = "gbMüsteriBilgileri";
            this.gbMüsteriBilgileri.Size = new System.Drawing.Size(254, 123);
            this.gbMüsteriBilgileri.TabIndex = 98;
            this.gbMüsteriBilgileri.TabStop = false;
            this.gbMüsteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(96, 83);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.ReadOnly = true;
            this.txtOdaNo.Size = new System.Drawing.Size(140, 20);
            this.txtOdaNo.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 83);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 96;
            this.label17.Text = "Oda No:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(96, 27);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(140, 20);
            this.txtAdi.TabIndex = 93;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(96, 55);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(140, 20);
            this.txtSoyadi.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "Soyadı";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(482, 215);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(123, 20);
            this.txtAciklama.TabIndex = 88;
            this.txtAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Açıklama";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(655, 203);
            this.btnOdemeYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(65, 42);
            this.btnOdemeYap.TabIndex = 86;
            this.btnOdemeYap.Text = "Ödeme Onay";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(295, 323);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(56, 22);
            this.btnGetir.TabIndex = 84;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnTC
            // 
            this.btnTC.Location = new System.Drawing.Point(145, 324);
            this.btnTC.Margin = new System.Windows.Forms.Padding(2);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(140, 20);
            this.btnTC.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 330);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "TC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Otel Kasa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Para Brm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ödenen Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "İşlem Türü";
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Konaklama Ücreti",
            "Tahsilat",
            "Ekstra Ücreti"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(85, 17);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(99, 21);
            this.cbIslemTurleri.TabIndex = 75;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(411, 215);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(50, 20);
            this.txtPara.TabIndex = 74;
            this.txtPara.Text = "TL";
            this.txtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOdenenPara
            // 
            this.txtOdenenPara.Location = new System.Drawing.Point(306, 217);
            this.txtOdenenPara.Name = "txtOdenenPara";
            this.txtOdenenPara.Size = new System.Drawing.Size(90, 20);
            this.txtOdenenPara.TabIndex = 73;
            this.txtOdenenPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(619, 393);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(72, 20);
            this.txtBakiye.TabIndex = 72;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(85, 43);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(741, 144);
            this.dgvPayments.TabIndex = 68;
            this.dgvPayments.DoubleClick += new System.EventHandler(this.dgvPayments_DoubleClick);
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.Location = new System.Drawing.Point(145, 285);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(146, 20);
            this.txtKasaTuru.TabIndex = 67;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kasa Türü";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(634, 14);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(146, 20);
            this.dtpTarih.TabIndex = 65;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "TCKimlikNo";
            // 
            // frmOdemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOdemeEkranı";
            this.Text = "frmOdemeEkranı";
            this.Load += new System.EventHandler(this.frmOdemeEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMüsteriBilgileri.ResumeLayout(false);
            this.gbMüsteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox btnTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtOdenenPara;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMüsteriBilgileri;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.RadioButton rbAdagore;
        private System.Windows.Forms.RadioButton rbTariheGore;
    }
}
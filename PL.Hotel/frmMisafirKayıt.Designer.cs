﻿namespace PL.Hotel
{
    partial class frmMisafirKayıt
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
            this.btnOnay = new System.Windows.Forms.Button();
            this.dgwMisafirListesi = new System.Windows.Forms.DataGridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.gbMisafirKonaklama = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbMisafirBilgi = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMisafirAdi = new System.Windows.Forms.TextBox();
            this.txtMisafirSoyadi = new System.Windows.Forms.TextBox();
            this.txtMisafirTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbMisafirCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpMisafirDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisafirListesi)).BeginInit();
            this.gbMisafirKonaklama.SuspendLayout();
            this.gbMisafirBilgi.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(834, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Misafir Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.Location = new System.Drawing.Point(668, 447);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(109, 40);
            this.btnOnay.TabIndex = 50;
            this.btnOnay.Text = "ONAYLA";
            this.btnOnay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgwMisafirListesi
            // 
            this.dgwMisafirListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMisafirListesi.Location = new System.Drawing.Point(20, 426);
            this.dgwMisafirListesi.Name = "dgwMisafirListesi";
            this.dgwMisafirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMisafirListesi.Size = new System.Drawing.Size(577, 112);
            this.dgwMisafirListesi.TabIndex = 49;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Transparent;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(668, 491);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(109, 40);
            this.btnIptal.TabIndex = 48;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // gbMisafirKonaklama
            // 
            this.gbMisafirKonaklama.Controls.Add(this.textBox3);
            this.gbMisafirKonaklama.Controls.Add(this.label9);
            this.gbMisafirKonaklama.Controls.Add(this.label12);
            this.gbMisafirKonaklama.Controls.Add(this.dateTimePicker1);
            this.gbMisafirKonaklama.Controls.Add(this.txtOdaNo);
            this.gbMisafirKonaklama.Controls.Add(this.label10);
            this.gbMisafirKonaklama.Controls.Add(this.label11);
            this.gbMisafirKonaklama.Controls.Add(this.dateTimePicker2);
            this.gbMisafirKonaklama.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMisafirKonaklama.Location = new System.Drawing.Point(375, 82);
            this.gbMisafirKonaklama.Margin = new System.Windows.Forms.Padding(2);
            this.gbMisafirKonaklama.Name = "gbMisafirKonaklama";
            this.gbMisafirKonaklama.Padding = new System.Windows.Forms.Padding(2);
            this.gbMisafirKonaklama.Size = new System.Drawing.Size(275, 325);
            this.gbMisafirKonaklama.TabIndex = 47;
            this.gbMisafirKonaklama.TabStop = false;
            this.gbMisafirKonaklama.Text = "Konaklama Bilgileri";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(90, 123);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 100);
            this.textBox3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Giriş Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Açıklama:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdaNo.Location = new System.Drawing.Point(90, 92);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(56, 25);
            this.txtOdaNo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Çıkış Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Oda No:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // gbMisafirBilgi
            // 
            this.gbMisafirBilgi.Controls.Add(this.richTextBox1);
            this.gbMisafirBilgi.Controls.Add(this.label8);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirAdi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirSoyadi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirTC);
            this.gbMisafirBilgi.Controls.Add(this.txtTelefon);
            this.gbMisafirBilgi.Controls.Add(this.label2);
            this.gbMisafirBilgi.Controls.Add(this.label3);
            this.gbMisafirBilgi.Controls.Add(this.label4);
            this.gbMisafirBilgi.Controls.Add(this.label5);
            this.gbMisafirBilgi.Controls.Add(this.label6);
            this.gbMisafirBilgi.Controls.Add(this.label7);
            this.gbMisafirBilgi.Controls.Add(this.txtMail);
            this.gbMisafirBilgi.Controls.Add(this.cbMisafirCinsiyet);
            this.gbMisafirBilgi.Controls.Add(this.dtpMisafirDogumTarihi);
            this.gbMisafirBilgi.Controls.Add(this.label13);
            this.gbMisafirBilgi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMisafirBilgi.Location = new System.Drawing.Point(20, 82);
            this.gbMisafirBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.gbMisafirBilgi.Name = "gbMisafirBilgi";
            this.gbMisafirBilgi.Padding = new System.Windows.Forms.Padding(2);
            this.gbMisafirBilgi.Size = new System.Drawing.Size(275, 325);
            this.gbMisafirBilgi.TabIndex = 46;
            this.gbMisafirBilgi.TabStop = false;
            this.gbMisafirBilgi.Text = "Misafir Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(110, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(154, 67);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adres:";
            // 
            // txtMisafirAdi
            // 
            this.txtMisafirAdi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirAdi.Location = new System.Drawing.Point(110, 25);
            this.txtMisafirAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirAdi.Name = "txtMisafirAdi";
            this.txtMisafirAdi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirAdi.TabIndex = 0;
            // 
            // txtMisafirSoyadi
            // 
            this.txtMisafirSoyadi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirSoyadi.Location = new System.Drawing.Point(110, 57);
            this.txtMisafirSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirSoyadi.Name = "txtMisafirSoyadi";
            this.txtMisafirSoyadi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirSoyadi.TabIndex = 1;
            // 
            // txtMisafirTC
            // 
            this.txtMisafirTC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirTC.Location = new System.Drawing.Point(110, 88);
            this.txtMisafirTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirTC.Name = "txtMisafirTC";
            this.txtMisafirTC.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirTC.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(110, 120);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(122, 25);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cinsiyet:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(110, 153);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(122, 25);
            this.txtMail.TabIndex = 14;
            // 
            // cbMisafirCinsiyet
            // 
            this.cbMisafirCinsiyet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMisafirCinsiyet.FormattingEnabled = true;
            this.cbMisafirCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbMisafirCinsiyet.Location = new System.Drawing.Point(110, 185);
            this.cbMisafirCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cbMisafirCinsiyet.Name = "cbMisafirCinsiyet";
            this.cbMisafirCinsiyet.Size = new System.Drawing.Size(84, 28);
            this.cbMisafirCinsiyet.TabIndex = 15;
            // 
            // dtpMisafirDogumTarihi
            // 
            this.dtpMisafirDogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMisafirDogumTarihi.Location = new System.Drawing.Point(110, 216);
            this.dtpMisafirDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMisafirDogumTarihi.Name = "dtpMisafirDogumTarihi";
            this.dtpMisafirDogumTarihi.Size = new System.Drawing.Size(127, 25);
            this.dtpMisafirDogumTarihi.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "DoğumTarihi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(668, 404);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 40);
            this.btnEkle.TabIndex = 51;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmMisafirKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 568);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.dgwMisafirListesi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.gbMisafirKonaklama);
            this.Controls.Add(this.gbMisafirBilgi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMisafirKayıt";
            this.Text = "frmMisafirKayıt";
            this.Load += new System.EventHandler(this.frmMisafirKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisafirListesi)).EndInit();
            this.gbMisafirKonaklama.ResumeLayout(false);
            this.gbMisafirKonaklama.PerformLayout();
            this.gbMisafirBilgi.ResumeLayout(false);
            this.gbMisafirBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.DataGridView dgwMisafirListesi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.GroupBox gbMisafirKonaklama;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox gbMisafirBilgi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMisafirAdi;
        private System.Windows.Forms.TextBox txtMisafirSoyadi;
        private System.Windows.Forms.TextBox txtMisafirTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbMisafirCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpMisafirDogumTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEkle;
    }
}
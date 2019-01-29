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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtOdenenPara = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTC = new System.Windows.Forms.TextBox();
            this.dgvGuest = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1145, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(660, 564);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Otel Kasa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Para Brm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Ödenen Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "İşlem Türü";
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Taksit",
            "Check Out",
            "Ektralar"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(18, 305);
            this.cbIslemTurleri.Margin = new System.Windows.Forms.Padding(4);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(131, 24);
            this.cbIslemTurleri.TabIndex = 42;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(297, 303);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(65, 22);
            this.txtPara.TabIndex = 40;
            this.txtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOdenenPara
            // 
            this.txtOdenenPara.Location = new System.Drawing.Point(157, 305);
            this.txtOdenenPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdenenPara.Name = "txtOdenenPara";
            this.txtOdenenPara.Size = new System.Drawing.Size(119, 22);
            this.txtOdenenPara.TabIndex = 38;
            this.txtOdenenPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(749, 559);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(95, 22);
            this.txtBakiye.TabIndex = 37;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ödeme Bilgileri";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Location = new System.Drawing.Point(917, 254);
            this.txtKalanBorc.Margin = new System.Windows.Forms.Padding(4);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.ReadOnly = true;
            this.txtKalanBorc.Size = new System.Drawing.Size(119, 22);
            this.txtKalanBorc.TabIndex = 33;
            this.txtKalanBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(522, 251);
            this.txtBorc.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(119, 22);
            this.txtBorc.TabIndex = 31;
            this.txtBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(16, 357);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.Size = new System.Drawing.Size(851, 194);
            this.dgvPayments.TabIndex = 30;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHareketler_CellContentClick);
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.Location = new System.Drawing.Point(132, 137);
            this.txtKasaTuru.Margin = new System.Windows.Forms.Padding(4);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(193, 22);
            this.txtKasaTuru.TabIndex = 29;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kasa Türü";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(132, 93);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(193, 22);
            this.dtpTarih.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tarih";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "TC";
            // 
            // btnTC
            // 
            this.btnTC.Location = new System.Drawing.Point(132, 184);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(185, 22);
            this.btnTC.TabIndex = 53;
            // 
            // dgvGuest
            // 
            this.dgvGuest.AllowUserToAddRows = false;
            this.dgvGuest.AllowUserToDeleteRows = false;
            this.dgvGuest.BackgroundColor = System.Drawing.Color.White;
            this.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuest.Location = new System.Drawing.Point(455, 137);
            this.dgvGuest.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGuest.Name = "dgvGuest";
            this.dgvGuest.ReadOnly = true;
            this.dgvGuest.Size = new System.Drawing.Size(677, 69);
            this.dgvGuest.TabIndex = 54;
            this.dgvGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuest_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Müşteri Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 56;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(716, 254);
            this.txtKazanc.Margin = new System.Windows.Forms.Padding(4);
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.ReadOnly = true;
            this.txtKazanc.Size = new System.Drawing.Size(119, 22);
            this.txtKazanc.TabIndex = 57;
            this.txtKazanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKazanc.TextChanged += new System.EventHandler(this.txtKazanc_TextChanged);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(519, 305);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(121, 27);
            this.btnOdemeYap.TabIndex = 58;
            this.btnOdemeYap.Text = "Ödeme Onay";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(370, 303);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(119, 22);
            this.txtAciklama.TabIndex = 60;
            this.txtAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Borç";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(649, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 62;
            this.label13.Text = "Ödenen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(850, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "Kalan";
            // 
            // frmOdemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 607);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.txtKazanc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvGuest);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtOdenenPara);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.txtBorc);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.txtKasaTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdemeEkranı";
            this.Text = "frmOdemeEkranı";
            this.Load += new System.EventHandler(this.frmOdemeEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtOdenenPara;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox btnTC;
        private System.Windows.Forms.DataGridView dgvGuest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
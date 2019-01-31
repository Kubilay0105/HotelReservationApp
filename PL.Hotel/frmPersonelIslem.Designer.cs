namespace PL.Hotel
{
    partial class frmPersonelIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslem));
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEkle = new System.Windows.Forms.ToolStripButton();
            this.tsGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Adı";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(82, 146);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(103, 20);
            this.txtPersonelAd.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Soyadı";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(82, 172);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(103, 20);
            this.txtPersonelSoyad.TabIndex = 47;
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(222, 146);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(510, 237);
            this.dgvPersonel.TabIndex = 46;
            this.dgvPersonel.DoubleClick += new System.EventHandler(this.dgvPersonel_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(266, 120);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(103, 20);
            this.txtDate.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 43;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEkle,
            this.tsGuncelle,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(812, 100);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEkle
            // 
            this.tsEkle.AutoSize = false;
            this.tsEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.tsEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsEkle.Image")));
            this.tsEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEkle.Name = "tsEkle";
            this.tsEkle.Size = new System.Drawing.Size(120, 100);
            this.tsEkle.Text = "toolStripButton1";
            this.tsEkle.Click += new System.EventHandler(this.tsEkle_Click);
            // 
            // tsGuncelle
            // 
            this.tsGuncelle.AutoSize = false;
            this.tsGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.tsGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("tsGuncelle.Image")));
            this.tsGuncelle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuncelle.Name = "tsGuncelle";
            this.tsGuncelle.Size = new System.Drawing.Size(120, 100);
            this.tsGuncelle.Text = "toolStripButton2";
            this.tsGuncelle.Click += new System.EventHandler(this.tsGuncelle_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(120, 100);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Telefon";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(82, 198);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(103, 20);
            this.txtTel.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(82, 224);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(103, 57);
            this.txtAdres.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ünvan";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(82, 337);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(103, 20);
            this.txtUnvan.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Maaş";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(82, 363);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(103, 20);
            this.txtMaas.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "K.Parola";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(82, 313);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(103, 20);
            this.txtPasword.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "K.Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(82, 287);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(103, 20);
            this.txtUsername.TabIndex = 59;
            // 
            // frmPersonelIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelIslem";
            this.Text = "frmPersonelIslem";
            this.Load += new System.EventHandler(this.frmPersonelIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsEkle;
        public System.Windows.Forms.ToolStripButton tsGuncelle;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
    }
}
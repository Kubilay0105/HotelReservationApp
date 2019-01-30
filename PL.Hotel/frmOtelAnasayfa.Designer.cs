namespace PL.Hotel
{
    partial class frmOtelAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtelAnasayfa));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMenuAc = new System.Windows.Forms.Button();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.frmSatisIslemleri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnExtra = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.button8);
            this.pnlHeader.Controls.Add(this.button3);
            this.pnlHeader.Controls.Add(this.btnMenuAc);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(917, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(875, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 35);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(969, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMenuAc
            // 
            this.btnMenuAc.FlatAppearance.BorderSize = 0;
            this.btnMenuAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAc.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuAc.Image")));
            this.btnMenuAc.Location = new System.Drawing.Point(3, 29);
            this.btnMenuAc.Name = "btnMenuAc";
            this.btnMenuAc.Size = new System.Drawing.Size(43, 29);
            this.btnMenuAc.TabIndex = 0;
            this.btnMenuAc.UseVisualStyleBackColor = true;
            this.btnMenuAc.Click += new System.EventHandler(this.btnMenuAc_Click);
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlLeftMenu.Controls.Add(this.btnExtra);
            this.pnlLeftMenu.Controls.Add(this.button5);
            this.pnlLeftMenu.Controls.Add(this.button1);
            this.pnlLeftMenu.Controls.Add(this.btnOdalar);
            this.pnlLeftMenu.Controls.Add(this.frmSatisIslemleri);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 64);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(180, 499);
            this.pnlLeftMenu.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 166);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(180, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "   Odalar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(180, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "   Odalar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOdalar
            // 
            this.btnOdalar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdalar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdalar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdalar.Image = ((System.Drawing.Image)(resources.GetObject("btnOdalar.Image")));
            this.btnOdalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdalar.Location = new System.Drawing.Point(0, 0);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOdalar.Size = new System.Drawing.Size(180, 59);
            this.btnOdalar.TabIndex = 4;
            this.btnOdalar.Text = "   Odalar";
            this.btnOdalar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOdalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // frmSatisIslemleri
            // 
            this.frmSatisIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.frmSatisIslemleri.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.frmSatisIslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frmSatisIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.frmSatisIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmSatisIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmSatisIslemleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frmSatisIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("frmSatisIslemleri.Image")));
            this.frmSatisIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmSatisIslemleri.Location = new System.Drawing.Point(0, 55);
            this.frmSatisIslemleri.Name = "frmSatisIslemleri";
            this.frmSatisIslemleri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frmSatisIslemleri.Size = new System.Drawing.Size(180, 59);
            this.frmSatisIslemleri.TabIndex = 2;
            this.frmSatisIslemleri.Text = "   Satış İşlemleri";
            this.frmSatisIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmSatisIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.frmSatisIslemleri.UseVisualStyleBackColor = false;
            this.frmSatisIslemleri.Click += new System.EventHandler(this.frmSatisIslemleri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 563);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 37);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lblTarih);
            this.panel4.Controls.Add(this.lblSaat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(180, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 53);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(360, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(423, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "50";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(333, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "50";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(4, 8);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(142, 23);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaat
            // 
            this.lblSaat.Location = new System.Drawing.Point(152, 8);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(142, 23);
            this.lblSaat.TabIndex = 15;
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(180, 117);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(820, 446);
            this.pnlContent.TabIndex = 4;
            // 
            // btnExtra
            // 
            this.btnExtra.Location = new System.Drawing.Point(12, 189);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(75, 23);
            this.btnExtra.TabIndex = 0;
            this.btnExtra.Text = "Ekstra";
            this.btnExtra.UseVisualStyleBackColor = true;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmOtelAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLeftMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOtelAnasayfa";
            this.Text = "frmOtelAnasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOtelAnasayfa_Load);
            this.Shown += new System.EventHandler(this.frmOtelAnasayfa_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeftMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMenuAc;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button frmSatisIslemleri;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExtra;
    }
}
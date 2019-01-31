namespace PL.Hotel
{
    partial class frmAdminIslemleri
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdminIslemler = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.ekstraİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.AutoSize = false;
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelGüncelleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(170, 40);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // ekstraİşlemlerToolStripMenuItem
            // 
            this.ekstraİşlemlerToolStripMenuItem.AutoSize = false;
            this.ekstraİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekstraEkleToolStripMenuItem,
            this.ekstraGüncelleToolStripMenuItem,
            this.ekstraSilToolStripMenuItem});
            this.ekstraİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ekstraİşlemlerToolStripMenuItem.Name = "ekstraİşlemlerToolStripMenuItem";
            this.ekstraİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(170, 40);
            this.ekstraİşlemlerToolStripMenuItem.Text = "Ekstra İşlemler";
            // 
            // ekstraEkleToolStripMenuItem
            // 
            this.ekstraEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            this.ekstraEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
            this.ekstraEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraEkleToolStripMenuItem_Click);
            // 
            // ekstraGüncelleToolStripMenuItem
            // 
            this.ekstraGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraGüncelleToolStripMenuItem.Name = "ekstraGüncelleToolStripMenuItem";
            this.ekstraGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ekstraGüncelleToolStripMenuItem.Text = "Ekstra Güncelle";
            this.ekstraGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ekstraGüncelleToolStripMenuItem_Click);
            // 
            // ekstraSilToolStripMenuItem
            // 
            this.ekstraSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraSilToolStripMenuItem.Name = "ekstraSilToolStripMenuItem";
            this.ekstraSilToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ekstraSilToolStripMenuItem.Text = "Ekstra Sil";
            this.ekstraSilToolStripMenuItem.Click += new System.EventHandler(this.ekstraSilToolStripMenuItem_Click);
            // 
            // pnlAdminIslemler
            // 
            this.pnlAdminIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminIslemler.Location = new System.Drawing.Point(0, 44);
            this.pnlAdminIslemler.Name = "pnlAdminIslemler";
            this.pnlAdminIslemler.Size = new System.Drawing.Size(812, 402);
            this.pnlAdminIslemler.TabIndex = 1;
            // 
            // frmAdminIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 446);
            this.Controls.Add(this.pnlAdminIslemler);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminIslemleri";
            this.Text = "frmAdminIslemleri";
            this.Load += new System.EventHandler(this.frmAdminIslemleri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraSilToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAdminIslemler;
    }
}
namespace PL.Hotel
{
    partial class frmCheckin
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
            this.txtTcyeGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdaTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTcyeGore
            // 
            this.txtTcyeGore.Location = new System.Drawing.Point(169, 89);
            this.txtTcyeGore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcyeGore.Name = "txtTcyeGore";
            this.txtTcyeGore.Size = new System.Drawing.Size(132, 22);
            this.txtTcyeGore.TabIndex = 0;
            this.txtTcyeGore.TextChanged += new System.EventHandler(this.txtTcyeGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCKimlikNo";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(929, 511);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(100, 28);
            this.btnCheckin.TabIndex = 2;
            this.btnCheckin.Text = "Check-In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(83, 134);
            this.dgvMusteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(1104, 289);
            this.dgvMusteriler.TabIndex = 3;
            this.dgvMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellContentClick);
            this.dgvMusteriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMusteriler_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKat);
            this.groupBox1.Controls.Add(this.txtOdaTuru);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOdaNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCheckout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCheckin);
            this.groupBox1.Location = new System.Drawing.Point(83, 442);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(804, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Oda No";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(473, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bulunduğu Kat";
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(473, 63);
            this.txtKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKat.Name = "txtKat";
            this.txtKat.ReadOnly = true;
            this.txtKat.Size = new System.Drawing.Size(160, 22);
            this.txtKat.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Oda Türü";
            // 
            // txtOdaTuru
            // 
            this.txtOdaTuru.Location = new System.Drawing.Point(473, 31);
            this.txtOdaTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOdaTuru.Name = "txtOdaTuru";
            this.txtOdaTuru.ReadOnly = true;
            this.txtOdaTuru.Size = new System.Drawing.Size(160, 22);
            this.txtOdaTuru.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oda No";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(135, 95);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.ReadOnly = true;
            this.txtOdaNo.Size = new System.Drawing.Size(160, 22);
            this.txtOdaNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Check-Out Tarihi";
            // 
            // txtCheckout
            // 
            this.txtCheckout.Location = new System.Drawing.Point(135, 63);
            this.txtCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.ReadOnly = true;
            this.txtCheckout.Size = new System.Drawing.Size(160, 22);
            this.txtCheckout.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check-In Tarihi";
            // 
            // txtCheckin
            // 
            this.txtCheckin.Location = new System.Drawing.Point(135, 31);
            this.txtCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.ReadOnly = true;
            this.txtCheckin.Size = new System.Drawing.Size(160, 22);
            this.txtCheckin.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "TCKimlikNo";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(169, 25);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(132, 22);
            this.txtAdaGore.TabIndex = 5;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "TCKimlikNo";
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Location = new System.Drawing.Point(169, 57);
            this.txtSoyadaGore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(132, 22);
            this.txtSoyadaGore.TabIndex = 7;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 610);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTcyeGore);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCheckin";
            this.Text = "frmCheckin";
            this.Load += new System.EventHandler(this.frmCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcyeGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCheckin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdaTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        public System.Windows.Forms.Button btnCheckin;
        public System.Windows.Forms.DataGridView dgvMusteriler;
    }
}
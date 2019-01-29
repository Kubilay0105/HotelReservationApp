namespace PL.Hotel
{
    partial class frmExtralar
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
            this.cbEkstra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEkstra
            // 
            this.cbEkstra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEkstra.FormattingEnabled = true;
            this.cbEkstra.Location = new System.Drawing.Point(148, 92);
            this.cbEkstra.Name = "cbEkstra";
            this.cbEkstra.Size = new System.Drawing.Size(151, 21);
            this.cbEkstra.TabIndex = 0;
            this.cbEkstra.SelectedIndexChanged += new System.EventHandler(this.cbEkstra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekstralar";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(148, 159);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(30, 20);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(148, 191);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(148, 223);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(115, 20);
            this.txtDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // frmExtralar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEkstra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExtralar";
            this.Text = "frmExtralar";
            this.Load += new System.EventHandler(this.frmExtralar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEkstra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
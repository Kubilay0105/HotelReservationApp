using BLL.Hotel.Repositories;
using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Hotel
{
    public partial class frmExtraIslemler : Form
    {
        public frmExtraIslemler()
        {
            InitializeComponent();
        }
        ExtraRepository ex = new ExtraRepository();
        ExtraType ET = new ExtraType();
  
        private void frmExtraIslemler_Load(object sender, EventArgs e)
        {
            cbEkstra.DataSource = ex.GetExtraTypes();
            txtDate.Text = DateTime.Now.ToShortDateString();
           
        }

       

        private void btnAdminn_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            cbEkstra.Visible = false;
            txtPrice.Visible = false;
            txtUnit.Visible = false;
            txtSum.Visible = false;
            btnAdminn.Visible = false;
            btnOda.Visible = false;

            pnlExtraa.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlExtraa.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            frmExtraSecenek frm2 = new frmExtraSecenek();
            frm2.TopLevel = false;
            pnlExtraa.Controls.Add(frm2);
            frm2.Show();
            frm2.Dock = DockStyle.Fill;

        }

        private void txtUnit_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnit.Text))
            {
                txtSum.Text = (Convert.ToInt32(txtUnit.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
            }
            else
            {
                txtSum.Clear();
            }
        }

        private void cbEkstra_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbEkstra.SelectedIndex != -1)
            {
                txtPrice.Text = (cbEkstra.SelectedItem as ExtraType).Price.ToString();
            }

        }
    }
}

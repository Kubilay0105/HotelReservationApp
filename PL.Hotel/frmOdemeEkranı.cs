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
    public partial class frmOdemeEkranı : Form
    {
        public frmOdemeEkranı()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        private void frmOdemeEkranı_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now;
            dgvPayments.DataSource = pr.GetPayments();
            int Topla = 0;
            for (int i = 0; i < dgvPayments.Rows.Count; ++i)
            {
                Topla += Convert.ToInt32(dgvPayments.Rows[i].Cells[4].Value);
            }
            txtBakiye.Text = Topla.ToString();
        }

        private void dgvHareketler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestRepository gr = new GuestRepository();
            List<decimal> liste = pr.PaymentsToDate(dtpTarih.Value);

            dgvGuest.DataSource = gr.GetAllGuest(btnTC.Text);
            txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
            txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
            txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);

        }

        private void dgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            Payment pym = new Payment();
            SaleRepository sr = new SaleRepository();
            pym.Date = dtpTarih.Value;
            pym.TransType = cbIslemTurleri.SelectedItem.ToString();
            pym.Credit = Convert.ToDecimal(txtOdenenPara.Text);
            pym.Debt = Convert.ToDecimal(txtBorc.Text)- Convert.ToDecimal(txtOdenenPara.Text);
            pym.SalesId = sr.GetSalesId(Convert.ToInt16(dgvGuest.CurrentRow.Cells[0].Value));
            if (pym.Credit != pym.Debt) pym.Status = true;
            else pym.Status = false;
            pym.Description = txtAciklama.Text;
            pr.PaymentsAdd(pym);
            dgvPayments.DataSource = pr.GetPayments();

           
        }

        private void txtGirenToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKazanc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

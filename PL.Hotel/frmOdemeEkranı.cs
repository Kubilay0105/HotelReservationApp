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
        GuestRepository gr = new GuestRepository();
        RoomRepository Rp = new RoomRepository();
        SaleRepository sr = new SaleRepository();
        string TcKno;

        private void frmOdemeEkranı_Load(object sender, EventArgs e)
        {

            dtpTarih.Value = DateTime.Now;
            dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(),txtTcKimlikNo.Text);
            
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //List<Guest> gliste = gr.GetAllGuest(btnTC.Text);
            Payment pym = new Payment();
            pym.Date = dtpTarih.Value;
            pym.TransType = cbIslemTurleri.SelectedItem.ToString();
            pym.Credit = Convert.ToDecimal(txtOdenenPara.Text);
            pym.Debt =0;
            pym.SalesId = sr.GetSaleIdByGuest(gr.GetGuestIdByTC(TcKno));
            pym.Status = true;
            pym.Description = txtAciklama.Text;
            pr.PaymentsAdd(pym);
            dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(), dtpTarih.Value);


        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            dgvPayments.DataSource = pr.PaylistByGuestId(gr.GetGuestIdByTC(txtTcKimlikNo.Text));
            if (txtTcKimlikNo.Text != "")
            {
                //List<decimal> liste = pr.PaymentsToDate(dtpTarih.Value);
                Guest gst = gr.GetGuestByTC(txtTcKimlikNo.Text);
                txtAdi.Text = gst.FirstName;
                txtSoyadi.Text = gst.LastName;
                txtOdaNo.Text = Rp.GetRoomNo(gst.RoomId);
                List<decimal> liste = pr.PaymentTransBySalesId(sr.GetSaleIdByGuest(gst.Id));



                txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
                txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
                txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);

            }
            else
                MessageBox.Show("Eksik Bilgi Girdiniz");
        }

        private void txtTcKimlikNo_TextChanged(object sender, EventArgs e)
        {
            if (rbAdagore.Checked)
            {
                dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(), txtTcKimlikNo.Text);

            }
       }

        private void rbAdagore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (rbTariheGore.Checked)
            {
                dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(), dtpTarih.Value);

            }
        }

        private void dgvPayments_DoubleClick(object sender, EventArgs e)
        {
            TcKno = dgvPayments.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
            if (btnTC.Text != "")
            {
                //List<decimal> liste = pr.PaymentsToDate(dtpTarih.Value);
                Guest gst = gr.GetGuestByTC(btnTC.Text);
                txtAdi.Text = gst.FirstName;
                txtSoyadi.Text = gst.LastName;
                txtOdaNo.Text = Rp.GetRoomNo(gst.RoomId);

                
                //txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
                //txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
                //txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);

            }
            else
                MessageBox.Show("Eksik Bilgi Girdiniz");
        
            
        }

        private void dgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //List<Guest> gliste = gr.GetAllGuest(btnTC.Text);
            Payment pym = new Payment();
            SaleRepository sr = new SaleRepository();
            pym.Date = dtpTarih.Value;
            pym.TransType = cbIslemTurleri.SelectedItem.ToString();
            pym.Credit = Convert.ToDecimal(txtOdenenPara.Text);
            pym.Debt =0;
            //pym.SalesId = sr.GetSalesId(Convert.ToInt16(gliste[0]));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOdemeYap_Click_1(object sender, EventArgs e)
        {

        }
    }
}

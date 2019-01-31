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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        SaleRepository sr = new SaleRepository();
        GuestRepository Gr = new GuestRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        RoomRepository Rr = new RoomRepository();
        int SId, GId, RId;


        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            dgvRezervasyon.DataSource = sr.GetSales(dtpGiris.Value);
            

        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            dgvRezervasyon.DataSource = sr.GetSales(dtpGiris.Value);
        }

        private void dgvRezervasyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            if (Gr.UpdateGuestStatusForCheckin(GId))
            {
                if (sr.UpdateSaleStatusForCheckin(SId))
                {
                    if (Pr.UpdatePaymentStatusForCheckin(SId))
                    {
                        MessageBox.Show("Checkin işlemi tamamlandı.");
                    }
                    else MessageBox.Show("Payment update olmadı");
                }
                else MessageBox.Show("Sale update olmadı");
            }
            else MessageBox.Show("Guest update olmadı");


        }

        private void dgvRezervasyon_DoubleClick(object sender, EventArgs e)
        {
            GId = Convert.ToInt32(dgvRezervasyon.CurrentRow.Cells[1].Value.ToString());
            SId = sr.GetSaleIdByGuest(GId);
            RId = sr.GetRoomIdBySalesId(SId);

            Sale SBilgileri = sr.GetSaleById(SId);
            txtCheckin.Text = dtpGiris.Value.ToShortDateString();
            txtCheckout.Text = SBilgileri.CheckOut.ToShortDateString();
            Room RBilgileri = Rr.GetRoom(RId);
            txtOdaNo.Text = RBilgileri.RoomNumber;
            txtKat.Text = RBilgileri.FloorNumber.ToString();

        }
    }
}

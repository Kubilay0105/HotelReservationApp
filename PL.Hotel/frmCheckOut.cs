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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        GuestRepository gr = new GuestRepository();
        SaleRepository sr = new SaleRepository();
        RoomRepository rr = new RoomRepository();

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnBorcSorgula_Click(object sender, EventArgs e)
        {

            List<Decimal> pay=pr.PaymentTransBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
            if (!string.IsNullOrEmpty(txtTKCNO.Text))
            {
                txtBorc.Text = pay[0].ToString();
                txtKazanc.Text = pay[1].ToString();
                txtKalanBorc.Text = pay[2].ToString();
            }
            else
                MessageBox.Show("Eksik Bilgi Girdiniz");
           

        }

        private void btnCikisOnayla_Click(object sender, EventArgs e)
        {
            if (txtKalanBorc.Text == "0")
            {
                gr.UpdateGuestByTC(txtTKCNO.Text);
                rr.UpdateRoomByRoomNo(txtOdaNo.Text);
                pr.UpdatePaymentBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
                sr.UpdateSalesByGuestId(gr.GetGuestIdByTC(txtTKCNO.Text));

                MessageBox.Show("Çıkış işlemi tamamlandı");

            }
            else
                MessageBox.Show("Sistemde kayıtlı borç görünmekte");
        }
    }
}

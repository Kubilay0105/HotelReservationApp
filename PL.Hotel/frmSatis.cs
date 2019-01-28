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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        RoomRepository Rp = new RoomRepository();
        SaleRepository Sp = new SaleRepository();
        GuestRepository Gp = new GuestRepository();
        PaymentRepository Pp = new PaymentRepository();
        public static DateTime Giris { get; set; }
        public static DateTime Cikis { get; set; }
        public static string OdaNo { get; set; }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Guest gue = new Guest();
            gue.FirstName = txtAdi.Text;
            gue.LastName = txtSoyadi.Text;
            gue.IdentificationNo = txtTc.Text;
            gue.RoomId = Rp.GetRoomId(OdaNo);
            gue.Adress = txtAdres.Text;
            gue.Gender = cbCinsiyet.SelectedText;
            gue.Birthday = dtpDogumTarihi.Value;
            gue.ContactNo = txtTelefon.Text;
            gue.Email = txtEmail.Text;
            gue.Status = true;
            Gp.AddGuest(gue);

            Sale sa = new Sale();
            sa.RoomId = Rp.GetRoomId(OdaNo);
            sa.CheckIn = Giris;
            sa.CheckOut = Cikis;
            sa.NoOfGuests = 1;
            sa.TotalPrice = Convert.ToDecimal(txtToplamTutar.Text);
            sa.PersonnelId = General.PersonelId;
            sa.GuestId = Gp.GetGuestIdByTC(txtTc.Text);
            sa.Status = true;
            Sp.AddSales(sa);

            Payment pay = new Payment();
            pay.Date = DateTime.Now;
            pay.TransType = "Konaklama Ücreti";
            pay.Debt = Convert.ToDecimal(txtToplamTutar.Text);
            pay.Credit = 0;
            pay.SalesId = Sp.GetSaleIdByGuest(sa.GuestId);
            pay.Status = true;
            pay.Description = "Konaklama Açılış";
            Pp.AddPayment(pay);
            MessageBox.Show("Kayıt yapıldı");
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            frmOdaSec frm = new frmOdaSec();
            frm.ShowDialog();
            txtOdaNo.Text = OdaNo;
            txtGirisTarihi.Text = Giris.ToShortDateString();
            txtCikisTarihi.Text = Cikis.ToShortDateString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            TimeSpan fark = Cikis - Giris;
            int gunsayisi = fark.Days;
            decimal OdaFiyat=Rp.GetRoomPrice(OdaNo);
            txtToplamTutar.Text = ((gunsayisi + 1) * OdaFiyat).ToString();
        }
    }
}

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
        DateTime Giris, Cikis;
        RoomRepository Rp = new RoomRepository();
        SaleRepository Sp = new SaleRepository();
        GuestRepository Gp = new GuestRepository();

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Guest gue = new Guest();
            gue.FirstName = txtAdi.Text;
            gue.LastName = txtSoyadi.Text;
            gue.IdentificationNo = txtTc.Text;
            gue.RoomId = Rp.GetRoomId(txtOdaNo.Text);
            gue.Adress = txtAdres.Text;
            gue.Gender = cbCinsiyet.SelectedText;
            gue.Birthday = dtpDogumTarihi.Value;
            gue.ContactNo = txtTelefon.Text;
            gue.Email = txtEmail.Text;
            gue.Status = true;
            Gp.AddGuest(gue);

            Sale sa = new Sale();
            sa.RoomId = Rp.GetRoomId(txtOdaNo.Text);
            sa.CheckIn = dtpGirisTarihi.Value;
            sa.CheckOut = dtpCikisTarihi.Value;
            sa.NoOfGuests = Convert.ToInt32(cbMisafirSayisi.SelectedText);
            sa.TotalPrice = Convert.ToDecimal(txtToplamTutar.Text);
            sa.PersonnelId = General.PersonelId;
            sa.Status = true;
            Sp.AddSales(sa);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Giris = dtpGirisTarihi.Value;
            Cikis = dtpCikisTarihi.Value;
            TimeSpan fark = Cikis - Giris;
            int gunsayisi = fark.Days;
            decimal OdaFiyat=Rp.GetRoomPrice(txtOdaNo.Text);
            txtToplamTutar.Text = ((gunsayisi + 1) * OdaFiyat).ToString();
        }
    }
}

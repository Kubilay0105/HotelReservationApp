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
    public partial class frmMisafirKayıt : Form
    {
        public frmMisafirKayıt()
        {
            InitializeComponent();
        }
        GuestRepository gr = new GuestRepository();
        Guest g = new Guest();
        RoomRepository r = new RoomRepository();
        SaleRepository sr = new SaleRepository();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            g.FirstName = txtMisafirAdi.Text;
            g.LastName = txtMisafirSoyadi.Text;
            g.IdentificationNo = txtMisafirTC.Text;
            g.ContactNo = txtTelefon.Text;
            g.Birthday = dtpMisafirDogumTarihi.Value;
            g.Gender =(dateTimePicker1.Value - dtpMisafirDogumTarihi.Value).ToString();
            g.Adress = richTextBox1.Text;
            g.Email = txtMail.Text;
            g.Status = true;
            g.RoomId = r.GetRoomId(txtOdaNo.Text);
            gr.AddGuest(g);
            dgwMisafirListesi.DataSource =gr.GetAllGuest();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sr.UpdateSales(sr.GetSaleIdByByRoomId(r.GetRoomId(txtOdaNo.Text)), dgwMisafirListesi.RowCount);
        }
    }
}

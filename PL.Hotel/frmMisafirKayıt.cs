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
            if (txtMisafirAdi.Text.Trim() != "" && txtMisafirSoyadi.Text.Trim() != "" && txtMisafirTC.Text.Trim() != "" && txtOdaNo.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                g.FirstName = txtMisafirAdi.Text;
                g.LastName = txtMisafirSoyadi.Text;
                g.IdentificationNo = txtMisafirTC.Text;
                g.ContactNo = txtTelefon.Text;
                g.Birthday = dtpMisafirDogumTarihi.Value;
                g.Gender = cbMisafirCinsiyet.SelectedItem.ToString();
                g.Adress = richTextBox1.Text;
                g.Email = txtMail.Text;
                g.Status = true;
                g.RoomId = r.GetRoomId(txtOdaNo.Text);
                gr.AddGuest(g);
                dgwMisafirListesi.DataSource = gr.GetGuestByRoomId(g.RoomId);
                this.dgwMisafirListesi.Columns["Id"].Visible = false;
                this.dgwMisafirListesi.Columns["RoomId"].Visible = false;
                this.dgwMisafirListesi.Columns["Email"].Visible = false;
            }
            else
                MessageBox.Show("Eksik Bilgi Girdiniz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int NOG = gr.NOG(g.RoomId);
            sr.UpdateSalesNOGByRoomId(g.RoomId, NOG);
        }
        
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMisafirKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

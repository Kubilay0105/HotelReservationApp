using BLL.Hotel.Repositories;
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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }
        GuestRepository gr = new GuestRepository();
        
        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            cbTum.Checked = true;
            if (cbTum.Checked) dgwMisafir.DataSource=gr.GetAllGuest();
            if (cbAktif.Checked) dgwMisafir.DataSource = gr.GetAllGuestByStatus();

            this.dgwMisafir.Columns["Id"].Visible = false;
            this.dgwMisafir.Columns["RoomId"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          dgwMisafir.DataSource= gr.GetGuestByName(txtName.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgwMisafir.DataSource = gr.GetGuestByLastName(txtLastName.Text);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            dgwMisafir.DataSource = gr.GetGuestByTCkno(txtTC.Text);
        }
    }
}

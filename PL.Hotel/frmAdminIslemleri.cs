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
    public partial class frmAdminIslemleri : Form
    {
        public frmAdminIslemleri()
        {
            InitializeComponent();
        }

        private void frmAdminIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdminIslemler.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.toolStripButton3.Enabled = false;


        }

        private void ekstraGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdminIslemler.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.toolStripButton3.Enabled = false;
        }

        private void ekstraSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdminIslemler.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.tsGuncelle.Enabled = false;
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnlAdminIslemler.Controls.Clear();
            frmPersonelIslem frm = new frmPersonelIslem();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.toolStripButton3.Enabled = false;
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdminIslemler.Controls.Clear();
            frmPersonelIslem frm = new frmPersonelIslem();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.toolStripButton3.Enabled = false;
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdminIslemler.Controls.Clear();
            frmPersonelIslem frm = new frmPersonelIslem();
            frm.TopLevel = false;
            pnlAdminIslemler.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.tsGuncelle.Enabled = false;
        }
        //}
    }
}

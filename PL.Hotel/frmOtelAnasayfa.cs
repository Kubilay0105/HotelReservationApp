﻿using BLL.Hotel.Repositories;
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
    public partial class frmOtelAnasayfa : Form
    {
        public frmOtelAnasayfa()
        {
            InitializeComponent();
        }
        RoomRepository Rp = new RoomRepository();


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLeftMenu.Width = pnlLeftMenu.Width + 10;
            if (pnlLeftMenu.Width == 180)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pnlLeftMenu.Width = pnlLeftMenu.Width - 10;
            if (pnlLeftMenu.Width == 50)
            {
                timer2.Stop();
            }
        }

        private void btnMenuAc_Click(object sender, EventArgs e)
        {
            if (pnlLeftMenu.Width == 180)
            {
                timer2.Start();
            }
            else { timer1.Start(); }
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar frm = new frmOdalar();
            FormAc(frm);
        }

        private void frmOtelAnasayfa_Load(object sender, EventArgs e)
        {
            //timer3.Start();
            //lblTarih.Text = DateTime.Now.Date.ToShortDateString() + DateTime.Today.DayOfWeek.ToString();
            
            lblDoluOda.Text = Rp.FullRoomsCount().ToString();
            lblBosOda.Text = (30 - Rp.FullRoomsCount()).ToString();
        }

        private void frmOtelAnasayfa_Shown(object sender, EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //string saat = DateTime.Now.ToLongTimeString();

            //lblSaat.Text = saat;
        }

        private void frmSatisIslemleri_Click(object sender, EventArgs e)
        {
            frmSatis frm = new frmSatis();
            FormAc(frm);
        }

        private void btnOdalar_MouseHover(object sender, EventArgs e)
        {
            btnIcon1.FlatAppearance.MouseOverBackColor = Color.Red;
        }

        private void BtnIcon1_MouseHover(object sender, EventArgs e)
        {
            btnIcon1.FlatAppearance.MouseOverBackColor = Color.Red;
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            frmOdemeEkranı frm = new frmOdemeEkranı();
            FormAc(frm);
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            frmExtraIslemler frm = new frmExtraIslemler();
            FormAc(frm);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            FormAc(frm);
        }

      
    }
}

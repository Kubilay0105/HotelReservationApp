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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        SaleRepository sr = new SaleRepository();
        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            dgvRezervasyon.DataSource = sr.GetSales(dtpGiris.Value);

        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            dgvRezervasyon.DataSource = sr.GetSales(dtpGiris.Value);
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

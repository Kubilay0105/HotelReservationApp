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
    public partial class frmExtralar : Form
    {
        public frmExtralar()
        {
            InitializeComponent();
        }
        ExtraRepository ex = new ExtraRepository();
        ExtraType ET = new ExtraType();
        int ID;
        private void cbEkstra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEkstra.SelectedIndex != -1)
            {
                txtPrice.Text = (cbEkstra.SelectedItem as ExtraType).Price.ToString();
            }

        }

        private void frmExtralar_Load(object sender, EventArgs e)
        {
            cbEkstra.DataSource = ex.GetExtraTypes();
        }
    }
}

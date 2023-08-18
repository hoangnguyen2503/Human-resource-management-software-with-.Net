using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmdangki : Form
    {
        public frmdangki()
        {
            InitializeComponent();
        }

        private void btNhaplai_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
            txtHoTen.Text = "";
            dtNgaysinh.Text = "";
            cbQuyen.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

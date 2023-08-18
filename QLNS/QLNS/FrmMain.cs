using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region set quyền
        private string quyen;

        public string getQuyen()
        {
            return quyen;
        }

        public void setQuyen(string q)
        {
            this.quyen = q;
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                danhMụcToolStripMenuItem.Enabled = true;
                chứcNăngToolStripMenuItem.Enabled = true;
                quảnLýToolStripMenuItem.Enabled = true;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
            }
            else if (quyen == "user")
            {
                danhMụcToolStripMenuItem.Enabled = true;
                chứcNăngToolStripMenuItem.Enabled = true;
                quảnLýToolStripMenuItem.Enabled = true;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangnhap form_dangnhap = new frmdangnhap();
            form_dangnhap.Show();
            this.Hide();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangki form_dangki = new frmdangki();
            pnlHienThi.Controls.Clear();
            form_dangki.TopLevel = false;
            form_dangki.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Add(form_dangki);
            form_dangki.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoimatkhau form_doimatkhau = new frmdoimatkhau();
            pnlHienThi.Controls.Clear();
            form_doimatkhau.TopLevel = false;
            pnlHienThi.Controls.Add(form_doimatkhau);
            form_doimatkhau.Dock = DockStyle.Fill;
            form_doimatkhau.Show();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcoban form_coban = new frmcoban();
            pnlHienThi.Controls.Clear();
            form_coban.TopLevel = false;
            pnlHienThi.Controls.Add(form_coban);
            form_coban.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

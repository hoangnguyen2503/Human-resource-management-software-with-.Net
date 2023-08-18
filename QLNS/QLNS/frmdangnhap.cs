using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra người dùng điền thông tin đăng nhập
                if (txtTenDN.Text != null && txtTenDN.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin Tên đăng nhập", "Thông báo");
                    txtTenDN.Focus();
                    return;
                }

                if (txtMK.Text != null && txtMK.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin Mật khẩu", "Thông báo");
                    txtMK.Focus();
                    return;
                }

                //Kiểm tra thông tin tài khoản
                string sql_admin = "select * from tbuser where Username = '" + txtTenDN.Text + "' and Pass = '" + txtMK.Text + "' and Quyen = 'Admin'";
                string sql_user = "select * from tbuser where Username = '" + txtTenDN.Text + "' and Pass = '" + txtMK.Text + "' and Quyen = 'User'";
                
                if (Clsdatabase.Sosanh(sql_admin) == true)
                {
                    FrmMain _formMain = new FrmMain();
                    MessageBox.Show("Đăng nhập với quyền Admin","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None) ;
                    _formMain.setQuyen("Admin");
                    _formMain.Show();
                    this.Close();
                }
                else
                {
                    if (Clsdatabase.Sosanh(sql_user) == true)
                    {
                        FrmMain _formMain = new FrmMain();
                        MessageBox.Show("Đăng nhập với quyền User", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        _formMain.setQuyen("User");
                        _formMain.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thông tin tài khoản hoặc mật khẩu chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không kết nối được SQL!!!", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

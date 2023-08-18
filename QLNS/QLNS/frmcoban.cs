using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using DevComponents.DotNetBar.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;


namespace QLNS
{
    public partial class frmcoban : Form
    {
        public frmcoban()
        {
            InitializeComponent();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is System.Windows.Forms.ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblTTNVCoBan values(N'" + txtMBP.Text + "', '" + txtMP.Text + "', '" + txtMNV.Text + "'," +
                "'" + txtHoten.Text + "', " + txtMaLuong.Text + "," +
                ""+dtNgaysinh.Text+",'"+cbGioitinh.Text+"'," +
                "'"+txtHonnhan.Text+"','"+txtCMTND.Text+"'," +
                "'"+txtNoicap.Text+"','"+txtChucvu.Text+"'," +
                "'"+txtHD.Text+"','"+txtThoigian.Text+"'," +
                "'"+dtNgayky.Text+"','"+dtNgayhethan.Text+"','"+txtGhichu.Text+"')";
            Clsdatabase.Bang(sql);
            dgvNhansu.DataSource = Clsdatabase.Bang("select * from tblTTNVCoBan");
            MessageBox.Show("Đã thêm bản ghi!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblTTNVCoBan values(N'" + txtMBP.Text + "', '" + txtMP.Text + "', '" + txtMNV.Text + "'," +
                "'" + txtHoten.Text + "', " + txtMaLuong.Text + "," +
                "" + dtNgaysinh.Text + ",'" + cbGioitinh.Text + "'," +
                "'" + txtHonnhan.Text + "','" + txtCMTND.Text + "'," +
                "'" + txtNoicap.Text + "','" + txtChucvu.Text + "'," +
                "'" + txtHD.Text + "','" + txtThoigian.Text + "'," +
                "'" + dtNgayky.Text + "','" + dtNgayhethan.Text + "','" + txtGhichu.Text + "')";
            //string sql = "update tbTeamleader set Ten = N'" + txtHoten.Text + "', Namsinh = '" + txtNamsinh.Text + "' , Mucluong = '" + txtMucluong.Text + "', TienTK = '" + txtTienTK.Text + "' , LuongTN = '" + txtLuongTN.Text + "' where Ten = N'" + Tentruockhisua + "' ";
            Clsdatabase.ThemSuaXoa(sql);
            dgvNhansu.DataSource = Clsdatabase.Bang("select * from tblTTNVCoBan");
            MessageBox.Show("Đã sửa bản ghi!");
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            string ht = txtHoten.Text;
            string sql = "delete from tblTTNVCoBan where Ten = '" + txtHoten.Text + "' ";
            Clsdatabase.ThemSuaXoa(sql);
            dgvNhansu.DataSource = Clsdatabase.Bang("select * from tblTTNVCoBan");
            MessageBox.Show("Đã xóa bản ghi!");
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcoban_Load(object sender, EventArgs e)
        {
            dgvNhansu.DataSource = Clsdatabase.Bang("select * from tblTTNVCoBan");
            dgvNhansu.Columns[0].HeaderText = "Mã bộ phận";
            dgvNhansu.Columns[1].HeaderText = "Mã phòng";
            dgvNhansu.Columns[2].HeaderText = "Mã NV";
            dgvNhansu.Columns[3].HeaderText = "Họ tên";
            dgvNhansu.Columns[4].HeaderText = "Mã lương";
            dgvNhansu.Columns[5].HeaderText = "Ngày sinh";
            dgvNhansu.Columns[6].HeaderText = "Giới tính";
            dgvNhansu.Columns[7].HeaderText = "Hôn nhân";
            dgvNhansu.Columns[8].HeaderText = "CMTND";
            dgvNhansu.Columns[9].HeaderText = "Nơi cấp";
            dgvNhansu.Columns[10].HeaderText = "Chức vụ";
            dgvNhansu.Columns[11].HeaderText = "Loại HĐ";
            dgvNhansu.Columns[12].HeaderText = "Thời gian";
            dgvNhansu.Columns[13].HeaderText = "Ngày ký";
            dgvNhansu.Columns[14].HeaderText = "Ngày hết hạn";
            dgvNhansu.Columns[15].HeaderText = "Ghi chú";

            dgvNhansu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhansu.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dgvNhansu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhansu.CurrentRow != null)
            {
                txtMBP.Text = dgvNhansu.CurrentRow.Cells[0].Value.ToString();
                txtMP.Text = dgvNhansu.CurrentRow.Cells[1].Value.ToString();
                txtMNV.Text = dgvNhansu.CurrentRow.Cells[2].Value.ToString();
                txtHoten.Text = dgvNhansu.CurrentRow.Cells[3].Value.ToString();
                txtMaLuong.Text = dgvNhansu.CurrentRow.Cells[4].Value.ToString();
                dtNgaysinh.Text = dgvNhansu.CurrentRow.Cells[5].Value.ToString();
                cbGioitinh.Text = dgvNhansu.CurrentRow.Cells[6].Value.ToString();
                txtHonnhan.Text = dgvNhansu.CurrentRow.Cells[7].Value.ToString();
                txtCMTND.Text = dgvNhansu.CurrentRow.Cells[8].Value.ToString();
                txtNoicap.Text = dgvNhansu.CurrentRow.Cells[9].Value.ToString();
                txtChucvu.Text = dgvNhansu.CurrentRow.Cells[10].Value.ToString();
                txtHD.Text = dgvNhansu.CurrentRow.Cells[11].Value.ToString();
                txtThoigian.Text = dgvNhansu.CurrentRow.Cells[12].Value.ToString();
                dtNgayky.Text = dgvNhansu.CurrentRow.Cells[13].Value.ToString();
                dtNgayhethan.Text = dgvNhansu.CurrentRow.Cells[14].Value.ToString();
                txtGhichu.Text = dgvNhansu.CurrentRow.Cells[15].Value.ToString();
            }
        }
    }
}

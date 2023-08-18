using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Collections;

namespace QLNS
{
    class Clsdatabase
    {
        private static string Sql_connect = @"Data Source=DESKTOP-J81URJU;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();
        
        private static SqlConnection Ketnoi()
        {
            return new SqlConnection(Sql_connect);
        }

        //Lấy bảng
        public static DataTable Bang(string sql)
        {
            SqlConnection connect = Ketnoi();
            connect.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, connect);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            connect.Close();
            sqlData.Dispose();
            return table;
        }

        //Phương thức thêm sửa xóa
        public static void ThemSuaXoa(string sql)
        {
            SqlConnection connect = Ketnoi();
            connect.Open();
            SqlCommand command= new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
            command.Dispose();
        }

        //Phương thức so sánh
        public static bool Sosanh (string sql)
        {
            SqlConnection connect = Ketnoi();
            connect.Open();
            SqlCommand command= new SqlCommand(sql, connect);
            SqlDataReader datareader = command.ExecuteReader();
            return datareader.Read();
        }

        //Lấy ra danh sách
        public static ArrayList LayDanhSach(string sql)
        {
            DataTable tb = Clsdatabase.Bang(sql);
            ArrayList list = new ArrayList();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list.Add(tb.Rows[i][0].ToString());
            }
            return list;
        }

        //Lấy 1 giá trị
        public static string LayMotGiaTri(string sql)
        {
            SqlConnection con = Ketnoi();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object rs = cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();

            if (rs == null)
                return "";
            else
                return rs.ToString();
        }
    }
}

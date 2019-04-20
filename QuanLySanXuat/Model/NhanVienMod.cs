using QuanLySanXuat.Object;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLySanXuat.Model
{
    internal class NhanVienMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LoadAllData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbNhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                var mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into tbNhanVien values ('" + nvObj.Manhanvien + "',N'" + nvObj.Tennhanvien + "',N'" + nvObj.Taikhoan + "','" + nvObj.Matkhau + "'," +
                              "'" + nvObj.Gioitinh + "','" + nvObj.Diachi + "','" + nvObj.Dienthoai + "','" + nvObj.Bophan + "','" + nvObj.Chucvu + "','" +
                              nvObj.Tinhtrang + "','" + nvObj.Ghichu + "','" + nvObj.Giaodien + "','" + nvObj.Thongbao + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class KhachHangMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhachHang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public DataTable LoadData1C()
        {
            var dt = new DataTable();
            cmd.CommandText = "select MaKhachHang,TenKhachHang from dbo.tbKhachHang where TenKhachHang is not null";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public bool DelData(string strlenh)
        {
            cmd.CommandText = "Delete dbo.tbKhachHang Where MaKhachHang = '" + strlenh + "'";
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
                var mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;

        }
    }
}

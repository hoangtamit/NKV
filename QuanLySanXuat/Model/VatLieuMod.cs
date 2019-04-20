using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class VatLieuMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();
        public DataTable LoadAllData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbVatLieu";
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

        public DataTable LoadData4C()
        {
            var dt = new DataTable();
            cmd.CommandText = "select IDMaHang,MaAvery,MaHang,TenHangHoa,QuyCach from dbo.tbVatLieu where DienGiai is null";
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

        public DataTable GetData1C(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select QuyCach from dbo.tbVatLieu where TenHangHoa = N'"+strlenh+"' ";
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

        public DataTable GetData(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select MaHang from tbVatLieu where MaHang like '%" + strlenh + "%' order by (MaHang) asc";
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

        public bool DelData(string strlenh)
        {
            cmd.CommandText = "Delete dbo.tbVatLieu Where MaHang = '" + strlenh + "'";
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

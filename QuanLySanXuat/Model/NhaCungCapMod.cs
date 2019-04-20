using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class NhaCungCapMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly DataSet ds = new DataSet();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbNhaCungCap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public DataSet LoadDataSet()
        {
            cmd.CommandText = "select * from dbo.tbNhaCungCap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                sda.Fill(ds,"tbNhaCungCap");

            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return ds;
        }
        public DataTable LoadData1C()
        {
            var dt = new DataTable();
            cmd.CommandText = "select TenNhaCungCap from dbo.tbNhaCungCap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public int KiemTra(string strlenh)
        {
            int str;
            cmd.CommandText = "select count(*) from tbNhaCungCap where IDNhaCungCap = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            str = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.CloseConn();
            return str;
        }
        public bool DelData(string strlenh)
        {
            cmd.CommandText = "Delete dbo.tbNhaCungCap Where IDNhaCungCap = '" + strlenh + "'";
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

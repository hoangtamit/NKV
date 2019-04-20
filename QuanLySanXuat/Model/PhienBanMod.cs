using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySanXuat.Model
{
    internal class PhienBanMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select ID from dbo.tbPhienBan";
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
    }
}

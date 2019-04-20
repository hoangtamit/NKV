using System;
using System.Data;
using System.Data.SqlClient;


namespace QuanLySanXuat.Model
{
    internal class LoaiSanPhamMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        //private readonly DataTable dt = new DataTable();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select ID from dbo.tbLoaiSanPham";
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

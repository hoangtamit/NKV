using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySanXuat.Model
{
    internal class DonHangTemVaiAveryMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            //cmd.CommandText = " Select ID from dbo.tbBoPhan";
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

        public bool DelData_DonHangTemVaiAvery(string strlenh1)
        {
            cmd.CommandText = "Delete dbo.tbDonHangTemVaiAvery Where IDDonHangTemVaiAvery = '" + strlenh1 +"' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }


            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;

        }
    }
}

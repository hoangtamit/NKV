using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class KhoMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LoadData1C()
        {
            var dt = new DataTable();
            cmd.CommandText = "select ID from dbo.tbKho";
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class QuanLyTienTeMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LoadDataNull()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select * from  dbo.tbQuanLyTienTe where ketchuyen is null";
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
            cmd.CommandText = " Delete dbo.tbQuanLyTienTe Where IDTienTe = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                var mex = e.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;
        }
    }
}

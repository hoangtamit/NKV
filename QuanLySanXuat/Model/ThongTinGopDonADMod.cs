using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    public class ThongTinGopDonADMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable GetData_NgayXuongDon_SO(string strlenh1, string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = " SELECT * FROM tbthongtingopdonAd WHERE NgayXuongDon = '"+strlenh1+"' AND SO like '"+strlenh2+"' ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
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

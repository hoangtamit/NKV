using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanXuat.Model
{
    class BarcodeQrMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();

        public DataTable BarcodeQr_LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.BarcodeQR";
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
        public DataTable BarcodeQr_Delete()
        {
            var dt = new DataTable();
            cmd.CommandText = "TRUNCATE TABLE dbo.BarcodeQR";
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
        public int KiemTra(string strlenh)
        {
            var str = 0;
            cmd.CommandText = "select count(*) from BarcodeQR where ID = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            str = (int)cmd.ExecuteScalar();
            if (str == 1)
            {
                MessageBox.Show("Mã SO:" + strlenh + "đã có , vui lòng xem lại");
            }
            cmd.Dispose();
            con.CloseConn();
            return str;
        }
    }
}

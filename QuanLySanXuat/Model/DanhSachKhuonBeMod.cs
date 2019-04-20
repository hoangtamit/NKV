using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Int32;

namespace QuanLySanXuat.Model
{
    class DanhSachKhuonBeMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable LoadData_KhuonBe()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDanhSachKhuonBe order by KhachHang asc";
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
        public DataTable GetData_KhuonBe_IDKhuon(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_MaDonHang";
            cmd.CommandText = "select IDKhuon from dbo.tbDanhSachKhuonBe where IDKhuon like '%" + strlenh + "%' order by (IDKhuon) asc";
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

        public string SinhMaTuDong(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (var i = 0; i < count - 1; i++)
                    {
                        if (Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                        {
                            coso = Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                            break;
                        }
                        coso = Parse(dt.Rows[count - 1][0].ToString().Substring(2, 3)) + 1;
                    }
                }
                else
                {
                    if (Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }
            if (coso < 10)
                return "00" + coso;
            if (coso < 100)
                return "0" + coso;
            return coso.ToString();
        }
    }
}

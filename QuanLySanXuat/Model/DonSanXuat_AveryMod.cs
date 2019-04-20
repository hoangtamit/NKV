using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Model
{
    internal class DonSanXuat_AveryMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable GetAllData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery";
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

        public DataTable GetDataNull_Nhanvien(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is NULL AND NhanVien = N'"+strlenh+"' order by gopdon asc";
            //cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is null order by gopdon asc";
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
        public DataTable GetDataNull_Nhanvien_DanhSach(string strlenh1,int strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is NULL AND NhanVien = N'" + strlenh1 + "' and DanhSach = '"+strlenh2+"' order by gopdon asc";
            //cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is null order by gopdon asc";
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
        public DataTable GetDataNull_OrderDate_DanhSach(string strlenh1, int strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where orderdate = N'" + strlenh1 + "' and DanhSach = '" + strlenh2 + "' order by gopdon asc";
            //cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is null order by gopdon asc";
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
        public DataTable DonSanXuatAD_NhanVien_XacNhanNull(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where xacnhan is NULL AND NhanVien = N'" + strlenh + "'  ORDER by gopdon ASC "; // 
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
        public DataTable DonSanXuatAD_NhanVien_XacNhan2(string strlenh1 , string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where OrderDate = '"+strlenh1+ "' and DanhSach = '" + strlenh2 + "' and xacnhan = 2 ORDER by gopdon ASC "; // 
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


        public DataTable GetData_OrderDate(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where OrderDate = '"+ strlenh +"' and XacNhan is null order by gopdon asc";
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

        public DataTable GetData_OrderDate2(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat_Avery where OrderDate = '" + strlenh + "' and sku = '1' order by gopdon asc";
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

        public DataTable GetData_SCD(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = " select * from tbDonSanXuat_Avery where scd = '" + strlenh + "' ";
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

        public DataTable GetData_Donsanxuat_Avery_Standard_TongTien()
        {
            var dt = new DataTable();
            cmd.CommandText = "DonSanXuat_Avery_Standard_TongTien";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable GetData_Donsanxuat_Avery_Standard_NotNull()
        {
            var dt = new DataTable();
            cmd.CommandText = "Donsanxuat_Avery_Standard_NotNull";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable LoadData(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText ="select No,OrderDate,SO,Item,XacNhan from tbDonSanXuat_Avery where XacNhan is null and No = GopDon AND NhanVien = N'" + strlenh + "'  order by gopdon asc";

            //cmd.CommandText =
            //    "select No,OrderDate,SO,Item,PrintSize FROM tbDonSanXuat_Avery,dbo.tbStandard WHERE dbo.tbDonSanXuat_Avery.Item = dbo.tbStandard.ItemCode AND XacNhan IS NULL AND No = GopDon AND NhanVien = N'" + strlenh + "' ORDER by PrintSize,GopDon ASC";

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


        public int KiemTra(string strlenh)
        {
            var str = 0;
            cmd.CommandText = "select count(*) from tbDonSanXuat_Avery where SO = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            con.OpenConn();
            str = (int) cmd.ExecuteScalar();
            if (str == 1)
            {
                MessageBox.Show("Mã SO:" + strlenh + "đã có , vui lòng xem lại");
            }
            cmd.Dispose();
            con.CloseConn();
            return str;
        }

        //public DataTable LoadData(string strlenh)
        //{
        //    var dt = new DataTable();
        //    cmd.CommandText = strlenh;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();

        //        var sda = new SqlDataAdapter(cmd);
        //        sda.Fill(dt);

        //    }
        //    catch (Exception )
        //    {
        //        cmd.Dispose();
        //        con.CloseConn();
        //    }

        //    return dt;
        //}


        public bool AddData(DonSanXuat_AveryObj donSanXuatAveryObj)
        {
            cmd.CommandText =
                "INSERT INTO tbDonSanXuat_Avery(No,OrderDate,RequestDate,SO,RBO,CustomerPO,CustomerItem,Item,Qty,Material,Length,MaterialQty,SKU,Cut,Fold,GopDon,NhanVien,DanhSach) VALUES('" +
                donSanXuatAveryObj.No + "', CONVERT(DATE, '" + donSanXuatAveryObj.Orderdate + "', 103), CONVERT(DATE, '" + donSanXuatAveryObj.Requestdate + "', 103),'" + donSanXuatAveryObj.So + "','" + donSanXuatAveryObj.Rbo + "','" + donSanXuatAveryObj.Customerpo +
                "','" + donSanXuatAveryObj.Customeritem + "','" + donSanXuatAveryObj.Item + "','" +
                donSanXuatAveryObj.Qty + "','" + donSanXuatAveryObj.Material + "','" + donSanXuatAveryObj.Length +
                "','" + donSanXuatAveryObj.Materialqty + "','" + donSanXuatAveryObj.Sku + "' ,N'" +
                donSanXuatAveryObj.Cut + "' ,N'" + donSanXuatAveryObj.Fold + "','" + donSanXuatAveryObj.Gopdon + "',N'" + donSanXuatAveryObj.NhanVien + "','" + donSanXuatAveryObj.Danhsach + "') ";
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
                MessageBox.Show("Không thêm được");
                var mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }

            return false;
        }

        public bool DelData(string strlenh)
        {
            cmd.CommandText = "Delete dbo.tbdonsanxuat_avery Where SO = '" + strlenh + "'";
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

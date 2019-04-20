using System;
using System.Data;
using System.Data.SqlClient;
using static System.Int32;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Model
{
    internal class KhoBTP_TPMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();
        public KhoBTP_TPObj khoObj = new KhoBTP_TPObj();


        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "Select * from dbo.tbKhoBTP_TP";
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
        public DataTable GetData(string strlenh1, string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoBTP_TP where  " + strlenh1 + " =  N'" + strlenh2 + "' ";
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
        public DataTable LoadData3C()
        {
            var dt = new DataTable();
            cmd.CommandText = "Select TenKhachHang,TenSanPham,Kho from dbo.tbKhoBTP_TP";
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

        public DataTable GetData_IDKhoBTP(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbKhoBTP_TP where IDKhoBTP_TP like '%" + strlenh + "%' order by (IDKhoBTP_TP) asc";
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
        public DataTable GetData_MaPhieu(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoBTP_TP where MaPhieu like '" + strlenh + "%' order by (MaPhieu) asc ";
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

        public bool Add(KhoBTP_TPObj khoObj)
        {
            try
            {
                var db = new MyDBContextDataContext();
                tbKhoBTP_TP kho = new tbKhoBTP_TP()
                {
                    IDKhoBTP_TP = khoObj.IDKhoBTP_TP,
                    MaPhieu = khoObj.MaPhieu,
                    Lo = khoObj.Lo,
                    NhapXuat = khoObj.NhapXuat,
                    SCD = khoObj.SCD,
                    Kho = khoObj.Kho,
                    Ngay = khoObj.Ngay,
                    LoaiSanPham = khoObj.LoaiSanPham,
                    MaDonHang = khoObj.MaDonHang,
                    TenKhachHang = khoObj.TenKhachHang,
                    TenSanPham = khoObj.TenSanPham,
                    SoLuongNhapKhachHang = khoObj.SoLuongNhapKhachHang,
                    SoLuongXuatKhachHang = khoObj.SoLuongXuatKhachHang,
                    SoLuongNhapCongTy = khoObj.SoLuongNhapCongTy,
                    SoLuongXuatCongTy = khoObj.SoLuongXuatCongTy,
                    DonViTinh = khoObj.DonViTinh,
                    KichThuoc = khoObj.KichThuoc,
                    KhoGiayIn = khoObj.KhoGiayIn,
                    BoPhan = khoObj.BoPhan,
                    GhiChu = khoObj.GhiChu,
                    NhanVien = khoObj.NhanVien,
                    XacNhan = khoObj.XacNhan,
                };
                db.tbKhoBTP_TPs.InsertOnSubmit(kho);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string SinhMaTuDong_MaPhieu(DataTable dt)
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
                        if (int.Parse(dt.Rows[i + 1][1].ToString().Substring(8, 4)) -
                            int.Parse(dt.Rows[i][1].ToString().Substring(8, 4)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][1].ToString().Substring(8, 4)) + 1;
                            break;
                        }

                        coso = int.Parse(dt.Rows[count - 1][1].ToString().Substring(8, 4)) + 1;
                    }
                }
                else
                {
                    if (int.Parse(dt.Rows[0][1].ToString().Substring(8, 4)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }
            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }

        public bool DelData(string strlenh1, string strlenh2)
        {
            cmd.CommandText = "delete dbo.tbKhoBTP_TP where  " + strlenh1 + " =  N'" + strlenh2 + "' ";
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
        //public bool DelData(string strlenh)
        //{
        //    cmd.CommandText = "Delete dbo.tbKhoBTP_TP Where IDKhoBTP_TP = '" + strlenh + "'";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        cmd.Dispose();
        //        con.CloseConn();
        //    }
        //    return false;

        //}
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
                        if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(0, 4)) - Parse(dt.Rows[i][0].ToString().Substring(0, 4)) > 1)
                        {
                            coso = Parse(dt.Rows[i][0].ToString().Substring(0, 4)) + 1;
                            break;
                        }
                        coso = Parse(dt.Rows[count - 1][0].ToString().Substring(0, 4)) + 1;
                    }
                }
                else
                {
                    coso = Parse(dt.Rows[0][0].ToString().Substring(0, 4)) == 1 ? 2 : 1;
                }
            }
            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }


    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using QuanLySanXuat.Class;
using static System.Int32;

namespace QuanLySanXuat.Model
{
    internal class DonSanXuatMod
    {
        //private SqlConnection con;
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        //public delegate void NewHome();
        //public event NewHome OnNewHome;

        public DataTable alldata()
        {
            var dt = new DataTable();
            cmd.CommandText = "SELECT scd FROM dbo.tbDonSanXuat";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "DonSanXuat_TienTe_QuanLyDonHang_View";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable LoadDataTest()
        {
            var dt = new DataTable();
            cmd.CommandText = "SELECT scd,MaDonHang,TenKhachHang,TenKhachHang,NgayXuongDon,NgayGiaoHang FROM dbo.tbDonSanXuat ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable DonSanXuat_DonHangTemVaiAvery(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = " SELECT dsx.SCD,dsx.MaDonHang,dsx.TenKhachHang,dsx.BoPhan,dsx.NgayXuongDon,dsx.TenSanPham,dsx.KichThuoc,dsx.SoLuong,XacNhan,dsx.SKU,dsx.STT,dhtv.Item,dhtv.SO,dhtv.XacNhan2,dhtv.GhiChu,dhtv.DanhSach  FROM dbo.tbDonSanXuat AS dsx , dbo.tbDonHangTemVaiAvery AS dhtv WHERE dsx.SCD = dhtv.IDDonHangTemVaiAvery AND dsx.NgayXuongDon = '" + strlenh+ "' AND dsx.TenKhachHang = '1.AD' AND dsx.BoPhan = N'TEM VẢI' and dhtv.XacNhan2 is null and dsx.PhuongPhapIn = N'Máy in Tem Vải (In Mềm)' ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable DonSanXuat_DonHangTemVaiAvery_All(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = " SELECT dsx.SCD,dsx.MaDonHang,dsx.TenKhachHang,dsx.BoPhan,dsx.NgayXuongDon,dsx.TenSanPham,dsx.KichThuoc,dsx.SoLuong,XacNhan,dsx.SKU,dsx.STT,dhtv.Item,dhtv.SO,dhtv.XacNhan2,dhtv.GhiChu,dhtv.DanhSach  FROM dbo.tbDonSanXuat AS dsx , dbo.tbDonHangTemVaiAvery AS dhtv WHERE dsx.SCD = dhtv.IDDonHangTemVaiAvery AND dsx.NgayXuongDon = '" + strlenh + "' AND dsx.TenKhachHang = '1.AD' AND dsx.BoPhan = N'TEM VẢI' and dsx.PhuongPhapIn = N'Máy in Tem Vải (In Mềm)'";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable LoadData_DonSanXuat_TienTe()
        {
            var dt = new DataTable();
            cmd.CommandText = "DonSanXuat_TienTe_View";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
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

        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_MaHang()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_MaHang";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_All()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_All";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_TemGiay_LanhLieu_DanhSachDonHang_NhapBTP()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_TemGiay_LanhLieu_DanhSachDonHang_NhapBTP";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_XuatBTP()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_XuatBTP";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable LoadData_DonSanXuat_BanThanhPham_Search()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_BanThanhPham_Search";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_Search()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_Search";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn(); var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_All()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_All";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn(); var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable LoadData_SCD_Search()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_SCD_KhoNVL_Search";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable LoadData_DonSanXuat_LanhLieu_KhoNVL()
        {
            var dt = new DataTable();
            cmd.CommandText = "LoadData_DonSanXuat_LanhLieu_KhoNVL";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable GetData(string strlenh1, string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "GetData_DonSanXuat";
            //cmd.CommandText = "select * from tbDonSanXuat where " + strlenh1 + " = '" + strlenh2 + "'";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
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
        public DataTable LoadData_DonSanXuat_NgayXuongDon(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "select * from tbDonSanXuat,tblanhlieu where scd = idlanhlieu and NgayXuongDon = '" + strlenh + "' and TenKhachHang = '"+PrintRibbon.AD+"' and BoPhan = N'TEM VẢI' ";
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

        public DataTable LoadData_DonSanXuat_NgayXuongDon_DanhSach(string strlenh1,int strlenh2)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText =
                "select * from tbDonSanXuat,tblanhlieu,tbDonHangTemVaiAvery where scd = idlanhlieu and scd = IDDonHangTemVaiAvery and NgayXuongDon = '" +
                strlenh1 + "' and DanhSach = '" + strlenh2 + "' and TenKhachHang = '"+PrintRibbon.AD+ "'  and BoPhan = N'TEM VẢI' and PhuongPhapIn = N'Máy in Tem Vải (In Mềm)'  ORDER BY MaDonHang ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {con.OpenConn();
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




        public bool GetData_DonSanXuat_QuanLyDonHang_SCD(string strlenh)
        {
            cmd.CommandText = "GetData_DonSanXuat_QuanLyDonHang_SCD";
            //cmd.CommandText = "Select * from dbo.tbDonSanXuat,dbo.tbQuanLyDonHang where dbo.tbDonSanXuat.SCD = dbo.tbQuanLyDonHang.IDQuanLyDonHang and hoanthanh is null and SCD = '" + strlenh + "'";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        // Danh mục báo cáo của các bộ phận thiet ke .......................................................................................................................................................................

        public DataTable LoadData_DonSanXuat_BaoCaoThietKe()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = " select IDBaoCaoThietKe,BanIn,SanPham,Layout,NetChu,CoChu,VitriCatGap,KyHieu,Size,SpSize,DanhGia,dbo.tbBaoCaoThietKe.GhiChu,NghiepVu_XuongDon,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,VatLieu FROM dbo.tbBaoCaoThietKe,dbo.tbQuanLyDonHang,dbo.tbDonSanXuat WHERE SCD = IDBaoCaoThietKe AND SCD = IDQuanLyDonHang and NghiepVu_XuongDon  IS NOT NULL and DanhGia is null order by NgayXuongDon asc	";
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
        public DataTable LoadData_DonSanXuat_BaoCaoThietKe_All()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = " select IDBaoCaoThietKe,BanIn,SanPham,Layout,NetChu,CoChu,VitriCatGap,KyHieu,Size,SpSize,DanhGia,dbo.tbBaoCaoThietKe.GhiChu,NghiepVu_XuongDon,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,VatLieu FROM dbo.tbBaoCaoThietKe,dbo.tbQuanLyDonHang,dbo.tbDonSanXuat WHERE SCD = IDBaoCaoThietKe AND SCD = IDQuanLyDonHang and NghiepVu_XuongDon  IS NOT NULL order by NgayXuongDon asc	";
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
        public DataTable LoadData_DonSanXuat_BaoCaoThietKe_NgayXuongDon(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "select IDBaoCaoThietKe,BanIn,SanPham,Layout,NetChu,CoChu,VitriCatGap,KyHieu,Size,SpSize,DanhGia,tbBaoCaoThietKe.GhiChu,IDQuanLyDonHang,NghiepVu_XuongDon,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,VatLieu from dbo.tbBaoCaoThietKe,dbo.tbQuanLyDonHang,dbo.tbDonSanXuat where scd = IDBaoCaoThietKe and SCD = IDBaoCaoThietKe AND SCD = IDQuanLyDonHang and NghiepVu_XuongDon  IS NOT NULL and NgayXuongDon = '" + strlenh + "' ";
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

        // Danh mục báo cáo của các bộ phận Nghiep Vu .......................................................................................................................................................................

        public DataTable LoadData_DonSanXuat_BaoCaoNghiepVu()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = " select IDBaoCaoNghiepVu,Size,SpSize,DanhGia,dbo.tbBaoCaoNghiepVu.GhiChu,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,NgayGiaoHang,VatLieu,PhuongPhapIn,KichThuoc,SoLuong FROM dbo.tbBaoCaoNghiepVu,dbo.tbDonSanXuat WHERE SCD = IDBaoCaoNghiepVu and DanhGia is null ORDER by NgayXuongDon asc ";
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
        
        public DataTable LoadData_DonSanXuat_BaoCaoNghiepVu_All()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = " select IDBaoCaoNghiepVu,Size,SpSize,DanhGia,dbo.tbBaoCaoNghiepVu.GhiChu,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,NgayGiaoHang,VatLieu,PhuongPhapIn,KichThuoc,SoLuong FROM dbo.tbBaoCaoNghiepVu,dbo.tbDonSanXuat WHERE SCD = IDBaoCaoNghiepVu  ORDER by NgayXuongDon asc 	";
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
        public DataTable LoadData_DonSanXuat_BaoCaoNghiepVu_NgayXuongDon(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "select IDBaoCaoNghiepVu,Size,SpSize,DanhGia,dbo.tbBaoCaoNghiepVu.GhiChu,SCD,MaDonHang,TenKhachHang,TenSanPham,NgayXuongDon,NgayGiaoHang,VatLieu,PhuongPhapIn,KichThuoc,SoLuong from dbo.tbBaoCaoNghiepVu,dbo.tbQuanLyDonHang,dbo.tbDonSanXuat where scd = IDBaoCaoNghiepVu and SCD = IDBaoCaoNghiepVu AND SCD = IDQuanLyDonHang and NghiepVu_XuongDon  IS NOT NULL and NgayXuongDon = '" + strlenh + "' ";
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

        public DataTable LoadData_DonSanXuat_QuanLyDonHang_ThietKe()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "LoadData_DonSanXuat_QuanLyDonHang_ThietKe";
            cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable LoadData_DonSanXuat_QuanLyDonHang_ThietKe_All()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "LoadData_DonSanXuat_QuanLyDonHang_ThietKe_All";
            cmd.CommandType = CommandType.StoredProcedure;
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


        public DataTable LoadData_DonSanXuat_QuanLyDonHang_NghiepVu()
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_NgayXuongDon";
            cmd.CommandText = "LoadData_DonSanXuat_QuanLyDonHang_NghiepVu";
            cmd.CommandType = CommandType.StoredProcedure;
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

        //public bool AddData(DonSanXuatObj dsxObj)
        //{
        //    cmd.CommandText = "Insert into donsanxuat values ('" + dsxObj.Scd + "','" + dsxObj.Madonhang + "',N'" + dsxObj.Phienban + "',CONVERT(DATE,'" + dsxObj.NamSinh + "',103),N'" + dsxObj.DiaChi + "','" + dsxObj.DienThoai + "','" + dsxObj.MatKhau + "')";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string mex = ex.Message;
        //        cmd.Dispose();
        //        con.CloseConn();
        //    }
        //    return false;
        //}
        //public bool UpdData(DonSanXuatObj donSanXuatObj)
        //{
        //    cmd.CommandText = "Update tb_NhanVien set TenNV =  N'" + dsxObj.TenNhanVien + "', GioiTinh = N'" + dsxObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + dsxObj.NamSinh + "',103), DiaChi = N'" + dsxObj.DiaChi + "',SDT = '" + dsxObj.DienThoai + "' Where MaNV = '" + dsxObj.MaNhanVien + "'";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string mex = ex.Message;
        //        cmd.Dispose();
        //        con.CloseConn();
        //    }
        //    return false;
        //}
        public bool DelData_DonSanXuat(string strlenh1, string strlenh2)
        {
            //cmd.CommandText = "DelData_DonSanXuat";
            cmd.CommandText = "Delete dbo.tbdonsanxuat Where "+ strlenh1 +" = '"+ strlenh2 +"' ";
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

        //public void de_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    var de = sender as SqlDependency;
        //    if (de != null) de.OnChange -= de_OnChange;
        //    if (OnNewHome != null)
        //    {
        //        OnNewHome();
        //    }
        //}
        //public void Form1_OnNewHome()
        //{
        //    var i = (ISynchronizeInvoke)this;
        //    if (i.InvokeRequired)//tab
        //    {
        //        var dd = new NewHome(Form1_OnNewHome);
        //        i.BeginInvoke(dd, null);
        //        return;
        //    }
        //    LoadData();
        //}

        public DataTable GetData_DonSanXuat_MaDonHang(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_MaDonHang";
            cmd.CommandText = "select MaDonHang from dbo.tbDonSanXuat where MaDonHang like '" + strlenh + "%' order by (MaDonHang) asc";
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
        public DataTable GetData_DonSanXuat_SCD(string strlenh)
        {
            var dt = new DataTable();
            //cmd.CommandText = "GetData_DonSanXuat_MaDonHang";
            cmd.CommandText = "select SCD from dbo.tbDonSanXuat where SCD like '" + strlenh + "%' order by (SCD) asc";
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
                        if (Parse(dt.Rows[i + 1][0].ToString().Substring(6, 4)) - Parse(dt.Rows[i][0].ToString().Substring(6, 4)) > 1)
                        {
                            coso = Parse(dt.Rows[i][0].ToString().Substring(6, 4)) + 1;
                            break;
                        }
                        coso = Parse(dt.Rows[count - 1][0].ToString().Substring(6, 4)) + 1;
                    }
                }
                else
                {
                    if (Parse(dt.Rows[0][0].ToString().Substring(6, 4)) == 1)
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

        public string GetDay()
        {
            string ngay, thang, nam;
            if (DateTime.Now.Day < 10)
                ngay = "0" + DateTime.Now.Day;
            else
                ngay = DateTime.Now.Day.ToString();
            if (DateTime.Now.Month < 10)
                thang = "0" + DateTime.Now.Month;
            else
                thang = DateTime.Now.Month.ToString();
            nam = DateTime.Now.Year.ToString().Substring(2);

            var ketqua = nam + thang + ngay;
            return ketqua;
        }
    }
}

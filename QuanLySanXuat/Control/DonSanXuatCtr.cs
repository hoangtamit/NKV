using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
namespace QuanLySanXuat.Control
{
    public class DonSanXuatCtr
    {
        private readonly DonSanXuatMod dsxMod = new DonSanXuatMod();

        public DataTable alldata()
        {
            return dsxMod.alldata();
        }
        public DataTable LoadData()
        {
            return dsxMod.LoadData();
        }

        public DataTable LoadDataTest()
        {
            return dsxMod.LoadDataTest();
        }

        public DataTable DonSanXuat_DonHangTemVaiAvery(string strlenh)
        {
            return dsxMod.DonSanXuat_DonHangTemVaiAvery(strlenh);
        }

        public DataTable DonSanXuat_DonHangTemVaiAvery_All(string strlenh)
        {
            return dsxMod.DonSanXuat_DonHangTemVaiAvery_All(strlenh);
        }
        public DataTable GetData(string strlenh1, string strlenh2)
        {
            return dsxMod.GetData(strlenh1, strlenh2);
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_All()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_All();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu();
        }
        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_MaHang()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_MaHang();
        }
        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_All()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_All();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_XuatBTP( )
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_XuatBTP();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_Search()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_Search();
        }

        public DataTable LoadData_DonSanXuat_BanThanhPham_Search()
        {
            return dsxMod.LoadData_DonSanXuat_BanThanhPham_Search();
        }

        public DataTable LoadData_SCD_Search()
        {
            return dsxMod.LoadData_SCD_Search();
        }

        public DataTable LoadData_DonSanXuat_LanhLieu_KhoNVL()
        {
            return dsxMod.LoadData_DonSanXuat_LanhLieu_KhoNVL();
        }

        public DataTable LoadData_DonSanXuat_TienTe()
        {
            return dsxMod.LoadData_DonSanXuat_TienTe();
        }
        public DataTable LoadData_DonSanXuat_NgayXuongDon(string strlenh)
        {
            return dsxMod.LoadData_DonSanXuat_NgayXuongDon(strlenh);
        }

        public DataTable LoadData_DonSanXuat_NgayXuongDon_DanhSach(string strlenh1, int strlenh2)
        {
            return dsxMod.LoadData_DonSanXuat_NgayXuongDon_DanhSach(strlenh1, strlenh2);
        }

        public DataTable GetData_DonSanXuat_MaDonHang(string strlenh)
        {
            return dsxMod.GetData_DonSanXuat_MaDonHang(strlenh);
        }
        public bool GetData_DonSanXuat_QuanLyDonHang_SCD(string strlenh)
        {
            return dsxMod.GetData_DonSanXuat_QuanLyDonHang_SCD(strlenh);
        }

        public DataTable LoadData_DonSanXuat_BaoCaoThietKe()
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoThietKe();
        }

        public DataTable LoadData_DonSanXuat_BaoCaoThietKe_All()
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoThietKe_All();
        }
        public DataTable LoadData_DonSanXuat_BaoCaoThietKe_NgayXuongDon(string strlenh)
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoThietKe_NgayXuongDon(strlenh);
        }

        public DataTable LoadData_DonSanXuat_BaoCao_nghiepvu()
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoNghiepVu();
        }

        public DataTable LoadData_DonSanXuat_BaoCao_nghiepvu_All()
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoNghiepVu_All();
        }

        public DataTable LoadData_DonSanXuat_BaoCao_nghiepvu_NgayXuongDon(string strlenh)
        {
            return dsxMod.LoadData_DonSanXuat_BaoCaoNghiepVu_NgayXuongDon(strlenh);
        }

        public bool DelData_DonSanXuat(string strlenh1, string strlenh2)
        {
            return dsxMod.DelData_DonSanXuat(strlenh1, strlenh2);
        }

        public DataTable LoadData_DonSanXuat_QuanLyDonHang__nghiepvu()
        {
            return dsxMod.LoadData_DonSanXuat_QuanLyDonHang_NghiepVu();
        }

        public DataTable LoadData_DonSanXuat_QuanLyDonHang_ThietKe()
        {
            return dsxMod.LoadData_DonSanXuat_QuanLyDonHang_ThietKe();
        }
        public DataTable LoadData_DonSanXuat_QuanLyDonHang_ThietKe_All()
        {
            return dsxMod.LoadData_DonSanXuat_QuanLyDonHang_ThietKe_All();
        }

        public DataTable GetData_DonSanXuat_SCD(string strlenh)
        {
            return dsxMod.GetData_DonSanXuat_SCD(strlenh);
        }

        //public void broker()
            //{
            //    var ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
            //    ss.Demand();
            //    SqlDependency.Stop(m_connect);
            //    SqlDependency.Start(m_connect);
            //    con = new SqlConnection(m_connect);
            //}

            //public void Form1_OnNewHome()
            //{
            //    dsxMod.Form1_OnNewHome();
            //}

            //public void de_OnChange(object sender, SqlNotificationEventArgs e)
            //{
            //    dsxMod.de_OnChange(sender, e);
            //}

            public string SinhMaTuDong(DataTable dt)
        {
            return dsxMod.SinhMaTuDong(dt);
        }

        public string GetDay()
        {
            return dsxMod.GetDay();
        }
    }
}

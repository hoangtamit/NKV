using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
using QuanLySanXuat.Object;
namespace QuanLySanXuat.Control
{
    internal class DonSanXuat_AveryCtr
    {
        public readonly DonSanXuat_AveryMod dsxAveryMod = new DonSanXuat_AveryMod();
        public DataTable GetAllData()
        {
            return dsxAveryMod.GetAllData();
        }

        public DataTable GetDataNull_Nhanvien(string strlenh)
        {
            return dsxAveryMod.GetDataNull_Nhanvien(strlenh);
        }
        public DataTable GetDataNull_Nhanvien_DanhSach(string strlenh1, int strlenh2)
        {
            return dsxAveryMod.GetDataNull_Nhanvien_DanhSach(strlenh1, strlenh2);
        }
        public DataTable GetDataNull_OrderDate_DanhSach(string strlenh1, int strlenh2)
        {
            return dsxAveryMod.GetDataNull_OrderDate_DanhSach(strlenh1, strlenh2);
        }
        public DataTable DonSanXuatAD_NhanVien_XacNhanNull(string strlenh)
        {
            return dsxAveryMod.DonSanXuatAD_NhanVien_XacNhanNull(strlenh);
        }

        public DataTable DonSanXuatAD_NhanVien_XacNhan2(string strlenh1,string strlenh2)
        {
            return dsxAveryMod.DonSanXuatAD_NhanVien_XacNhan2(strlenh1,strlenh2);
        }

        public DataTable GetData_OrderDate(string strlenh)
        {
            return dsxAveryMod.GetData_OrderDate(strlenh);
        }
        public DataTable GetData_OrderDate2(string strlenh)
        {
            return dsxAveryMod.GetData_OrderDate2(strlenh);
        }
        public DataTable GetData_SCD(string strlenh)
        {
            return dsxAveryMod.GetData_SCD(strlenh);
        }
            public DataTable GetData_Donsanxuat_Avery_Standard_TongTien()
        {
            return dsxAveryMod.GetData_Donsanxuat_Avery_Standard_TongTien();
        }

        public DataTable GetData_Donsanxuat_Avery_Standard_NotNull()
        {
            return dsxAveryMod.GetData_Donsanxuat_Avery_Standard_NotNull();
        }

        public DataTable LoadData(string strlenh)
        {
            return dsxAveryMod.LoadData(strlenh);
        }

        public int Kiemtra(string strlenh)
        {
            return dsxAveryMod.KiemTra(strlenh);
        }

        //public DataTable GetData(string strlenh)
        //{
        //    return dsxAveryMod.LoadData(strlenh);
        //}

        public bool AddData(DonSanXuat_AveryObj donSanXuatAveryObj)
        {
            return dsxAveryMod.AddData( donSanXuatAveryObj);
        }

        public bool DelData(string strlenh)
        {
            return dsxAveryMod.DelData(strlenh);
        }
    }
}

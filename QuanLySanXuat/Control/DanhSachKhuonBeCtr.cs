using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
using System.Data;

namespace QuanLySanXuat.Control
{
    class DanhSachKhuonBeCtr
    {
        public DanhSachKhuonBeMod dskbMod = new DanhSachKhuonBeMod();
        public DataTable LoadData_KhuonBe()
        {
            return dskbMod.LoadData_KhuonBe();
        }

        public string SinhMaTuDong(DataTable dt)
        {
            return dskbMod.SinhMaTuDong(dt);
        }

        public DataTable GetData_KhuonBe_IDKhuon(string strlenh)
        {
            return dskbMod.GetData_KhuonBe_IDKhuon(strlenh);
        }
    }
}

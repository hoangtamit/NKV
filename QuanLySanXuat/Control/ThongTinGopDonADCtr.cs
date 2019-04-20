using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
namespace QuanLySanXuat.Control
{
    public class ThongTinGopDonADCtr
    {
        public ThongTinGopDonADMod ThongTin = new ThongTinGopDonADMod();
        public DataTable GetData_NgayXuongDon_SO(string strlenh1, string strlenh2)
        {
            return ThongTin.GetData_NgayXuongDon_SO(strlenh1, strlenh2);
        }
    }
}

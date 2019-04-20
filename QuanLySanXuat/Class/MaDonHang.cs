using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.Class
{
    public class MaDonHang
    {
        public string TaoMaDonHang()
        {
            var dsxCtr = new DonSanXuatCtr();
            var day = dsxCtr.GetDay();
            var dt = dsxCtr.GetData_DonSanXuat_MaDonHang(day);
            var mdh = day + dsxCtr.SinhMaTuDong(dt);
            return mdh;
        }


    }
}

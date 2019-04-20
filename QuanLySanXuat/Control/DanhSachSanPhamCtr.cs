using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class DanhSachSanPhamCtr
    {
        private Model.DanhSachSanPhamMod dsspMod = new DanhSachSanPhamMod();

        public DataTable LoadData()
        {
            return dsspMod.LoadData();
        }
    }
}

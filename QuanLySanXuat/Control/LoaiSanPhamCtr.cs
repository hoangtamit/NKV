using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class LoaiSanPhamCtr
    {
        private LoaiSanPhamMod lspMod = new LoaiSanPhamMod();
        public DataTable LoadData()
        {
            return lspMod.LoadData();
        }
    }
}

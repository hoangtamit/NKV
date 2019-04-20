using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    class PhieuNhapXuatKho_Ctr
    {
        private PhieuNhapXuatKho_Mod pnxKhoMod = new PhieuNhapXuatKho_Mod();
        public DataTable LoadData()
        {
            return pnxKhoMod.LoadData();
        }
    }
}

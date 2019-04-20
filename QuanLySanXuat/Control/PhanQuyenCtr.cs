using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
using System.Data;

namespace QuanLySanXuat.Control
{
    class PhanQuyenCtr
    {
        PhanQuyenMod pqMod = new PhanQuyenMod();
        public DataTable PhanQuyen()
        {
            return pqMod.PhanQuyen();
        }
    }
}

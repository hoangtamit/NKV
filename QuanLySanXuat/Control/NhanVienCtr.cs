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
    class NhanVienCtr
    {
        private readonly NhanVienMod nvMod = new NhanVienMod();

        public DataTable LoadAllData()
        {
            return nvMod.LoadAllData();
        }

        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
    }
}

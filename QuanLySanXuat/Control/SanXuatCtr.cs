using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class SanXuatCtr
    {
        private SanXuatMod sxMod = new SanXuatMod();

        public DataTable LoadData()
        {
            return sxMod.LoadData();
        }

        public bool DelData(string strlenh)
        {
            return sxMod.DelData(strlenh);
        }
    }
}

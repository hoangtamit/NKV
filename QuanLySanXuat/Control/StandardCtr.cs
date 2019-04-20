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
    internal class StandardCtr
    {
        private StandardMod sdMod = new StandardMod();

        public DataTable LoadData()
        {
            return sdMod.LoadData();
        }
        public bool AddData(StandardObj sdObj)
        {
            return sdMod.AddData(sdObj);
        }

        public int KiemTra(string strlenh)
        {
            return sdMod.KiemTra(strlenh);
        }
    }
}

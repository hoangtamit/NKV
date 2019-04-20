using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class QuyCachCtr
    {
        private QuyCachMod qcMod = new QuyCachMod();

        public DataTable LoadData()
        {
            return qcMod.LoadData();
        }

        public DataTable LoadData1C()
        {
            return qcMod.LoadData1C();
        }

        public bool DelData(string strlenh)
        {
            return qcMod.DelData(strlenh);
        }
    }
}

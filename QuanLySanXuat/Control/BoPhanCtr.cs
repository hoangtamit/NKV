using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class BoPhanCtr
    {
        private readonly BoPhanMod boPhanMod = new BoPhanMod();
        public DataTable LoadData()
        {
            return boPhanMod.LoadData();
        }
    }
}

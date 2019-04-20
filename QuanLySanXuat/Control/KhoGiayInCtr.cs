using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class KhoGiayInCtr
    {
        private Model.KhoGiayInMod kgiMod = new KhoGiayInMod();

        public DataTable LoadData()
        {
            return kgiMod.LoadData();
        }
    }
}

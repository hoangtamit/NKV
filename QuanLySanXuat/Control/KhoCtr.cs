using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class KhoCtr
    {
        private Model.KhoMod khMod = new KhoMod();

        public DataTable LoadData1C()
        {
            return khMod.LoadData1C();
        }
    }
}

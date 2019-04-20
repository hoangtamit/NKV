using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    class BuHaoCtr
    {
        public BuHaoMod bhMod = new BuHaoMod();
        public DataTable LoadData_BuHao()
        {
            return bhMod.LoadData_BuHao();
        }
    }
}

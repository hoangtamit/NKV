using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
namespace QuanLySanXuat.Control
{
    class BaoCaoThietKeCtr
    {
        public BaoCaoThietKeMod bctkMod = new BaoCaoThietKeMod();
        public bool DelData_BaoCaoThietKe(string strlenh1)
        {
            return bctkMod.DelData_BaoCaoThietKe(strlenh1);
        }
    }
}

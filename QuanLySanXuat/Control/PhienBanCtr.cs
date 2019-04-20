using System;using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class PhienBanCtr
    {
        private PhienBanMod pbMod = new PhienBanMod();

        public DataTable LoadData()
        {
            return pbMod.LoadData();
        }
    }
}

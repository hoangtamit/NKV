using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
namespace QuanLySanXuat.Control
{
    class DonHangTemVaiAveryCtr
    {
        public DonHangTemVaiAveryMod DhAveryMod = new DonHangTemVaiAveryMod();
        public bool DelData_DonHangTemVaiAvery(string strlenh1)
        {
            return DhAveryMod.DelData_DonHangTemVaiAvery(strlenh1);

        }
    }
}

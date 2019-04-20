using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class KhachHangCtr
    {
        public KhachHangMod khMod = new KhachHangMod();

        public DataTable LoadData()
        {
            return khMod.LoadData();
        }

        public DataTable LoadData1C()
        {
            return khMod.LoadData1C();
        }

        public bool DelData(string strlenh)
        {
            return khMod.DelData(strlenh);
        }
    }
}

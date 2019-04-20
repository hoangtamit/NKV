using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class VatLieuCtr
    {
        private Model.VatLieuMod vlMod = new VatLieuMod();

        public DataTable LoadAllData()
        {
            return vlMod.LoadAllData();
        }

        public DataTable LoadData4C()
        {
            return vlMod.LoadData4C();
        }
        public DataTable GetData1C(string strlenh)
        {
            return vlMod.GetData1C(strlenh);
        }

        public DataTable GetData(string strlenh)
        {
            return vlMod.GetData(strlenh);
        }

        public bool DelData(string strlenh)
        {
            return vlMod.DelData(strlenh);
        }
    }
}

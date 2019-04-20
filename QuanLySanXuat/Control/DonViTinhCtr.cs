using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class DonViTinhCtr
    {
        private Model.DonViTinhMod dvtMod = new DonViTinhMod();
        public DataTable LoadData()
        {
            return dvtMod.LoadData();
        }

        public DataTable LoadData1C()
        {
            return dvtMod.LoadData1C();
        }

        public bool DelData(string strlenh)
        {
            return dvtMod.DelData(strlenh);
        }
    }
}

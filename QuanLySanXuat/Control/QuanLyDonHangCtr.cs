using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class QuanLyDonHangCtr
    {
        private QuanLyDonHangMod qldhMod = new QuanLyDonHangMod();

        public DataTable LoadData()
        {
            return qldhMod.LoadData();
        }
        public DataTable GetData_IDQuanlydonhang(string strlenh)
        {
            return qldhMod.GetData_IDQuanlydonhang(strlenh);
        }

            public bool DelData(string strlenh)
        {
            return qldhMod.DelData(strlenh);
        }
    }
}

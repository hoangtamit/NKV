using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class TemDanADCtr
    {
        public TemDanADMod tdADMod = new TemDanADMod();
        public DataTable GetData_IDTemDanAD(string strlenh)
        {
            return tdADMod.GetData_IDTemDanAD(strlenh);
        }

        public DataTable GetData_NgayXuongDon_SO(string strlenh1, string strlenh2)
        {
            return tdADMod.GetData_NgayXuongDon_SO(strlenh1, strlenh2);
        }
        public DataTable GetData_OrderDate(string strlenh)
        {
            return tdADMod.GetData_OrderDate(strlenh);
        }
        public DataTable LoadData()
        {
            return tdADMod.LoadData();
        }

    }
}

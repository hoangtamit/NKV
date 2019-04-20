using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class KhoBTPCtr_Demo
    {
        private KhoBTPMod_Demo kbtpMod = new KhoBTPMod_Demo();

        public DataTable LoadData()
        {
            return kbtpMod.LoadData();
        }

        //public DataTable GetData_IDKho(string strlenh)
        //{
        //    return kbtpMod.GetData_IDKho(strlenh);
        //}

        //public DataTable GetData_NhapXuat(string strlenh)
        //{
        //    return kbtpMod.GetData_NhapXuat(strlenh);
        //}

        //public DataTable GetData_TonKho(string strlenh, string strlenh2)
        //{
        //    return kbtpMod.GetData_TonKho(strlenh, strlenh2);
        //}
    }
}

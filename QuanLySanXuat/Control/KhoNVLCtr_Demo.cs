using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class KhoNVLCtr_Demo
    {
        private KhoNVLMod_Demo knvlMod = new KhoNVLMod_Demo();

        public DataTable LoadData()
        {
            return knvlMod.LoadData();
        }

        public DataTable GetData_IDKho(string strlenh)
        {
            return knvlMod.GetData_IDKho(strlenh);
        }

        public DataTable GetData_NhapXuat(string strlenh)
        {
            return knvlMod.GetData_NhapXuat(strlenh);
        }

        public DataTable GetData_TonKho(string strlenh, string strlenh2)
        {
            return knvlMod.GetData_TonKho(strlenh, strlenh2);
        }
    }
}

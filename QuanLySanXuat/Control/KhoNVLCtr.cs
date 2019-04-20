using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class KhoNVLCtr
    {
        private readonly KhoNVLMod knvlMod = new KhoNVLMod();

        public DataTable LoadData()
        {
            return knvlMod.LoadData();
        }

        public DataTable GetData_IDKho(string strlenh)
        {
            return knvlMod.GetData_IDKho(strlenh);
        }

        public DataTable GetData(string strlenh1, string strlenh2)
        {
            return knvlMod.GetData(strlenh1, strlenh2);
        }

        public DataTable GetData_MaPhieu(string strlenh)
        {
            return knvlMod.GetData_MaPhieu(strlenh);
        }

        public DataTable GetData_TonKho(string strlenh, string strlenh2)
        {
            return knvlMod.GetData_TonKho(strlenh, strlenh2);
        }

        public bool DelData(string strlenh1, string strlenh2)
        {
            return knvlMod.DelData(strlenh1, strlenh2);
        }

        public string SinhMaTuDong_MaPhieu(DataTable dt)
        {
            return knvlMod.SinhMaTuDong_MaPhieu(dt);
        }

        public string SinhMaTuDong_IDkho(DataTable dt)
        {
            return knvlMod.SinhMaTuDong_IDkho(dt);
        }
    }
}

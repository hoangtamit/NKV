using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat
{
    public class KhoBTP_TPCtr
    {
        private Model.KhoBTP_TPMod khoBtpTpMod = new KhoBTP_TPMod();
        public DataTable LoadData()
        {
            return khoBtpTpMod.LoadData();
        }
        public DataTable GetData(string strlenh1, string strlenh2)
        {
            return khoBtpTpMod.GetData(strlenh1, strlenh2);
        }
        public DataTable LoadData3C()
        {
            return khoBtpTpMod.LoadData3C();
        }

        public DataTable GetData_IDKhoBTP(string strlenh)
        {
            return khoBtpTpMod.GetData_IDKhoBTP(strlenh);
        }

        //public bool DelData(string strlenh)
        //{
        //    return khoBtpTpMod.DelData(strlenh);
        //}

        public bool DelData(string strlenh1, string strlenh2)
        {
            return khoBtpTpMod.DelData(strlenh1, strlenh2);
        }
        public string SinhMaTuDong(DataTable dt)
        {
            return khoBtpTpMod.SinhMaTuDong(dt);
        }

        public DataTable GetData_MaPhieu(string strlenh)
        {
            return khoBtpTpMod.GetData_MaPhieu(strlenh);
        }
        public string SinhMaTuDong_MaPhieu(DataTable dt)
        {
            return khoBtpTpMod.SinhMaTuDong_MaPhieu(dt);
        }
    }
}

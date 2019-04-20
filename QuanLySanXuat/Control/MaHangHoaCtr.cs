
using System.Data;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class MaHangHoaCtr
    {
        private MaHangHoaMod mhhMod = new MaHangHoaMod();

        public DataTable LoadData()
        {
            return mhhMod.LoadData();
        }

        public DataTable LoadData1C()
        {
            return mhhMod.LoadData1C();
        }

        public DataTable GetData_MaHang(string strlenh)
        {
            return mhhMod.GetData_MaHang(strlenh);
        }

        public bool DelData(string strlenh)
        {
            return mhhMod.DelData(strlenh);
        }
    }
}

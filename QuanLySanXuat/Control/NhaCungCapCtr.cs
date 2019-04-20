using System.Data;

using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class NhaCungCapCtr
    {
        private Model.NhaCungCapMod nccMod = new NhaCungCapMod();
        public DataTable LoadData()
        {
            return nccMod.LoadData();
        }
        public DataSet LoadDataSet()
        {
            return nccMod.LoadDataSet();
        }
        public DataTable LoadData1C()
        {
            return nccMod.LoadData1C();
        }

        public int KiemTra(string strlenh)
        {
            return nccMod.KiemTra(strlenh);
        }

        public bool DelData(string strlenh)
        {
            return nccMod.DelData(strlenh);
        }
    }
}

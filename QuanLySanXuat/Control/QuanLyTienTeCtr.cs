using System.Data;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class QuanLyTienTeCtr
    {
        private QuanLyTienTeMod qlttMod = new QuanLyTienTeMod();

        public DataTable LoadDataNull()
        {
            return qlttMod.LoadDataNull();
        }
        public bool DelData(string strlenh)
        {
            return qlttMod.DelData(strlenh);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
namespace QuanLySanXuat.Control
{
    internal class LanhLieuCtr
    {
        private LanhLieuMod llMod = new LanhLieuMod();

        public DataTable LoadData()
        {
            return llMod.LoadData();
        }

        public DataTable LoadDataIDLanhLieu(string strlenh)
        {
            return llMod.LoadDataIDLanhLieu(strlenh);
        }
        public bool DelData(string strlenh)
        {
           return llMod.DelData(strlenh);
        }
    }
}

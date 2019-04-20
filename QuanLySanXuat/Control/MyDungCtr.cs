using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class MyDungCtr
    {
        public  MyDungMod mdMod = new MyDungMod();
        public DataTable LoadData()
        {
            return mdMod.LoadData();
        }

        public DataTable LoadData_TemVai()
        {
            return mdMod.LoadData_TemVai();
        }
    }
}

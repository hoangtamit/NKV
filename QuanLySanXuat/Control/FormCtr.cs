using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    public class FormCtr
    {
        FormMod formMod = new FormMod();
        public DataTable LoadData()
        {
            return formMod.LoadData();
        }
    }
}

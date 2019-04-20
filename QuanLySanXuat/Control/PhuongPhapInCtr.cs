using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;

namespace QuanLySanXuat.Control
{
    internal class PhuongPhapInCtr
    {
        private readonly PhuongPhapInMod ppiMod = new PhuongPhapInMod();
        public DataTable LoadData()
        {
            return ppiMod.LoadData();
        }
    }
}

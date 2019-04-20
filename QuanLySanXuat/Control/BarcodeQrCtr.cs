using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Model;
using System.Data;

namespace QuanLySanXuat.Control
{
    class BarcodeQrCtr
    {
        private readonly BarcodeQrMod bqrMod = new BarcodeQrMod();
        public DataTable BarcodeQr_LoadData()
        {
            return bqrMod.BarcodeQr_LoadData();
        }
        public DataTable BarcodeQr_Delete()
        {
            return bqrMod.BarcodeQr_Delete();
        }

        public int KiemTra(string strlenh)
        {
            return bqrMod.KiemTra(strlenh);
        }
        }
}

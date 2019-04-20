using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Control
{
    class BarcodeStickerCtr
    {
        public Model.BarcodeStickerMod bsMod = new Model.BarcodeStickerMod();
        public DataTable BarcodeSticker_SCD(string strlenh)
        {
            return bsMod.BarcodeSticker_SCD(strlenh);
        }
        public DataTable BarcodeSticker_SCD_Barcode(string strlenh1, string strlenh2)
        {
            return bsMod.BarcodeSticker_SCD_Barcode(strlenh1, strlenh2);
        }
    }
}

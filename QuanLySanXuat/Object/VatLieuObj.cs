using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Object
{
    class VatLieuObj
    {
        public VatLieuObj()
        {

        }
        public VatLieuObj(string iDMaHang, string maHang, string maAvery, string tenHangHoa, string donViTinh, string quyCach, string ghiChu)
        {
            IDMaHang = iDMaHang;
            MaHang = maHang;
            MaAvery = maAvery;
            TenHangHoa = tenHangHoa;
            DonViTinh = donViTinh;
            QuyCach = quyCach;
            GhiChu = ghiChu;
        }

        public string IDMaHang { get; set; }

        public string MaHang { get; set; }

        public string MaAvery { get; set; }

        public string TenHangHoa { get; set; }

        public string DonViTinh { get; set; }

        public string QuyCach { get; set; }

        public string GhiChu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Object
{
    internal class DonSanXuat_AveryObj
    {

        public DonSanXuat_AveryObj()
        {

        }
        public DonSanXuat_AveryObj(int no, DateTime orderdate, DateTime requestdate, string so, string rbo, string customerpo, string customeritem, string item, int qty, string material, float length, float materialqty, int sku, string cut, string fold, int gopdon,int xacnhan,string nhanvien,int danhsach)
        {
            No = no;
            Orderdate = orderdate;
            Requestdate = requestdate;
            So = so;
            Rbo = rbo;
            Customerpo = customerpo;
            Customeritem = customeritem;
            Item = item;
            Qty = qty;
            Material = material;
            Length = length;
            Materialqty = materialqty;
            Sku = sku;
            Cut = cut;
            Fold = fold;
            Gopdon = gopdon;
            Xacnhan = xacnhan;
            NhanVien = nhanvien;
            Danhsach = danhsach;
        }

        

        public int No { get; set; }

        public DateTime Orderdate { get; set; }

        public DateTime Requestdate { get; set; }

        public string So { get; set; }

        public string Rbo { get; set; }

        public string Customerpo { get; set; }

        public string Customeritem { get; set; }

        public string Item { get; set; }

        public int Qty { get; set; }

        public string Material { get; set; }

        public float Length { get; set; }

        public float Materialqty { get; set; }

        public int Sku { get; set; }

        public string Cut { get; set; }

        public string Fold { get; set; }

        public int Gopdon { get; set; }

        public int Xacnhan { get; set; }

        public string NhanVien { get; set; }

        public int Danhsach { get; set; }
    }
}

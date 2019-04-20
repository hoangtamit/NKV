using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Object
{
    internal class StandardObj
    {
        public StandardObj()
        {

        }
        public StandardObj(string itemCode, string printing, string rBO, string materialCode, string printSize, string inkCode, string note, float price)
        {
            ItemCode = itemCode;
            Printing = printing;
            RBO = rBO;
            MaterialCode = materialCode;
            PrintSize = printSize;
            InkCode = inkCode;
            Note = note;
            Price = price;
        }

        public string ItemCode { get; set; }

        public string Printing { get; set; }

        public string RBO { get; set; }

        public string MaterialCode { get; set; }

        public string PrintSize { get; set; }

        public string InkCode { get; set; }

        public string Note { get; set; }

        public float Price { get; set; }
    }
}

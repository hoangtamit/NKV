using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanXuat.Control;
using static System.Int32;

namespace QuanLySanXuat.Class
{
    class MaSCD
    {
        public string TaoSCD()
        {
            var scd = "SCD" + DateTime.Now.ToString("yyMMddhhmm");
            //var rd = new Random();
            //var _scd = scd + rd.Next(100, 999);
            var dsxCtr = new DonSanXuatCtr();
            var dt = dsxCtr.GetData_DonSanXuat_SCD(scd);
            var _scd = scd + SinhMaTuDong(dt);
            return _scd;
        }
        public string SinhMaTuDong(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (var i = 0; i < count - 1; i++)
                    {
                        if (Parse(dt.Rows[i + 1][0].ToString().Substring(13, 3)) - Parse(dt.Rows[i][0].ToString().Substring(13,3)) > 1)
                        {
                            coso = Parse(dt.Rows[i][0].ToString().Substring(13,3)) + 1;
                            break;
                        }
                        coso = Parse(dt.Rows[count - 1][0].ToString().Substring(13,3)) + 1;
                    }
                }
                else
                {
                    if (Parse(dt.Rows[0][0].ToString().Substring(13,3)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }
            if (coso < 10)
                return "00" + coso;
            if (coso < 100)
                return "0" + coso;
            return coso.ToString();
        }
    }
}

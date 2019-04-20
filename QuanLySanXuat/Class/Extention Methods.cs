using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardWin.Design;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QuanLySanXuat.Class
{
    public static class Extention_Methods
    {

        public delegate bool MatNa(int x);
        public static int test(this ButtonEdit txt,MatNa mm)
        {
            int sl2 = 0;
            int x = Convert.ToInt32(txt.Text);
                if(mm(x))
                sl2 = 500;
            return sl2;
        }

        public static int sl1(this ButtonEdit sl) 
        {
            int sl2 = 0;
            if (Convert.ToInt32(sl.Text) >= 500)
                sl2 = 500;
            return sl2;

            //if (Convert.ToInt32(soluong1) >= 500)
            //{
            //    int sl = Convert.ToInt32(soluong1);
            //    solanin1 = sl / 500;
            //    soluong1 = "500";
            //    size2 = size1;
            //    solanin2 = 1;
            //    soluong2 = (sl - ((sl / 500) * 500)).ToString();
            //}
        }

        public static int sli1(this ButtonEdit sl)
        {
            int sl2 = 0;
            if (Convert.ToInt32(sl.Text) >= 500)
                sl2 = Convert.ToInt32(sl.Text) / 500;
            return sl2;
        }

        public static int sl2(this ButtonEdit sl)
        {
            int sl2 = 0;
            if (Convert.ToInt32(sl.Text) >= 500)
                sl2 = Convert.ToInt32(sl.Text) - (Convert.ToInt32(sl.Text) / 500) * 500;
            return sl2;
        }

        public static string size01(this ComboBox cbb, int sl)
        {
            string cbb2 = null;
            if (Convert.ToInt32(sl) >= 500)
                cbb2 = cbb.Text;
            return cbb2;
        }

        public static string size02(this TextEdit te, int sl)
        {
            string te2 = null;
            if (Convert.ToInt32(sl) >= 500)
                te2 = te.Text;
            return te2;
        }

        public static int sli2(this ButtonEdit sl)
        {
            int sli = 0;
            if (Convert.ToInt32(sl.Text) >= 500)
                sli = 1;
            return sli;
        }

        static MyDBContextDataContext db;
        public static int Them(this int tong , string soluong, string scd, string so, string size, int solanin,
            DateTime orderdate,string soluong2,int _tong)
        {
            if (_tong == 0)
            {
                db = new MyDBContextDataContext();
            }
            for (int i = 0; i < solanin; i++)
            {
                tbTemDanAd tb = new tbTemDanAd
                {
                    IDTemDanAD = scd,
                    SO = so,
                    Size = size,
                    QTY = soluong,
                    OrderDate = orderdate
                };
                db.tbTemDanAds.InsertOnSubmit(tb);
            }
            tong = _tong + Convert.ToInt32(soluong) * solanin;
            if (tong == Convert.ToInt32(soluong2))
            {
                db.SubmitChanges();
            }
            return tong;
        }

        //public static int soluong500(this int x)
        //{

        //}

        public static bool kiemtra(this ButtonEdit soluong, string size)
        {
            if (string.IsNullOrEmpty(soluong.Text) || string.IsNullOrEmpty(size) || Convert.ToInt32(soluong.Text) > 500)
            {
                return false;
            }
            return true;
        }
    }
}

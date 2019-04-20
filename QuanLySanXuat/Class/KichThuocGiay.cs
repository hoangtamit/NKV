using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanXuat.Class
{
    public class KichThuocGiay
    {
        //public int chieurong { get; set; }
        //public  int chieudai { get; set; }
        public int ChieuRong(int chieurong,int chieudai, int khoangcach, int GHCR,int GHCD,int canmang,string KGI,bool tinhxogiay)
        {
            int slchieurong;
            decimal _chieurong = chieurong + khoangcach;
            decimal _chieudai = chieudai + khoangcach;
            var KGI_Chieurong = Convert.ToInt32(KGI.Split('_')[1]);
            if (tinhxogiay)
                if (Math.Floor(KGI_Chieurong / _chieurong) * _chieurong + GHCR <= KGI_Chieurong)
                    slchieurong = (int)Math.Floor(KGI_Chieurong / _chieurong);
                else
                    slchieurong = (int)Math.Floor(KGI_Chieurong / _chieurong) - 1;
            else
            {
                if (Math.Floor(KGI_Chieurong / _chieudai) * _chieudai + GHCR <= KGI_Chieurong)
                    slchieurong = (int)Math.Floor(KGI_Chieurong / _chieudai);
                else
                    slchieurong = (int)Math.Floor(KGI_Chieurong / _chieudai) - 1;
            }
            return slchieurong;
        }

        public int ChieuDai(int chieurong, int chieudai, int khoangcach, int GHCR, int GHCD, int canmang, string KGI,bool tinhxogiay)
        {
            int slchieudai;
            decimal _chieurong = chieurong + khoangcach;
            decimal _chieudai = chieudai + khoangcach;
            var KGI_Chieudai = Convert.ToInt32(KGI.Split('_')[2]);
            if (tinhxogiay)
                if (Math.Floor(KGI_Chieudai / _chieudai) * _chieudai + GHCD + canmang <= KGI_Chieudai)
                    slchieudai = (int)Math.Floor(KGI_Chieudai / _chieudai);
                else
                    slchieudai = (int)Math.Floor(KGI_Chieudai / _chieudai) - 1;
            else
            {
                if (Math.Floor(KGI_Chieudai / _chieurong) * _chieurong + GHCD + canmang <= KGI_Chieudai)
                    slchieudai = (int)Math.Floor(KGI_Chieudai / _chieurong);
                else
                    slchieudai = (int)Math.Floor(KGI_Chieudai / _chieurong) - 1;
            }
            return slchieudai;
        }

        public int Tong(int ChieuRong, int ChieuDai, int K)
        {
            return ChieuRong * ChieuDai * K;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    class BarcodeStickerMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable BarcodeSticker_SCD(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = " 	SELECT SCD,Barcode,SoLuongCanIn ,SoLuongSKU ,SoLuongSheet_Goi,COUNT(SoLuongSheet_Goi)AS TongSoLuong,SoLuongPcs_Sheet ,NhanVien FROM dbo.tbBarcodeSticker where SCD = '"+strlenh+"' GROUP BY SCD,Barcode,SoLuongCanIn,SoLuongSKU,SoLuongSheet_Goi,SoLuongPcs_Sheet,NhanVien ORDER BY Barcode asc ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public DataTable BarcodeSticker_SCD_Barcode(string strlenh1,string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = " 	SELECT SCD,Barcode,SoLuongCanIn ,SoLuongSKU ,SoLuongSheet_Goi,COUNT(SoLuongSheet_Goi)AS TongSoLuong,SoLuongPcs_Sheet ,NhanVien FROM dbo.tbBarcodeSticker where SCD = '" + strlenh1 + "' and Barcode = '" + strlenh2 + "' GROUP BY SCD,Barcode,SoLuongCanIn,SoLuongSKU,SoLuongSheet_Goi,SoLuongPcs_Sheet,NhanVien ORDER BY Barcode asc ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

    }
}

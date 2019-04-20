using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    public class TemDanADMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable GetData_IDTemDanAD(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "SELECT STT ,IDTemDanAD ,SO ,Size ,OrderDate,QTY = CASE WHEN QTY = '500' THEN '500 + 5' ELSE qty END FROM dbo.tbTemDanAd  where IDTemDanAd = '" + strlenh+"' ";
            //SELECT STT ,IDTemDanAD ,SO ,Size ,OrderDate,QTY = CASE WHEN QTY = '500' THEN '500 + 5' ELSE qty END FROM dbo.tbTemDanAd 
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
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
        public DataTable GetData_NgayXuongDon_SO(string strlenh1 ,string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = " SELECT * from(SELECT IDTemDanAD,SO,Size ,OrderDate,SUM(CONVERT(int,QTY)) AS QTY,XacNhan FROM dbo.tbTemDanAd GROUP BY IDTemDanAD,so,Size,OrderDate,XacNhan) AS AD WHERE ad.OrderDate = '" + strlenh1+"' AND ad.SO LIKE '"+strlenh2+"%'";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
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
        public DataTable GetData_OrderDate(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbTemDanAd where OrderDate = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
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
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbTemDanAd ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
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

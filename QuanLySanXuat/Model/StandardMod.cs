using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySanXuat.Object;
namespace QuanLySanXuat.Model
{
    internal class StandardMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select * from dbo.tbStandard";
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
        public int KiemTra(string strlenh)
        {
            int str;          
                cmd.CommandText = "select count(*) from tbStandard where ItemCode = '" + strlenh + "' ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
                con.OpenConn();
                str = (int)cmd.ExecuteScalar();              
                cmd.Dispose();
                con.CloseConn();
            return str;
        }
        public bool AddData(StandardObj Obj)
        {
            cmd.CommandText = "INSERT INTO tbStandard(ItemCode,Printing,RBO,MaterialCode,PrintSize,InkCode,Note,Price) VALUES(N'" + Obj.ItemCode + "',N'" + Obj.Printing + "',N'" + Obj.RBO + "',N'" + Obj.MaterialCode + "',N'" + Obj.PrintSize + "',N'" + Obj.InkCode +"',N'" + Obj.Note + "','" + Obj.Price + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return false;
        }
    }
}

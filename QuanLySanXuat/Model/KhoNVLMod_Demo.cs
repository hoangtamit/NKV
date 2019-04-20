using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class KhoNVLMod_Demo
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoNLV_Demo";
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

        public DataTable GetData_IDKho(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoNLV where IDKhoNVL = N'" + strlenh + "' ";
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

        public DataTable GetData_NhapXuat(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoNLV where NhapXuat = N'" + strlenh + "' ";
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

        public DataTable GetData_TonKho(string strlenh , string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "KhoNVL_TonKho";
            cmd.CommandType = CommandType.StoredProcedure;
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

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class MaHangHoaMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select * from  dbo.tbMaHangHoa";
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

        public DataTable LoadData1C()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select DIENGIAI from  dbo.tbMaHangHoa";
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

        public DataTable GetData_MaHang(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = " Select IDMaHang from  dbo.tbMaHangHoa Where DIENGIAI = N'" + strlenh + "' ";
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

        public bool DelData(string strlenh)
        {
            cmd.CommandText = "Delete dbo.tbMaHangHoa Where IDMaHang = '" + strlenh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                var mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;

        }
    }
}

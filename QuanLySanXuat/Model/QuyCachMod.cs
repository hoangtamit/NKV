﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    internal class QuyCachMod
    {
        private ConnectToSQL con = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = " Select * from  dbo.tbQuyCach";
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
            cmd.CommandText = " Select ID from  dbo.tbQuyCach";
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
            cmd.CommandText = "Delete dbo.tbQuyCach Where ID = '" + strlenh + "'";
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

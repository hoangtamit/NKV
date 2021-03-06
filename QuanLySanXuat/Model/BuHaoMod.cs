﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuat.Model
{
    class BuHaoMod
    {

        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable LoadData_BuHao()
        {
            var dt = new DataTable();
            cmd.CommandText = " SELECT MauSac ,BuHaoOffsetAvery FROM dbo.tbBuHao";
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

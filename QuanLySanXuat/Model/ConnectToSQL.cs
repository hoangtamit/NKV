using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySanXuat
{
    internal class ConnectToSQL
    {
        private SqlConnection Conn;
        public string Error { get; set; }

        public SqlConnection Connection => Conn;

        public SqlCommand CMD { get; set; }

        public ConnectToSQL()
        {
            var strCon = @"Data Source=192.168.1.100;Initial Catalog=NKV;User ID=sa;Password=Ngochoa123";
            Conn = new SqlConnection(strCon);
        }



        public bool OpenConn()
        {
            try
            {
                if(Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }

            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if(Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }

            return true;
        }
    }
}

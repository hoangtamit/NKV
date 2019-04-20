using System;
using System.Data;
using System.Data.SqlClient;


namespace QuanLySanXuat.Model
{
    internal class LanhLieuMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();
        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat, tbLanhLieu where tbDonSanXuat.SCD = tbLanhLieu.IDLanhLieu";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn(); var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //var de = new SqlDependency(cmd);
                //de.OnChange += de_OnChange;
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

       
        public DataTable LoadDataIDLanhLieu(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbDonSanXuat, tbLanhLieu where tbDonSanXuat.SCD = tbLanhLieu.IDLanhLieu and SCD = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Notification = null;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception )
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool DelData(string strlenh)
        {
            cmd.CommandText = " Delete dbo.tbLanhLieu Where IDLanhLieu = '" + strlenh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}

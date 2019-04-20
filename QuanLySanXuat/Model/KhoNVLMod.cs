using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySanXuat.Model
{
    public class KhoNVLMod
    {
        private readonly ConnectToSQL con = new ConnectToSQL();
        private readonly SqlCommand cmd = new SqlCommand();

        public DataTable LoadData()
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoNLV";
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
            cmd.CommandText = "select * from dbo.tbKhoNLV where IDKhoNVL like N'%" + strlenh + "' order by (IDKhoNVL) asc ";
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

        public DataTable GetData(string strlenh1, string strlenh2)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from dbo.tbKhoNLV where  "+ strlenh1 +" =  N'"+ strlenh2 +"' ";
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
        
        public DataTable GetData_MaPhieu(string strlenh)
        {
            var dt = new DataTable();
            cmd.CommandText = "select * from tbKhoNLV where MaPhieu like '" + strlenh + "%' order by (MaPhieu) asc ";
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

        public bool DelData(string strlenh1, string strlenh2)
        {
            cmd.CommandText = "delete dbo.tbKhoNLV where  " + strlenh1 + " =  N'" + strlenh2 + "' ";
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
        public string SinhMaTuDong_MaPhieu(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (var i = 0; i < count - 1; i++)
                    {
                        if (int.Parse(dt.Rows[i + 1][1].ToString().Substring(8, 4)) -
                            int.Parse(dt.Rows[i][1].ToString().Substring(8, 4)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][1].ToString().Substring(8, 4)) + 1;
                            break;
                        }

                        coso = int.Parse(dt.Rows[count - 1][1].ToString().Substring(8, 4)) + 1;
                    }
                }
                else
                {
                    if (int.Parse(dt.Rows[0][1].ToString().Substring(8, 4)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }
            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }
        public string SinhMaTuDong_IDkho(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(0, 4)) -
                            int.Parse(dt.Rows[i][0].ToString().Substring(0, 4)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][0].ToString().Substring(0, 4)) + 1;
                            break;
                        }

                        coso = int.Parse(dt.Rows[count - 1][0].ToString().Substring(0, 4)) + 1;
                    }
                }
                else
                {
                    if (int.Parse(dt.Rows[0][0].ToString().Substring(0, 4)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }

            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }
    }
}

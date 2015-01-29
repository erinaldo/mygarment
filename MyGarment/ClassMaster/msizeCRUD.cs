using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMaster
{
    class msizeCRUD
    {
        private MySql.Data.MySqlClient.MySqlCommand strQuery = null;

        public DataSet getData()
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();
                Conn.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT SIZEID,DESCRIPTION,ACTIVE from tblmsize";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmsize");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string SIZEID, string Description)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();
                Conn.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT SIZEID,DESCRIPTION,ACTIVE from tblmsize WHERE SIZEID LIKE @SIZEID AND DESCRIPTION like @Description";
                strQuery.Parameters.AddWithValue("@SIZEID", "%" + SIZEID + "%");
                strQuery.Parameters.AddWithValue("@Description", "%" + Description + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmsize");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }
        public DataSet getDataFilter(string nama)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();

                Conn.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT SIZEID,DESCRIPTION,ACTIVE,TYPE FROM tblmcost WHERE  SIZEID=@SIZEID";
                strQuery.Parameters.AddWithValue("@SIZEID", nama);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmsize");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(msize k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                //strQuery.CommandText = "INSERT INTO tKaryawan VALUES('" + k.getNIP() + "','" + k.getNama() + "','" + k.getAlamat() + "','" + k.getNotelp() + "','" + k.getHP() + "')";
                strQuery.CommandText = "INSERT INTO tblmsize VALUES(@SIZEID,@Description,@Active)";
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.ExecuteNonQuery();
                stat = true;
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return stat;
        }
        public bool updateData(msize k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmsize SET DESCRIPTION=@Description,ACTIVE=@Active WHERE SIZEID=@SIZEID";
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.ExecuteNonQuery();

                ConnG.Putus();
                stat = true;

            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string costID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmsize WHERE SIZEID = @SIZEID";
                strQuery.Parameters.AddWithValue("@SIZEID", costID);
                strQuery.ExecuteNonQuery();
                stat = true;
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return stat;
        }
    }
}

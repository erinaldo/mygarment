using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using MyGarment.Global;

namespace MyGarment.ClassMaster
{
    class mitemscategoryCRUD
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
                strQuery.CommandText = "SELECT CATEGORYID,DESCRIPTION,ACTIVE from tblmitemscategory";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemscategory");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }


        public DataSet getData(string item)
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
                strQuery.CommandText = "SELECT CATEGORYID,DESCRIPTION,ACTIVE FROM tblmitemscategory WHERE CATEGORYID=@CategoryID";
                strQuery.Parameters.AddWithValue("@CategoryID", item);

                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemscategory");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string CategoryID, string Description, string Active)
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
                strQuery.CommandText = "SELECT CATEGORYID,DESCRIPTION,ACTIVE FROM tblmitemscategory WHERE CATEGORYID LIKE @CategoryID AND DESCRIPTION LIKE @Description AND ACTIVE LIKE @Active ";
                strQuery.Parameters.AddWithValue("@CategoryID", "%" + CategoryID + "%");
                strQuery.Parameters.AddWithValue("@Description", "%" + Description + "%");
                strQuery.Parameters.AddWithValue("@Active", "%" + Active + "%");
                //strQuery.Parameters.AddWithValue("@CategoryID", item);


                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemscategory");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string CategoryID, string Description)
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
                strQuery.CommandText = "SELECT CATEGORYID,DESCRIPTION,ACTIVE FROM tblmitemscategory WHERE CATEGORYID LIKE @CategoryID AND DESCRIPTION LIKE @Description  ";
                strQuery.Parameters.AddWithValue("@CategoryID", "%" + CategoryID + "%");
                strQuery.Parameters.AddWithValue("@Description", "%" + Description + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemscategory");

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
                strQuery.CommandText = "SELECT CATEGORYID,DESCRIPTION,ACTIVE,TYPE FROM tblmcost WHERE  CATEGORYID=@CategoryID";
                strQuery.Parameters.AddWithValue("@CategoryID", nama);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblcategory");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(mitemscategory k)
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
                strQuery.CommandText = "INSERT INTO tblmitemscategory VALUES(@CategoryID,@Description,@Active)";
                strQuery.Parameters.AddWithValue("@CategoryID", k.CategoryID);
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
        public bool updateData(string nip, mitemscategory k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmitemscategory SET DESCRIPTION=@Description,ACTIVE=@Active WHERE CATEGORYID=@CategoryID";
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@CategoryID", k.CategoryID);
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
                strQuery.CommandText = "DELETE FROM tblmitemscategory WHERE CATEGORYID = @CategoryID";
                strQuery.Parameters.AddWithValue("@CategoryID", costID);
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

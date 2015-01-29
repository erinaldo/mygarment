using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace MyGarment.ClassMaster
{
    class mcourierCRUD
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
                strQuery.CommandText = "SELECT * from tblmcourier";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcourier");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string COURIERID, string Description)
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
                strQuery.CommandText = "SELECT COURIERID,DESCRIPTION,ACTIVE from tblmcourier WHERE COURIERID LIKE @COURIERID AND DESCRIPTION like @Description";
                strQuery.Parameters.AddWithValue("@COURIERID", "%" + COURIERID + "%");
                strQuery.Parameters.AddWithValue("@Description", "%" + Description + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcourier");
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
                strQuery.CommandText = "SELECT COURIERID,DESCRIPTION,ACTIVE,TYPE FROM tblmcost WHERE  COURIERID=@COURIERID";
                strQuery.Parameters.AddWithValue("@COURIERID", nama);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcourier");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(mcourier k)
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
                strQuery.CommandText = "INSERT INTO tblmcourier VALUES(@COURIERID,@Description,@Active)";
                strQuery.Parameters.AddWithValue("@COURIERID", k.CourierID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                
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
        public bool updateData(string nip, mcourier k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmcourier SET DESCRIPTION=@Description,ACTIVE=@Active WHERE COURIERID=@COURIERID";
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@COURIERID", k.CourierID);
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
                strQuery.CommandText = "DELETE FROM tblmcourier WHERE COURIERID = @COURIERID";
                strQuery.Parameters.AddWithValue("@COURIERID", costID);
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

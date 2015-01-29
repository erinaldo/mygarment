using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMaster
{
    class mconvertCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet getData()
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();
                Conn.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT * from tblmconvert";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmconvert");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string UOM)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();
                Conn.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT * from tblmconvert WHERE UOM=@UOM";
                strQuery.Parameters.AddWithValue("@CostID", UOM);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmconvert");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string UOM,string UOMCONVERT)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                Connection Conn = new Connection();
                Conn.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT * from tblmconvert WHERE UOM=@UOM AND UOMCONVERT=@UOMCONVERT";
                strQuery.Parameters.AddWithValue("@UOM", UOM);
                strQuery.Parameters.AddWithValue("@UOMCONVERT", UOMCONVERT);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmconvert");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }


        public bool insertData(mconvert k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmconvert(UOM,UOMCONVERT,CONVER) VALUES(@UOM,@UOMCONVERT,@CONVER)";
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@UOMCONVERT", k.UOMCONVERT);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
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
        public bool updateData( mconvert k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmconvert SET CONVER=@CONVER WHERE UOM=@UOM,UOMCONVERT=@UOMCONVERT";
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@UOMCONVERT", k.UOMCONVERT);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
                strQuery.ExecuteNonQuery();

                ConnG.Putus();
                stat = true;

            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string UOM,string UOMCONVERT)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmconvert WHERE UOM = @UOM AND UOMCONVERT=@UOMCONVERT";
                strQuery.Parameters.AddWithValue("@UOM", UOM);
                strQuery.Parameters.AddWithValue("@UOMCONVERT", UOMCONVERT);
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

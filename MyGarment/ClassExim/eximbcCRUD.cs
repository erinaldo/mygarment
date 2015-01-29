using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MyGarment.ClassExim
{
    class eximbcCRUD
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
                strQuery.CommandText = "SELECT * FROM tbleximbc";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximbc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string JENIS)
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
                strQuery.CommandText = "SELECT * " +
                        " FROM tbleximbc WHERE JENIS LIKE @JENIS";
           
                strQuery.Parameters.AddWithValue("@JENIS", "%" + JENIS + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximbc");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public DataSet getData(string DOCTYPE,string JENIS)
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
                strQuery.CommandText = "SELECT * " +
                        " FROM tbleximbc WHERE DOCTYPE LIKE @DOCTYPE AND JENIS LIKE @JENIS";
                strQuery.Parameters.AddWithValue("@DOCTYPE", "%" + DOCTYPE + "%");
                strQuery.Parameters.AddWithValue("@JENIS", "%" + JENIS + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximbc");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public bool insertData(eximbc k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbleximbc (DOCTYPE,JENIS,DESCRIPTION) " +
                    "VALUES (@DOCTYPE,@JENIS,@DESCRIPTION)";
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
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
        public bool updateData(eximbc k,string DOCTYPE1,string JENIS1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbleximbc SET DOCTYPE=@DOCTYPE,JENIS=@JENIS,DESCRIPTION=@DESCRIPTION" +
                                       " WHERE DOCTYPE=@DOCTYPE1 AND JENIS=@JENIS1";
                //key
                strQuery.Parameters.AddWithValue("@DOCTYPE1", DOCTYPE1);
                strQuery.Parameters.AddWithValue("@JENIS1", JENIS1);
                //en key
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.ExecuteNonQuery();

                ConnG.Putus();
                stat = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return stat;
        }
        public bool deleteData(string DOCTYPE, string JENIS)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbleximbc WHERE DOCTYPE = @DOCTYPE AND JENIS=@JENIS";
                strQuery.Parameters.AddWithValue("@DOCTYPE", DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", JENIS);
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

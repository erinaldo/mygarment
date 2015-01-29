using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassExim
{
    class eximbcdetailCRUD
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
                strQuery.CommandText = "SELECT * FROM tbleximbcdetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximbcdetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string DOCTYPE, string JENIS)
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
                        " FROM tbleximbcdetail WHERE DOCTYPE LIKE @DOCTYPE AND JENIS LIKE @JENIS";
                strQuery.Parameters.AddWithValue("@DOCTYPE", "%" + DOCTYPE + "%");
                strQuery.Parameters.AddWithValue("@JENIS", "%" + JENIS + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximbcdetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public bool insertData(eximbcdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbleximbcdetail (DOCTYPE,JENIS,IDDetail) " +
                    "VALUES (@DOCTYPE,@JENIS,@IDDetail)";
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@IDDetail", k.IDDetail);
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
        public bool updateData(eximbcdetail k, string DOCTYPE1, string JENIS1,string IDDetail1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbleximbcdetail SET DOCTYPE=@DOCTYPE,JENIS=@JENIS,IDDetail=@IDDetail" +
                                       " WHERE DOCTYPE=@DOCTYPE1 AND JENIS=@JENIS1 AND IDDetail=@IDDetail1";
                //key
                strQuery.Parameters.AddWithValue("@DOCTYPE1", DOCTYPE1);
                strQuery.Parameters.AddWithValue("@JENIS1", JENIS1);
                strQuery.Parameters.AddWithValue("@IDDetail1", IDDetail1);
                //en key
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@IDDetail", k.IDDetail);
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
        public bool deleteData(string DOCTYPE, string JENIS, string IDDetail)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbleximbcdetail WHERE DOCTYPE = @DOCTYPE AND JENIS=@JENIS";
                strQuery.Parameters.AddWithValue("@DOCTYPE", DOCTYPE);
                strQuery.Parameters.AddWithValue("@JENIS", JENIS);
                strQuery.Parameters.AddWithValue("@IDDetail", IDDetail);
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

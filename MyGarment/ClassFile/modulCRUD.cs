using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MyGarment.ClassFile
{
    class modulCRUD
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
                strQuery.CommandText = "SELECT *" +
                        " FROM tblmodul";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmodul");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        //------------------CRUD
        public bool insertData(modul k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmodul(MODUL) VALUES(@MODUL)";
                strQuery.Parameters.AddWithValue("@MODUL", k.MODUL);
     
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
        public bool updateData(modul k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmodul SET MODUL=@MODUL";
                strQuery.Parameters.AddWithValue("@MODUL", k.MODUL);
                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;
            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string Modul)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmodul WHERE MODUL = @Modul";
                strQuery.Parameters.AddWithValue("@Modul", Modul);
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
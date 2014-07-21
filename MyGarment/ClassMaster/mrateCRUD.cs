using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassMaster
{
    class mrateCRUD
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
                strQuery.CommandText = "SELECT ID,DATE,CURRENCYID,KURS from tblmrate";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmrate");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }



        public DataSet getData(DateTime Date1, DateTime Date2)
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
                strQuery.CommandText = "SELECT ID,DATE,CURRENCYID,KURS FROM tblmrate WHERE DATE BETWEEN @Date1 AND @Date2";
                strQuery.Parameters.AddWithValue("@date1", Date1);
                strQuery.Parameters.AddWithValue("@date1", Date2);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmrate");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }



        public bool insertData(mrate k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmrate(DATE,CURRENCYID,KURS) VALUES(@Date,@CurrencyID,@Kurs)";
                strQuery.Parameters.AddWithValue("@Date", k.DATE);
                strQuery.Parameters.AddWithValue("@CurrencyID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@Kurs", k.KURS);
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
        public bool updateData(mrate k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmrate SET DATE=@Date,CURRENCYID=@CurrencyID,KURS=@Kurs WHERE ID=@ID";
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@CurrencyID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@Date", k.DATE);
                strQuery.Parameters.AddWithValue("@Kurs", k.KURS);
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
                strQuery.CommandText = "DELETE FROM tblmrate WHERE ID = @ID";
                strQuery.Parameters.AddWithValue("@ID", costID);
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

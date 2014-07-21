using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MyGarment.ClassMaster
{
    class mtermofpaymentCRUD
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
                strQuery.CommandText = "SELECT TERMOFPAYMENT,DAYS,TERMTYPE,ACTIVE from tblmtermofpayment";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmtermofpayment");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string TermOfPayment, string TermType, int Days)
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
                strQuery.CommandText = "SELECT TERMOFPAYMENT,DAYS,TERMTYPE,ACTIVE FROM tblmtermofpayment WHERE TERMOFPAYMENT LIKE @TermOfPayment AND Days LIKE @Days AND TermType LIKE @TermType";
                strQuery.Parameters.AddWithValue("@TermOfPayment", "%" + TermOfPayment + "%");
                strQuery.Parameters.AddWithValue("@Days", "%" + Days + "%");
                strQuery.Parameters.AddWithValue("@TermType", "%" + TermType + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmtermofpayment");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }



        public bool insertData(mtermofpayment k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmtermofpayment VALUES(@TermOfPayment,@Days,@TermType,@Active)";
                strQuery.Parameters.AddWithValue("@TermOfPayment", k.TermOfPayment);
                strQuery.Parameters.AddWithValue("@Days", k.Days);
                strQuery.Parameters.AddWithValue("@TermType", k.TermType);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
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
        public bool updateData(mtermofpayment k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmtermofpayment SET DAYS=@Days,TERMTYPE=@TermType,ACTIVE=@Active WHERE TERMOFPAYMENT=@TermOfPayment";
                strQuery.Parameters.AddWithValue("@TermOfPayment", k.TermOfPayment);
                strQuery.Parameters.AddWithValue("@TERMTYPE", k.TermType);
                strQuery.Parameters.AddWithValue("@Days", k.Days);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;

            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string TermOfPayment)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmtermsofpayment WHERE TERMOFPAYMENT = @TermOfPayment";
                strQuery.Parameters.AddWithValue("@StoreID", TermOfPayment);
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

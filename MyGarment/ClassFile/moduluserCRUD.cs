using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MyGarment.ClassFile
{
    class moduluserCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet findData(string USERID, string MODUL)
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
                        " FROM tblmoduluser WHERE USERID=@USERID AND MODUL=@MODUL";
                strQuery.Parameters.AddWithValue("@USERID", USERID);
                strQuery.Parameters.AddWithValue("@MODUL", MODUL);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmoduluser");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public DataSet getData(string USERID,string MODUL)
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
                strQuery.CommandText = "SELECT *"+
                        " FROM tblmoduluser WHERE USERID LIKE @USERID AND MODUL LIKE @MODUL";
                strQuery.Parameters.AddWithValue("@USERID", "%" + USERID + "%");
                strQuery.Parameters.AddWithValue("@MODUL", "%" + MODUL + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmoduluser");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        //===================================================CRUD

        public bool insertData(moduluser k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmoduluser(USERID,MODUL,SAVE,UPDAT,DEL,PRINT,APPROVE,ACKNOWLEGMENT,UNAPPROVE,CEK,SEE) VALUES(@USERID,@MODUL,@SAVE,@UPDAT,@DEL,@PRINT,@APPROVE,@ACKNOWLEGMENT,@UNAPPROVE,@CEK,@SEE)";
                strQuery.Parameters.AddWithValue("@USERID", k.USERID);
                strQuery.Parameters.AddWithValue("@MODUL", k.MODUL);
                strQuery.Parameters.AddWithValue("@SAVE", k.SAVE);
                strQuery.Parameters.AddWithValue("@UPDAT", k.UPDAT);
                strQuery.Parameters.AddWithValue("@DEL", k.DEL);
                strQuery.Parameters.AddWithValue("@PRINT", k.PRINT);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@ACKNOWLEGMENT", k.ACKNOWLEGMENT);
                strQuery.Parameters.AddWithValue("@UNAPPROVE", k.UNAPPROVE);
                strQuery.Parameters.AddWithValue("@CEK", k.CEK);
                strQuery.Parameters.AddWithValue("@SEE", k.SEE);
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
        public bool updateData(moduluser k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmoduluser SET SAVE=@SAVE,UPDAT=@UPDAT,DEL=@DEL,PRINT=@PRINT,APPROVE=@APPROVE,ACKNOWLEGMENT=@ACKNOWLEGMENT,UNAPPROVE=@UNAPPROVE,CEK=@CEK,SEE=@SEE WHERE USERID=@USERID AND MODUL=@MODUL";
                strQuery.Parameters.AddWithValue("@USERID", k.USERID);
                strQuery.Parameters.AddWithValue("@MODUL", k.MODUL);
                strQuery.Parameters.AddWithValue("@SAVE", k.SAVE);
                strQuery.Parameters.AddWithValue("@UPDAT", k.UPDAT);
                strQuery.Parameters.AddWithValue("@DEL", k.DEL);
                strQuery.Parameters.AddWithValue("@PRINT", k.PRINT);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@ACKNOWLEGMENT", k.ACKNOWLEGMENT);
                strQuery.Parameters.AddWithValue("@UNAPPROVE", k.UNAPPROVE);
                strQuery.Parameters.AddWithValue("@CEK", k.CEK);
                strQuery.Parameters.AddWithValue("@SEE", k.SEE);
                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;
            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string UserID,string Modul)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmoduluser WHERE MODUL = @Modul AND USERID=@UserID";
                strQuery.Parameters.AddWithValue("@UserID", UserID);
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

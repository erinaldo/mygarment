using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassFile
{
    class muserCRUD
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
                        " FROM tblmuser";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmuser");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string userID,string name)
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
                        " FROM tblmuser WHERE USERID LIKE @USERID AND NAME LIKE @NAME";
                strQuery.Parameters.AddWithValue("@USERID", "%" + userID + "%");
                strQuery.Parameters.AddWithValue("@NAME", "%" + name + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmuser");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getLogin(string userID, string Password)
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
                        " FROM tblmuser WHERE USERID=@USERID AND PASSWORD=@PASSWORD";
                strQuery.Parameters.AddWithValue("@USERID", userID );
                strQuery.Parameters.AddWithValue("@PASSWORD", Password);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmuser");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        //------------------CRUD
        public bool insertData(muser k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmuser(USERID,NAME,PASSWORD,GDIV,LOCATIONID,EMAIL,PHONE,TTD,PATH,ADDRESS,ACTIVE) "+
                    " VALUES (@USERID,@NAME,@PASSWORD,@GDIV,@LOCATIONID,@EMAIL,@PHONE,@TTD,@PATH,@ADDRESS,@ACTIVE)";
                strQuery.Parameters.AddWithValue("@USERID", k.USERID);
                strQuery.Parameters.AddWithValue("@NAME", k.NAME);
                strQuery.Parameters.AddWithValue("@PASSWORD", k.PASSWORD);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@LOCATIONID", k.LOCATIONID);
                strQuery.Parameters.AddWithValue("@EMAIL", k.EMAIL);
                strQuery.Parameters.AddWithValue("@PHONE", k.PHONE);
                strQuery.Parameters.AddWithValue("@TTD", k.TTD);
                strQuery.Parameters.AddWithValue("@PATH", k.PATH);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@ACTIVE", k.ACTIVE);


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
        public bool updateData(muser k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmuser SET NAME=@NAME,PASSWORD=@PASSWORD,GDIV=@GDIV,LOCATIONID=@LOCATIONID, "+
                    "EMAIL=@EMAIL,PHONE=@PHONE,TTD=@TTD,PATH=@PATH,ADDRESS=@ADDRESS,ACTIVE=@ACTIVE "+
                    "WHERE USERID=@USERID";
                strQuery.Parameters.AddWithValue("@USERID", k.USERID);
                strQuery.Parameters.AddWithValue("@NAME", k.NAME);
                strQuery.Parameters.AddWithValue("@PASSWORD", k.PASSWORD);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@LOCATIONID", k.LOCATIONID);
                strQuery.Parameters.AddWithValue("@EMAIL", k.EMAIL);
                strQuery.Parameters.AddWithValue("@PHONE", k.PHONE);
                strQuery.Parameters.AddWithValue("@TTD", k.TTD);
                strQuery.Parameters.AddWithValue("@PATH", k.PATH);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@ACTIVE", k.ACTIVE);
                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;
            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string UserID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmuser WHERE USERID = @UserID";
                strQuery.Parameters.AddWithValue("@UserID", UserID);
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

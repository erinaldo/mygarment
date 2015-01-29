using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassProduction
{
    class cuttdetailCRUD
    {
        private MySqlCommand strQuery = null;
        public bool insertData(cuttdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblcuttdetail(CUTNO,SIZEID,QTY) " +
                        "VALUES(@CUTNO,@SIZEID,@QTY)";
                strQuery.Parameters.AddWithValue("@CUTNO", k.CUTNO);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@QTY", k.QTY);


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
        public bool updateData(cuttdetail k, string CUTNO1, string SIZEID1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblcuttdetail SET CUTNO=@CUTNO,SIZEID=@SIZEID,QTY=@QTY" +
                    " WHERE  CUTNO=@CUTNO1 AND SIZEID=@SIZEID1 ";
                //key
                strQuery.Parameters.AddWithValue("@CUTNO1", CUTNO1);
                strQuery.Parameters.AddWithValue("@SIZEID1",SIZEID1);

                //
                strQuery.Parameters.AddWithValue("@CUTNO", k.CUTNO);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@QTY", k.QTY);

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
        public bool deleteData(string STYLEID, string SIZEID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblcuttdetail WHERE  STYLEID=@STYLEID AND SIZEID=@SIZEID";
                strQuery.Parameters.AddWithValue("@STYLEID", STYLEID);
                strQuery.Parameters.AddWithValue("@SIZEID", SIZEID);
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

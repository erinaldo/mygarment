using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace MyGarment.ClassExim
{
    class eximdocdetailCRUD
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
                strQuery.CommandText = "SELECT * FROM tbleximdocdetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdocdetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string AJUNO)
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
                        " FROM tbleximdocdetail WHERE NOAJU LIKE @AJUNO";

                strQuery.Parameters.AddWithValue("@AJUNO", "%" + AJUNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdocdetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet findData(string AJUNO)
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
                strQuery.CommandText = "SELECT  tbleximdocdetail.TRANSNO,tbleximdocdetail.ID,tbleximdocdetail.NOAJU,tbleximdocdetail.ITEMSID,tbleximdocdetail.STYLEID,tbleximdocdetail.CURRENCY,tbleximdocdetail.PRICE,tbleximdocdetail.KURS,tbleximdocdetail.TOTAL, tblmitems.DESCRIPTION, "+
                        " View_Exim.QUANTITY,View_Exim.UOM " +
                        " FROM tbleximdocdetail INNER JOIN View_Exim ON View_Exim.TRANSNO=tbleximdocdetail.TRANSNO "+
                        " INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID" +
                        " WHERE NOAJU = @AJUNO";

                strQuery.Parameters.AddWithValue("@AJUNO",AJUNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdocdetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public bool insertData(eximdocdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbleximdocdetail (TRANSNO,ID,NOAJU,ITEMSID,STYLEID,CURRENCY,PRICE,KURS,TOTAL) " +
                                "VALUES (@TRANSNO,@ID,@NOAJU,@ITEMSID,@STYLEID,@CURRENCY,@PRICE,@KURS,@TOTAL)";
                strQuery.Parameters.AddWithValue("@TRANSNO", k.TRANSNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@NOAJU", k.NOAJU);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@CURRENCY", k.CURRENCY);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@TOTAL", k.TOTAL);
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
        public bool updateData(eximdocdetail k, string TRANSNO1, int ID1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbleximdocdetail SET TRANSNO=@TRANSNO,ID=@ID,NOAJU=@NOAJU,ITEMSID=@ITEMSID,STYLEID=@STYLEID,CURRENCY=@CURRENCY,PRICE=@PRICE,KURS=@KURS,TOTAL=@TOTAL" +
                                       " WHERE TRANSNO=@TRANSNO1 AND ID=@ID1";
                //key
                strQuery.Parameters.AddWithValue("@TRANSNO1", TRANSNO1);
                strQuery.Parameters.AddWithValue("@ID1", ID1);
                //en key
                strQuery.Parameters.AddWithValue("@TRANSNO", k.TRANSNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@NOAJU", k.NOAJU);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@CURRENCY", k.CURRENCY);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@TOTAL", k.TOTAL);
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
        public bool deleteData(string TRANSNO, int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbleximdocdetail WHERE TRANSNO = @TRANSNO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@TRANSNO", TRANSNO);
                strQuery.Parameters.AddWithValue("@ID", ID);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassStore
{
    class grnCRUD
    {
        private MySqlCommand strQuery = null;



        public DataSet SearchData(string GRNNO, string PONO, string OFFICER, string CUSTVENDCODE, string JENIS)
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
                strQuery.CommandText = "SELECT * " +
                        " FROM tblgrn WHERE GRNNO LIKE @GRNNO AND PONO LIKE @PONO AND OFFICER LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND JENIS like @JENIS";
                strQuery.Parameters.AddWithValue("@GRNNO", "%" + GRNNO + "%");
                strQuery.Parameters.AddWithValue("@PONO", "%" + PONO + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@JENIS", "%" +JENIS +"%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrn");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public DataSet prMatSupplier(string GRNNO)
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
                strQuery.CommandText = "SELECT * FROM tblgrn "+
                        " INNER JOIN tblgrndetail ON tblgrn.GRNNO=tblgrndetail.GRNNO"+
                        " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblgrn.CUSTVENDCODE"+
                        " WHERE tblgrn.GRNNO = @GRNNO";
                strQuery.Parameters.AddWithValue("@GRNNO", GRNNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrn");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

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
                strQuery.CommandText = "SELECT * FROM tblgrn";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrn");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string GRNNO)
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
                strQuery.CommandText = "SELECT * "+
                        " FROM tblgrn WHERE GRNNO LIKE @GRNNO";
                strQuery.Parameters.AddWithValue("@GRNNO", "%" + GRNNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrn");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string GRNNO, string PONO, string OFFICER, string CUSTVENDCODE)
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
                strQuery.CommandText = "SELECT * " +
                        " FROM tblgrn WHERE GRNNO LIKE @GRNNO AND PONO LIKE @PONO AND OFFICER LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE";
                strQuery.Parameters.AddWithValue("@GRNNO", "%" + GRNNO + "%");
                strQuery.Parameters.AddWithValue("@PONO", "%" + PONO + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrn");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public bool insertData(grn k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblgrn (GRNNO,DATE,OFFICER,GDIV,RECEIVEFROM,REMARKS,STOREID,PONO,CUSTVENDCODE,REFFNO,APPROVE,APPROVEDATE,APPROVEBY,CLOSE,STYLEID,COLORID,DOCREGNO,JENIS) "+
                    "VALUES (@GRNNO,@DATE,@OFFICER,@GDIV,@RECEIVEFROM,@REMARKS,@STOREID,@PONO,@CUSTVENDCODE,@REFFNO,@APPROVE,@APPROVEDATE,@APPROVEBY,@CLOSE,@STYLEID,@COLORID,@DOCREGNO,@JENIS)";
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@RECEIVEFROM", k.RECEIVEFROM);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STOREID", k.STOREID);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@REFFNO", k.REFFNO);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@DOCREGNO", k.DOCREGNO);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
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
        public bool updateData(grn k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgrn SET GRNNO=@GRNNO,DATE=@DATE,OFFICER=@OFFICER,GDIV=@GDIV,RECEIVEFROM=@RECEIVEFROM,REMARKS=@REMARKS, "+
                                    " STOREID=@STOREID,PONO=@PONO,CUSTVENDCODE=@CUSTVENDCODE,REFFNO=@REFFNO,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE, "+
                                    " APPROVEBY=@APPROVEBY,CLOSE=@CLOSE,STYLEID=@STYLEID,COLORID=@COLORID,DOCREGNO=@DOCREGNO,JENIS=@JENIS" +
                                    " WHERE GRNNO=@GRNNO";
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@RECEIVEFROM", k.RECEIVEFROM);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STOREID", k.STOREID);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@REFFNO", k.REFFNO);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@DOCREGNO", k.DOCREGNO);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
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
        public bool deleteData(string GRNNO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblgrn WHERE GRNNO = @GRNNO";
                strQuery.Parameters.AddWithValue("@GRNNO", GRNNO);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassStore
{
    class ginCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet prMatIssue(string GINNO)
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
                strQuery.CommandText = "SELECT * FROM tblgin " +
                        " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO" +
                        " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblgin.CUSTVENDCODE" +
                        " WHERE tblgin.GINNO = @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", GINNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgin");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet searchData(string GINNO,string OFFICER,string CUSTOMER,string STYLE,string TYPE)
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
                strQuery.CommandText = "SELECT tblgin.GINNO, tblgin.OFFICER,tblmcustvend.NAME,tblgindetail.STYLEID,tblgin.TYPE from tblgin " +
                            " INNER  JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO "+
                            " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblgin.CUSTVENDCODE "+
                            " GROUP BY tblgin.GINNO, tblgin.OFFICER,tblmcustvend.NAME,tblgindetail.STYLEID,tblgin.TYPE " +
                            " HAVING  tblgin.GINNO LIKE @GINNO AND tblmcustvend.NAME LIKE @CUSTOMER AND tblgin.OFFICER LIKE @OFFICER AND STYLEID LIKE @STYLEID AND TYPE LIKE @TYPE";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@STYLEID", "%" + STYLE + "%");
                strQuery.Parameters.AddWithValue("@CUSTOMER", "%" + CUSTOMER + "%");
                strQuery.Parameters.AddWithValue("@TYPE", "%" + TYPE + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblginsearch");
                Conn.Putus();
            }
            catch
            {
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
                strQuery = new MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE,"+
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                                    " FROM tblgin";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgin");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string GINNO)
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
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE," +
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                                " FROM tblgin WHERE GINNO LIKE @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgin");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string GINNO, string TYPEID, string STAT, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE," +
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                        " FROM tblgin WHERE GINNO LIKE @GINNO AND TYPEID LIKE @TYPEID AND IFNULL(STAT,1) LIKE @STAT " +
                        "AND IFNULL(OFFICER,1) LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgin");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(gin k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblgin VALUES(@GINNO,@GDIV,@DATE,@OFFICER,@DELIVERYTO,@REMARKS," +
                    "@STOREID,@APPROVE,@APPROVEDATE,@APPROVEBY,@CLOSE,@CUSTVENDCODE,@DELIVERYTONAME,@DELIVERYTOADDRESS,@DOCREGNO,@TYPE" +
                    ")";
                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DELIVERYTO", k.DELIVERYTO);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STOREID", k.STOREID);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@DELIVERYTONAME", k.DELIVERYTONAME);
                strQuery.Parameters.AddWithValue("@DELIVERYTOADDRESS", k.DELIVERYTOADDRESS);
                strQuery.Parameters.AddWithValue("@DOCREGNO", k.DOCREGNO);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);


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
        public bool updateData(gin k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                /*
                strQuery.CommandText = "UPDATE tblgin SET GINNO=@GINNO,GDIV=@GDIV,DATE=@DATE,OFFICER=@OFFICER,DELIVERYTO=@DELIVERYTO,REMARKS=@REMARKS,"+
                        "STOREID=@STOREID,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE,APPROVEBY=@APPROVEBY,CLOSE=@CLOSE,CUSTVENDCODE=@CUSTVENDCODE,DELIVERYTONAME=@DELIVERYTONAME,"+
                        "DELIVERYTOADDRESS=@DELIVERYTOADDRESS,DOCREGNO=@DOCREGNO,TYPE=@TYPE,"+
                        " WHERE GINNO=@GINNO";
                 */
                strQuery.CommandText = "UPDATE tblgin SET GINNO=@GINNO,GDIV=@GDIV,DATE=@DATE,OFFICER=@OFFICER,DELIVERYTO=@DELIVERYTO,REMARKS=@REMARKS," +
                    "STOREID=@STOREID,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE,APPROVEBY=@APPROVEBY,CLOSE=@CLOSE,CUSTVENDCODE=@CUSTVENDCODE,DELIVERYTONAME=@DELIVERYTONAME," +
                    "DELIVERYTOADDRESS=@DELIVERYTOADDRESS,DOCREGNO=@DOCREGNO,TYPE=@TYPE " +
        " WHERE GINNO=@GINNO";

                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DELIVERYTO", k.DELIVERYTO);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STOREID", k.STOREID);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@DELIVERYTONAME", k.DELIVERYTONAME);
                strQuery.Parameters.AddWithValue("@DELIVERYTOADDRESS", k.DELIVERYTOADDRESS);
                strQuery.Parameters.AddWithValue("@DOCREGNO", k.DOCREGNO);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);
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
        public bool deleteData(string GINNO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblgin WHERE GINNO = @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", GINNO);
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

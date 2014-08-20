using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassStore
{
    class grndetailCRUD
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
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE," +
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                                    " FROM tblgin";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE," +
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                                " FROM tblgin WHERE GINNO LIKE @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgin");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string ginNO, string TYPEID, string STAT, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = "SELECT GINNO,GDIV,DATE,OFFICER,DELIVERYTO,REMARKS,STOREID,APPROVE,APPROVEDATE," +
                                    "APPROVEBY,CLOSE,CUSTVENDCODE,DELIVERYTONAME,DELIVERYTOADDRESS,DOCREGNO,TYPE" +
                        " FROM tblgin WHERE ginNO LIKE @ginNO AND TYPEID LIKE @TYPEID AND IFNULL(STAT,1) LIKE @STAT " +
                        "AND IFNULL(OFFICER,1) LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@ginNO", "%" + ginNO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgin SET QTYORDER=@QTYORDER,GDIV=@GDIV,TYPEID=@TYPEID,CATEGORYID=@CATEGORYID,STAT=@STAT,DATE=@DATE,OFFICER=@OFFICER," +
                        "ITEMSID=@ITEMSID,CUSTVENDCODE=@CUSTVENDCODE,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE,APPROVEBY=@APPROVEBY,COGS=@COGS,MARGIN=@MARGIN,MARGINVALUE=@MARGINVALUE,NETTPRICE=@NETTPRICE," +
                        "DISCOUNT=@DISCOUNT,DISCOUNTVALUE=@DISCOUNTVALUE,PPN=@PPN,PPNVALUE=@PPNVALUE,SELLINGPRICE=@SELLINGPRICE,KURS=@KURS,VALUEIN=@VALUEIN,REVISE=@REVISE,REVISEDATE=@REVISEDATE,REVISEBY=@REVISEBY" +
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblgin WHERE GINNO = @GINNO";
                strQuery.Parameters.AddWithValue("@CostID", GINNO);
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

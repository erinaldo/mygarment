using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassStore
{
    class gindetailCRUD
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
                strQuery.CommandText = "SELECT GINNO,ITEMSID,COLORID,COSTINGNO,PONO,QUANTITY,UOM,PRICE,"+
                            "CURRENCYID,KURS,REMARKS,STATUSCODA,QTYPURCHASE,UOMPURCHASE" +
                            " FROM tblgindetail";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
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
                strQuery.CommandText = "SELECT GINNO,ITEMSID,COLORID,COSTINGNO,PONO,QUANTITY,UOM,PRICE," +
                            "CURRENCYID,KURS,REMARKS,STATUSCODA,QTYPURCHASE,UOMPURCHASE" +
                                " FROM tblgindetail WHERE GINNO LIKE @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT GINNO,ITEMSID,COLORID,COSTINGNO,PONO,QUANTITY,UOM,PRICE," +
                            "CURRENCYID,KURS,REMARKS,STATUSCODA,QTYPURCHASE,UOMPURCHASE" +
                        " FROM tblgindetail WHERE ginNO LIKE @ginNO AND TYPEID LIKE @TYPEID AND IFNULL(STAT,1) LIKE @STAT " +
                        "AND IFNULL(OFFICER,1) LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@ginNO", "%" + GINNO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(gindetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblgindetail VALUES(GINNO=@GINNO,ITEMSID=@ITEMSID,COLORID=@COLORID,"+
                        "COSTINGNO=@COSTINGNO,PONO=@PONO,QUANTITY=@QUANTITY,UOM=@UOM,PRICE=@PRICE,CURRENCYID=@CURRENCYID,"+
                        "KURS=@KURS,REMARKS=@REMARKS,STATUSCODA=@STATUSCODA,QTYPURCHASE=@QTYPURCHASE,UOMPURCHASE=@UOMPURCHASE" +
                        ")";
                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STATUSCODA", k.STATUSCODA);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);


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
        public bool updateData(gindetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgindetail SET ITEMSID=@ITEMSID,COLORID=@COLORID," +
                        "COSTINGNO=@COSTINGNO,PONO=@PONO,QUANTITY=@QUANTITY,UOM=@UOM,PRICE=@PRICE,CURRENCYID=@CURRENCYID," +
                        "KURS=@KURS,REMARKS=@REMARKS,STATUSCODA=@STATUSCODA,QTYPURCHASE=@QTYPURCHASE,UOMPURCHASE=@UOMPURCHASE" +
                        " WHERE GINNO=@GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@STATUSCODA", k.STATUSCODA);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);
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
                strQuery.CommandText = "DELETE FROM tblgindetail WHERE GINNO = @GINNO";
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

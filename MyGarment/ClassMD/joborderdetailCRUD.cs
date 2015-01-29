using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassMD
{
    class joborderdetailCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet prCosting(string ORDERNO)
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
                /*
                strQuery.CommandText = "SELECT * FROM tbljoborderdetail " +
                        "INNER JOIN tbljoborderdetaildetail ON tbljoborderdetail.COSTINGNO=tbljoborderdetaildetail.COSTINGNO" +
                        " WHERE tbljoborderdetail.COSTINGNO = @COSTINGNO";
                 */
                strQuery.CommandText = "";

                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborderdetail");
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
                strQuery = new MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "FROM tbljoborderdetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborderdetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string ORDERNO)
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
                strQuery.CommandText = " SELECT * FROM tbljoborderdetail WHERE ORDERNO=@ORDERNO";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborderdetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string COSTINGNO, string TYPEID, string STAT, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = "SELECT  LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@COSTINGNO", "%" + COSTINGNO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborderdetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(joborderdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbljoborderdetail (ORDERNO,POCUSTOMER,COLORID,SIZEID,NOURUT,DELIVERY,QUANTITY,CUTTINGQTY,ALLOWANCE,DESTINATION) "+
                        " VALUES(@ORDERNO,@POCUSTOMER,@COLORID,@SIZEID,@NOURUT,@DELIVERY,@QUANTITY,@CUTTINGQTY,@ALLOWANCE,@DESTINATION)";
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@POCUSTOMER", k.POCUSTOMER);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@NOURUT", k.NOURUT);
                strQuery.Parameters.AddWithValue("@DELIVERY", k.DELIVERY);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@CUTTINGQTY", k.CUTTINGQTY);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@DESTINATION", k.DESTINATION);

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
        public bool updateData(joborderdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbljoborderdetail SET ORDERNO=@ORDERNO,COLORID=@COLORID,SIZEID=@SIZEID,POCUSTOMER=@POCUSTOMER,NOURUT=@NOURUT,DELIVERY=@DELIVERY,QUANTITY=@QUANTITY,CUTTINGQTY=@CUTTINGQTY,ALLOWANCE=@ALLOWANCE,DESTINATION=@DESTINATION" +
                        " WHERE ORDERNO=@ORDERNO AND COLORID=@COLORID AND SIZEID=@SIZEID AND POCUSTOMER=@POCUSTOMER ";
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@POCUSTOMER", k.POCUSTOMER);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@NOURUT", k.NOURUT);
                strQuery.Parameters.AddWithValue("@DELIVERY", k.DELIVERY);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@CUTTINGQTY", k.CUTTINGQTY);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@DESTINATION", k.DESTINATION);
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
        public bool deleteData(string ORDERNO,string POCUSTOMER,string COLORID,string SIZEID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbljoborderdetail WHERE ORDERNO = @ORDERNO AND POCUSTOMER=@POCUSTOMER AND COLORID=@COLORID AND SIZEID=@SIZEID ";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                strQuery.Parameters.AddWithValue("@POCUSTOMER", POCUSTOMER);
                strQuery.Parameters.AddWithValue("@COLORID", COLORID);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMD
{
    class joborderCRUD
    {

        private MySqlCommand strQuery = null;

        public DataSet getSize(string ORDERNO)
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
                strQuery.CommandText = "SELECT tblproductionsize.STYLEID,tbljoborder.ITEMSID,tbljoborderdetail.SIZEID,tbljoborderdetail.CUTTINGQTY,tbljoborderdetail.NOURUT,tblproductionsize.RATIO " +
                        " FROM tbljoborder "+
                        " INNER JOIN tbljoborderdetail ON tbljoborder.ORDERNO=tbljoborderdetail.ORDERNO"+
                        " LEFT JOIN tblproductionsize ON tblproductionsize.STYLEID=tbljoborder.ITEMSID AND tblproductionsize.SIZEID=tbljoborderdetail.SIZEID " +
                        " WHERE tbljoborder.ORDERNO=@ORDERNO" +
                        " GROUP BY  tbljoborder.ORDERNO,tbljoborderdetail.SIZEID"+
                        " ORDER BY NOURUT ";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }


        public DataSet getColor(string ORDERNO)
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
                strQuery.CommandText = "SELECT tblproduction.JONO,tblproduction.STYLEID,tbljoborder.ORDERNO,tbljoborder.ITEMSID,tbljoborderdetail.COLORID,tblproduction.DELIVERYDATE,tblproduction.STARTDATE,tblproduction.CLOSEDATE " +
                    " FROM tbljoborder "+
                    "INNER JOIN tbljoborderdetail ON tbljoborder.ORDERNO=tbljoborderdetail.ORDERNO "+
                    " LEFT JOIN tblproduction ON tblproduction.JONO=tbljoborder.ORDERNO and tbljoborderdetail.COLORID=tblproduction.COLORID "+
                    " WHERE tbljoborder.ORDERNO=@ORDERNO "+
                    " GROUP BY  tbljoborder.ORDERNO,tbljoborderdetail.COLORID ";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }


        public DataSet getGarment(string ORDERNO)
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
                strQuery.CommandText = "SELECT *  FROM tbljoborder INNER JOIN tblcosting ON tblcosting.ITEMSID=tbljoborder.ITEMSID WHERE ORDERNO = @ORDERNO";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prJobOrder(string ORDERNO)
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
                strQuery.CommandText = "SELECT * FROM tbljoborder "+
                    " INNER JOIN tbljoborderdetail ON tbljoborderdetail.ORDERNO=tbljoborder.ORDERNO"+
                    " INNER  JOIN tblmitems ON tblmitems.ITEMSID=tbljoborder.ITEMSID"+
                    " INNER JOIN tblmcategory ON tblmcategory.CATEGORYID=tbljoborder.CATEGORYID"+
                    " INNER JOIN tblmtype ON tblmtype.TYPEID=tbljoborder.TYPEID"+
                    " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tbljoborder.CUSTVENDCODE"+
                    " WHERE tbljoborder.ORDERNO=@ORDERNO ORDER BY tbljoborderdetail.NOURUT DESC";

                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                strQuery.CommandText = " SELECT * FROM tbljoborder WHERE ORDERNO LIKE @ORDERNO";
                strQuery.Parameters.AddWithValue("@ORDERNO", "%" + ORDERNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string ORDERNO, string ITEMSID, string POCUSTOMER, string OFFICER, string NAME)
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
                strQuery.CommandText = " SELECT tbljoborder.ORDERNO,tbljoborder.ITEMSID,tbljoborder.POCUSTOMER,tbljoborder.OFFICER, tblmcustvend.NAME "+
                        " FROM  tbljoborder "+
                        " INNER JOIN tblmcustvend ON tbljoborder.CUSTVENDCODE=tblmcustvend.CUSTVENDCODE "+
                        " WHERE ORDERNO LIKE @ORDERNO AND" +
                        " ITEMSID LIKE @ITEMSID AND POCUSTOMER LIKE @POCUSTOMER" +
                        " AND OFFICER LIKE @OFFICER AND NAME LIKE @NAME  ";
                strQuery.Parameters.AddWithValue("@ORDERNO", "%" + ORDERNO + "%");
                strQuery.Parameters.AddWithValue("@ITEMSID", "%" + ITEMSID + "%");
                strQuery.Parameters.AddWithValue("@POCUSTOMER", "%" + POCUSTOMER + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@NAME", "%" + NAME + "%");

                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }



        public DataSet getData(string ORDERNO,string ITEMSID, string TYPEID, string GDIV, string CATEGORYID,string POCUSTOMER, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = " SELECT * FROM tbljoborder WHERE ORDERNO LIKE @ORDERNO AND" +
                         " ITEMSID LIKE @ITEMSID AND GDIV LIKE @GDIV AND TYPEID LIKE @TYPEID AND CATEGORYID LIKE @CATEGORYID AND POCUSTOMER LIKE @POCUSTOMER" +
                         " AND OFFICER LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE ";
                strQuery.Parameters.AddWithValue("@ORDERNO", "%" + ORDERNO + "%");
                strQuery.Parameters.AddWithValue("@ITEMSID", "%" + ITEMSID + "%");
                strQuery.Parameters.AddWithValue("@GDIV", "%" + GDIV + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@CATEGORYID", "%" + CATEGORYID + "%");
                strQuery.Parameters.AddWithValue("@POCUSTOMER", "%" + POCUSTOMER + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");

                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbljoborder");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(joborder k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbljoborder(ORDERNO,QUANTITY,ITEMSID,GDIV,POCUSTOMER,TYPEID,CATEGORYID,DATE,OFFICER,CUSTVENDCODE,ADDRESS,DELIVERYDATE,DELIVERY,REMARKS,APPROVE,APPROVEDATE,APPROVEBY,WASH) " +
                        " VALUES(@ORDERNO,@QUANTITY,@ITEMSID,@GDIV,@POCUSTOMER,@TYPEID,@CATEGORYID,@DATE,@OFFICER,@CUSTVENDCODE,@ADDRESS,@DELIVERYDATE,@DELIVERY,@REMARKS,@APPROVE,@APPROVEDATE,@APPROVEBY,@WASH)";
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@TYPEID", k.TYPEID);
                strQuery.Parameters.AddWithValue("@CATEGORYID", k.CATEGORYID);
                strQuery.Parameters.AddWithValue("@POCUSTOMER", k.POCUSTOMER);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@DELIVERYDATE", k.DELIVERYDATE);
                strQuery.Parameters.AddWithValue("@DELIVERY", k.DELIVERY);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@WASH", k.WASH);
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
        public bool updateData(joborder k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbljoborder SET ORDERNO=@ORDERNO,QUANTITY=@QUANTITY,ITEMSID=@ITEMSID,GDIV=@GDIV, " +
                        " POCUSTOMER=@POCUSTOMER,TYPEID=@TYPEID,CATEGORYID=@CATEGORYID,DATE=@DATE,OFFICER=@OFFICER,CUSTVENDCODE=@CUSTVENDCODE,ADDRESS=@ADDRESS," +
                        " DELIVERYDATE=@DELIVERYDATE,DELIVERY=@DELIVERY,REMARKS=@REMARKS,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE, "+
                        " APPROVEBY=@APPROVEBY,WASH=@WASH" +
                        " WHERE ORDERNO=@ORDERNO";
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@TYPEID", k.TYPEID);
                strQuery.Parameters.AddWithValue("@CATEGORYID", k.CATEGORYID);
                strQuery.Parameters.AddWithValue("@POCUSTOMER", k.POCUSTOMER);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@DELIVERYDATE", k.DELIVERYDATE);
                strQuery.Parameters.AddWithValue("@DELIVERY", k.DELIVERY);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@WASH", k.WASH);

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
        public bool deleteData(string ORDERNO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbljoborder WHERE ORDERNO = @ORDERNO";
                strQuery.Parameters.AddWithValue("@ORDERNO", ORDERNO);
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

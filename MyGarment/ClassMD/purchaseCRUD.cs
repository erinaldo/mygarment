using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace MyGarment.ClassMD
{
    class purchaseCRUD
    {
        private MySqlCommand strQuery = null;


        public DataSet cekBudget(string PONO)
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
                strQuery.CommandText = "SELECT COSTINGNO,ID,DESCRIPTION,SUM(budget) BUDGET,SUM(PO) PO, SUM(POALL)-SUM(PO) POLAST ,SUM(POALL) POALL,SUM(budget)- SUM(POALL) OVER "+
                            "FROM( "+
                            "SELECT tblcosting.costingno,tblcostingdetail.id,tblcostingdetail.description, "+
                            "consumption*tblcostingdetail.price*qtyorder*tblcostingdetail.kurs as budget,0 as PO, 0 as POALL "+
                            "FROM tblcosting "+
                            "INNER JOIN tblcostingdetail ON tblcosting.COSTINGNO=tblcostingdetail.COSTINGNO "+
                            "INNER JOIN tblpurchasedetail ON tblpurchasedetail.COSTINGNO=tblcostingdetail.COSTINGNO AND tblpurchasedetail.COSTINGID=tblcostingdetail.ID "+
                            "WHERE PONO=@PONO " +
                            "GROUP BY tblcosting.costingno,tblcostingdetail.id "+
                            "UNION ALL "+
                            "SELECT tblpurchasedetail.COSTINGNO,tblpurchasedetail.Costingid,tblcostingdetail.DESCRIPTION,0 as Budget, "+
                            "SUM(tblpurchasedetail.price*tblpurchasedetail.quantity*tblpurchasedetail.kurs) PO,0 as POALL "+
                            "FROM tblpurchase "+
                            "INNER JOIN  tblpurchasedetail ON tblpurchase.pono=tblpurchasedetail.pono "+
                            "INNER JOIN tblcostingdetail ON tblpurchasedetail.COSTINGNO=tblcostingdetail.COSTINGNO AND tblpurchasedetail.COSTINGID=tblcostingdetail.ID "+
                            "WHERE tblpurchase.PONO=@PONO " +
                            "GROUP BY tblpurchasedetail.COSTINGNO,tblpurchasedetail.Costingid "+
                            "UNION ALL "+
                            "SELECT tblpurchasedetail.COSTINGNO,tblpurchasedetail.Costingid,tblcostingdetail.DESCRIPTION, 0 as Budget,0 as PO, "+
                            "SUM(tblpurchasedetail.price*tblpurchasedetail.quantity*tblpurchasedetail.kurs) POALL "+
                            "FROM tblpurchase "+
                            "INNER JOIN tblpurchasedetail ON tblpurchase.PONO=tblpurchasedetail.PONO "+
                            "INNER JOIN tblcostingdetail ON tblpurchasedetail.COSTINGNO=tblcostingdetail.COSTINGNO AND tblpurchasedetail.COSTINGID=tblcostingdetail.ID "+
                            "INNER JOIN "+
                            "(SELECT COSTINGNO,COSTINGID FROM tblpurchasedetail where PONO=@PONO " +
                            "GROUP BY COSTINGNO,COSTINGID)DT "+
                            "ON tblpurchasedetail.COSTINGNO=DT.COSTINGNO AND tblpurchasedetail.COSTINGID=DT.COSTINGID "+
                            "GROUP BY tblpurchasedetail.COSTINGNO,tblpurchasedetail.Costingid,tblcostingdetail.DESCRIPTION " +
                            ") DATA "+
                            "GROUP BY COSTINGNO,ID,DESCRIPTION";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchase");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;

        }


        public DataSet prPONO(string PONO)
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
                strQuery.CommandText = "SELECT * FROM tblpurchase "+
                       " INNER JOIN tblpurchasedetail ON tblpurchase.PONO=tblpurchasedetail.PONO"+
                       " INNER JOIN tblmcustvend ON tblpurchase.CUSTVENDID=tblmcustvend.CUSTVENDCODE "+
                       " INNER JOIN tblmcustvend Delivery ON tblpurchase.DELIVERYTO=Delivery.CUSTVENDCODE "+
                       " INNER JOIN tblmcurrency ON tblmcurrency.CURRENCYID=tblpurchase.CURRENCYID "+
                       " INNER JOIN tblmuom ON tblmuom.UOMID=tblpurchasedetail.UOM "+
                       " WHERE tblpurchase.PONo=@PONO";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchase");
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
                strQuery.CommandText = "PONO,DATE,OFFICER,GDIV,CUSTVENDID,DELIVERYTONAME,DELIVERYTOADDRESS,"+
                    "TERMOFPAYMENT,APPROVE,APPROVEDATE,APPROVEBY,CLOSE,REMARKS,ACKNOWLEDGEMENT,ACKNOWLEDGEMENTDATE" +
                    ",ACKNOWLEDGEMENTBY,TOTALAMOUNT,TOTALDISCOUNT,TOTALPPN,CURRENCYID,CHECKED,CHECKDATE,CHECKBY,NOTE " +
                    ",ETA,REFERTO,TOTALPAID,REVISE,REVISEDATE,REVISEBY,NONREQ,TOTALUPCHARGES,ETD,DUEDATE,SHIPMODA,REVISEDUEDATE,PURCHASE,PPN,DISCOUNT" +
                    " FROM tblpurchase";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchase");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string PONO)
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
                strQuery.CommandText = "SELECT PONO,DATE,OFFICER,GDIV,CUSTVENDID,DELIVERYTONAME,DELIVERYTOADDRESS," +
                    "TERMOFPAYMENT,APPROVE,APPROVEDATE,APPROVEBY,CLOSE,REMARKS,ACKNOWLEDGEMENT,ACKNOWLEDGEMENTDATE" +
                    ",ACKNOWLEDGEMENTBY,TOTALAMOUNT,TOTALDISCOUNT,TOTALPPN,CURRENCYID,CHECKED,CHECKDATE,CHECKBY,NOTE " +
                    ",ETA,REFERTO,TOTALPAID,REVISE,REVISEDATE,REVISEBY,NONREQ,TOTALUPCHARGES,ETD,DUEDATE,SHIPMODA,REVISEDUEDATE,PPN,KURS" +
                        " FROM tblpurchase WHERE PONO LIKE @PONO";
                 */
                strQuery.CommandText = "SELECT *" +
                        " FROM tblpurchase WHERE PONO LIKE @PONO";

                strQuery.Parameters.AddWithValue("@PONO", "%" + PONO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchase");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string PONO, string TYPEID, string STAT, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = "SELECT PONO,DATE,OFFICER,GDIV,CUSTVENDID,DELIVERYTONAME,DELIVERYTOADDRESS,"+
                        "TERMOFPAYMENT,APPROVE,APPROVEDATE,APPROVEBY,CLOSE,REMARKS,ACKNOWLEDGEMENT,ACKNOWLEDGEMENTDATE" +
                        ",ACKNOWLEDGEMENTBY,TOTALAMOUNT,TOTALDISCOUNT,TOTALPPN,CURRENCYID,CHECKED,CHECKDATE,CHECKBY,NOTE " +
                        ",ETA,REFERTO,TOTALPAID,REVISE,REVISEDATE,REVISEBY,NONREQ,TOTALUPCHARGES,ETD,DUEDATE,SHIPMODA,REVISEDUEDATE" +
                        " FROM tblpurchase WHERE COSTINGNO LIKE @COSTINGNO AND TYPEID LIKE @TYPEID AND IFNULL(STAT,1) LIKE @STAT " +
                        "AND IFNULL(OFFICER,1) LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@COSTINGNO", "%" + PONO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchase");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(purchase k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblpurchase(PONO,DATE,OFFICER,GDIV,CUSTVENDID,DELIVERYTO,DELIVERYTONAME,DELIVERYTOADDRESS," +
                            "TERMOFPAYMENT,APPROVE,APPROVEDATE,APPROVEBY,CLOSE,REMARKS,ACKNOWLEDGEMENT,ACKNOWLEDGEMENTDATE,ACKNOWLEDGEMENTBY,TOTALAMOUNT," +
                            "TOTALDISCOUNT,TOTALPPN,CURRENCYID,CHECKED,CHECKDATE,CHECKBY,NOTE,ETA,REFERTO,TOTALPAID,REVISE,REVISEDATE,REVISEBY," +
                            "NONREQ,TOTALUPCHARGES,ETD,DUEDATE,SHIPMODA,REVISEDUEDATE,PPN,DISCOUNT,KURS) " +
                            "VALUES(@PONO,@DATE,@OFFICER,@GDIV,@CUSTVENDID,@DELIVERYTO,@DELIVERYTONAME,@DELIVERYTOADDRESS," +
                            "@TERMOFPAYMENT,@APPROVE,@APPROVEDATE,@APPROVEBY,@CLOSE,@REMARKS,@ACKNOWLEDGEMENT,@ACKNOWLEDGEMENTDATE,@ACKNOWLEDGEMENTBY,@TOTALAMOUNT," +
                            "@TOTALDISCOUNT,@TOTALPPN,@CURRENCYID,@CHECKED,@CHECKDATE,@CHECKBY,@NOTE,@ETA,@REFERTO,@TOTALPAID,@REVISE,@REVISEDATE,@REVISEBY,"+
                            "@NONREQ,@TOTALUPCHARGES,@ETD,@DUEDATE,@SHIPMODA,@REVISEDUEDATE,@PPN,@DISCOUNT,@KURS)";
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@CUSTVENDID", k.CUSTVENDID);
                strQuery.Parameters.AddWithValue("@DELIVERYTO", k.DELIVERYTO);
                strQuery.Parameters.AddWithValue("@DELIVERYTONAME", k.DELIVERYTONAME);
                strQuery.Parameters.AddWithValue("@DELIVERYTOADDRESS", k.DELIVERYTOADDRESS);
                strQuery.Parameters.AddWithValue("@TERMOFPAYMENT", k.TERMOFPAYMENT);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENT", k.ACKNOWLEDGEMENT);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENTDATE", k.ACKNOWLEDGEMENTDATE);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENTBY", k.ACKNOWLEDGEMENTBY);
                strQuery.Parameters.AddWithValue("@TOTALAMOUNT", k.TOTALAMOUNT);
                strQuery.Parameters.AddWithValue("@TOTALDISCOUNT", k.TOTALDISCOUNT);
                strQuery.Parameters.AddWithValue("@TOTALPPN", k.TOTALPPN);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@CHECKED", k.CHECKED);
                strQuery.Parameters.AddWithValue("@CHECKDATE", k.CHECKDATE);
                strQuery.Parameters.AddWithValue("@CHECKBY", k.CHECKBY);
                strQuery.Parameters.AddWithValue("@NOTE", k.NOTE);
                strQuery.Parameters.AddWithValue("@ETA", k.ETA);
                strQuery.Parameters.AddWithValue("@REFERTO", k.REFERTO);
                strQuery.Parameters.AddWithValue("@TOTALPAID", k.TOTALPAID);
                strQuery.Parameters.AddWithValue("@REVISE", k.REVISE);
                strQuery.Parameters.AddWithValue("@REVISEDATE", k.REVISEDATE);
                strQuery.Parameters.AddWithValue("@REVISEBY", k.REVISEBY);
                strQuery.Parameters.AddWithValue("@NONREQ", k.NONREQ);
                strQuery.Parameters.AddWithValue("@TOTALUPCHARGES", k.TOTALUPCHARGES);
                strQuery.Parameters.AddWithValue("@ETD", k.ETD);
                strQuery.Parameters.AddWithValue("@DUEDATE", k.DUEDATE);
                strQuery.Parameters.AddWithValue("@SHIPMODA", k.SHIPMODA);
                strQuery.Parameters.AddWithValue("@REVISEDUEDATE", k.REVISEDUEDATE);
                strQuery.Parameters.AddWithValue("@PPN", k.PPN);
                strQuery.Parameters.AddWithValue("@DISCOUNT", k.DISCOUNT);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);

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
        public bool updateData(purchase k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblpurchase SET PONO=@PONO,DATE=@DATE,OFFICER=@OFFICER,GDIV=@GDIV,CUSTVENDID=@CUSTVENDID," +
                        "DELIVERYTO=@DELIVERYTO,DELIVERYTONAME=@DELIVERYTONAME,DELIVERYTOADDRESS=@DELIVERYTOADDRESS,TERMOFPAYMENT=@TERMOFPAYMENT,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE," +
                        "APPROVEBY=@APPROVEBY,CLOSE=@CLOSE,REMARKS=@REMARKS,ACKNOWLEDGEMENT=@ACKNOWLEDGEMENT,ACKNOWLEDGEMENTDATE=@ACKNOWLEDGEMENTDATE,ACKNOWLEDGEMENTBY=@ACKNOWLEDGEMENTBY,"+
                        "TOTALAMOUNT=@TOTALAMOUNT,TOTALDISCOUNT=@TOTALDISCOUNT,TOTALPPN=@TOTALPPN,CURRENCYID=@CURRENCYID,CHECKED=@CHECKED,CHECKDATE=@CHECKDATE,"+
                        "CHECKBY=@CHECKBY,NOTE=@NOTE,ETA=@ETA,REFERTO=@REFERTO,TOTALPAID=@TOTALPAID,REVISE=@REVISE,REVISEDATE=@REVISEDATE,REVISEBY=@REVISEBY,"+
                        "NONREQ=@NONREQ,TOTALUPCHARGES=@TOTALUPCHARGES,ETD=@ETD,DUEDATE=@DUEDATE,SHIPMODA=@SHIPMODA,REVISEDUEDATE=@REVISEDUEDATE,PPN=@PPN,DISCOUNT=@DISCOUNT,KURS=@KURS" +
                        " WHERE PONO=@PONO";
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@GDIV", k.GDIV);
                strQuery.Parameters.AddWithValue("@CUSTVENDID", k.CUSTVENDID);
                strQuery.Parameters.AddWithValue("@DELIVERYTO", k.DELIVERYTO);
                strQuery.Parameters.AddWithValue("@DELIVERYTONAME", k.DELIVERYTONAME);
                strQuery.Parameters.AddWithValue("@DELIVERYTOADDRESS", k.DELIVERYTOADDRESS);
                strQuery.Parameters.AddWithValue("@TERMOFPAYMENT", k.TERMOFPAYMENT);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.Parameters.AddWithValue("@CLOSE", k.CLOSE);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENT", k.ACKNOWLEDGEMENT);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENTDATE", k.ACKNOWLEDGEMENTDATE);
                strQuery.Parameters.AddWithValue("@ACKNOWLEDGEMENTBY", k.ACKNOWLEDGEMENTBY);
                strQuery.Parameters.AddWithValue("@TOTALAMOUNT", k.TOTALAMOUNT);
                strQuery.Parameters.AddWithValue("@TOTALDISCOUNT", k.TOTALDISCOUNT);
                strQuery.Parameters.AddWithValue("@TOTALPPN", k.TOTALPPN);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@CHECKED", k.CHECKED);
                strQuery.Parameters.AddWithValue("@CHECKDATE", k.CHECKDATE);
                strQuery.Parameters.AddWithValue("@CHECKBY", k.CHECKBY);
                strQuery.Parameters.AddWithValue("@NOTE", k.NOTE);
                strQuery.Parameters.AddWithValue("@ETA", k.ETA);
                strQuery.Parameters.AddWithValue("@REFERTO", k.REFERTO);
                strQuery.Parameters.AddWithValue("@TOTALPAID", k.TOTALPAID);
                strQuery.Parameters.AddWithValue("@REVISE", k.REVISE);
                strQuery.Parameters.AddWithValue("@REVISEDATE", k.REVISEDATE);
                strQuery.Parameters.AddWithValue("@REVISEBY", k.REVISEBY);
                strQuery.Parameters.AddWithValue("@NONREQ", k.NONREQ);
                strQuery.Parameters.AddWithValue("@TOTALUPCHARGES", k.TOTALUPCHARGES);
                strQuery.Parameters.AddWithValue("@ETD", k.ETD);
                strQuery.Parameters.AddWithValue("@DUEDATE", k.DUEDATE);
                strQuery.Parameters.AddWithValue("@SHIPMODA", k.SHIPMODA);
                strQuery.Parameters.AddWithValue("@REVISEDUEDATE", k.REVISEDUEDATE);
                strQuery.Parameters.AddWithValue("@PPN", k.PPN);
                strQuery.Parameters.AddWithValue("@DISCOUNT", k.DISCOUNT);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
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
        public bool deleteData(string PONO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblpurchase WHERE PONO = @PONO";
                strQuery.Parameters.AddWithValue("@CostID", PONO);
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

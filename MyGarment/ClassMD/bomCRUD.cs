using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMD
{
    class bomCRUD
    {
        private MySql.Data.MySqlClient.MySqlCommand strQuery = null;


        public DataSet prBOM(string COSTINGNO)
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
                /*
                strQuery.CommandText = "SELECT * FROM tblcosting " +
                        "INNER JOIN tblcostingdetail ON tblcosting.COSTINGNO=tblcostingdetail.COSTINGNO " +
                        "LEFT JOIN tblbom ON tblcosting.COSTINGNO=tblbom.COSTINGNO AND tblcostingdetail.ID=tblbom.ID " +
                        " INNER  JOIN tblmitems ON tblmitems.ITEMSID=tblcosting.ITEMSID" +
                        " LEFT JOIN tblmitems tblmitems1 ON tblmitems1.ITEMSID=tblbom.ITEMSID " +
                        " INNER JOIN tblmcategory ON tblmcategory.CATEGORYID=tblcosting.CATEGORYID" +
                        " INNER JOIN tblmtype ON tblmtype.TYPEID=tblcosting.TYPEID" +
                        " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblcosting.CUSTVENDCODE" +
                        " INNER JOIN tblmcost ON tblmcost.COSTID=tblcostingdetail.COSTID" +
                        " LEFT JOIN tbljoborder ON tblcosting.JONO=tbljoborder.ORDERNO" +
                        " WHERE tblcosting.COSTINGNO = @COSTINGNO";
                */
                strQuery.CommandText = "SELECT * FROM tblcosting " +
                        "INNER JOIN tblcostingdetail ON tblcosting.COSTINGNO=tblcostingdetail.COSTINGNO " +
                        "LEFT JOIN tblbom ON tblcosting.COSTINGNO=tblbom.COSTINGNO AND tblcostingdetail.ID=tblbom.ID " +
                        " INNER  JOIN tblmitems ON tblmitems.ITEMSID=tblcosting.ITEMSID" +
                        " INNER JOIN tblmitems tblmitems1 ON tblmitems1.ITEMSID=tblbom.ITEMSID " +
                        " INNER JOIN tblmcategory ON tblmcategory.CATEGORYID=tblcosting.CATEGORYID" +
                        " INNER JOIN tblmtype ON tblmtype.TYPEID=tblcosting.TYPEID" +
                        " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblcosting.CUSTVENDCODE" +
                        " INNER JOIN tblmcost ON tblmcost.COSTID=tblcostingdetail.COSTID" +
                        " LEFT JOIN tbljoborder ON tblcosting.JONO=tbljoborder.ORDERNO" +
                        " WHERE tblcosting.COSTINGNO = @COSTINGNO";

                strQuery.Parameters.AddWithValue("@COSTINGNO", COSTINGNO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblcosting");
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
                strQuery.CommandText = "SELECT * " +
                                        " FROM tblbom";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblbom");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string COSTINGNO,int ID)
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
                        " FROM tblbom WHERE COSTINGNO=@COSTINGNO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@COSTINGNO",COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID",ID);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblbom");
                Conn.Putus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(bom k)
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
                strQuery.CommandText = "";
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@CONSUMPTION", k.CONSUMPTION);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@QTYORDER", k.QTYORDER);
                strQuery.Parameters.AddWithValue("@TOTCONSUMPTION", k.TOTCONSUMPTION);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@SUPPLIER", k.SUPPLIER);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QTYPO", k.QTYPO);
                strQuery.Parameters.AddWithValue("@QTYSTORE", k.QTYSTORE);

                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblbom");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(bom k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblbom(COSTINGNO,ID,COLORID,SIZEID,ITEMSID,ORDERNO,REMARKS,CONSUMPTION,ALLOWANCE,QTYORDER,TOTCONSUMPTION,UOM,SUPPLIER,PONO,QTYSTORE,QTYPO) " +
                        "VALUES(@COSTINGNO,@ID,@COLORID,@SIZEID,@ITEMSID,@ORDERNO,@REMARKS,@CONSUMPTION,@ALLOWANCE,@QTYORDER,@TOTCONSUMPTION,@UOM,@SUPPLIER,@PONO,@QTYSTORE,@QTYPO)";
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@CONSUMPTION", k.CONSUMPTION);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@QTYORDER", k.QTYORDER);
                strQuery.Parameters.AddWithValue("@TOTCONSUMPTION", k.TOTCONSUMPTION);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@SUPPLIER", k.SUPPLIER);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QTYPO", k.QTYPO);
                strQuery.Parameters.AddWithValue("@QTYSTORE", k.QTYSTORE);



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
        public bool updateData(bom k,string CostingNo,int ID,string ColorID,string SizeID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblbom SET COSTINGNO=@COSTINGNO,ID=@ID,COLORID=@COLORID,SIZEID=@SIZEID,ITEMSID=@ITEMSID,ORDERNO=ORDERNO,REMARKS=@REMARKS, " +
                                " CONSUMPTION=@CONSUMPTION,ALLOWANCE=@ALLOWANCE,QTYORDER=@QTYORDER,TOTCONSUMPTION=@TOTCONSUMPTION,UOM=@UOM,SUPPLIER=@SUPPLIER, "+
                                " PONO=@PONO,QTYSTORE=@QTYSTORE,QTYPO=@QTYPO" +
                                " WHERE COSTINGNO=@COSTINGNO1 AND ID=@ID1 AND COLORID=@COLORID1 AND SIZEID=@SIZEID1 ";
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);  strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);      strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);      strQuery.Parameters.AddWithValue("@ORDERNO", k.ORDERNO);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@CONSUMPTION", k.CONSUMPTION);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@QTYORDER", k.QTYORDER);
                strQuery.Parameters.AddWithValue("@TOTCONSUMPTION", k.TOTCONSUMPTION);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@SUPPLIER", k.SUPPLIER);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QTYPO", k.QTYPO);
                strQuery.Parameters.AddWithValue("@QTYSTORE", k.QTYSTORE);
                //key
                strQuery.Parameters.AddWithValue("@COSTINGNO1", CostingNo); strQuery.Parameters.AddWithValue("@ID1", ID);
                strQuery.Parameters.AddWithValue("@COLORID1", ColorID); strQuery.Parameters.AddWithValue("@SIZEID1", SizeID);


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
        public bool deleteData(string COSTINGNO,int ID, string COLORID,string SIZEID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblbom WHERE COSTINGNO=@COSTINGNO AND ID=@ID AND COLORID=@COLORID AND SIZEID=@SIZEID";
                strQuery.Parameters.AddWithValue("@COSTINGNO",COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID", ID);
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

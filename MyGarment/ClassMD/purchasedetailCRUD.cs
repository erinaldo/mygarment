using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMD
{
    class purchasedetailCRUD
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
                strQuery.CommandText = "PONO,ID,COSTINGNO,COSTINGID,COSTINGDESC,MATERIALTYPEID,ITEMSID,DESCRIPTIN,QUANTITY,UOM,PRICE,QTYPURCHASE,UOMPURCHASE,PRICEPURCHASE,TOTAL,CURRENCYID,KURS,DISCOUNT,PPN" +
                                       " FROM tblpurchasedetail";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchasedetail");
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
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Conn.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT PONO,ID,COSTINGNO,COSTINGID,COSTINGDESC,MATERIALTYPEID,ITEMSID,DESCRIPTION,QUANTITY,UOM,PRICE,QTYPURCHASE,UOMPURCHASE,PRICEPURCHASE,TOTAL,CURRENCYID,KURS,DISCOUNT,PPN,CONVER" +
                                       " FROM tblpurchasedetail WHERE PONO=@PONO";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchasedetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getDataGrn(string PONO)
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
                strQuery.CommandText = "SELECT PONO,ID,tblpurchasedetail.COSTINGNO,COSTINGID,COSTINGDESC,MATERIALTYPEID,tblpurchasedetail.ITEMSID,DESCRIPTION,QUANTITY,UOM,PRICE,QTYPURCHASE,UOMPURCHASE,PRICEPURCHASE,TOTAL,CURRENCYID,tblpurchasedetail.KURS,tblpurchasedetail.DISCOUNT,tblpurchasedetail.PPN,CONVER,tblcosting.ITEMSID AS STYLEID"+
                                       " FROM tblpurchasedetail "+
                                       " LEFT JOIN tblcosting ON tblcosting.COSTINGNO=tblpurchasedetail.COSTINGNO "+
                                       " WHERE PONO=@PONO";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchasedetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }


        public DataSet getData(string PONO,int ID)
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
                strQuery.CommandText = "SELECT PONO,ID,COSTINGNO,COSTINGID,COSTINGDESC,MATERIALTYPEID,ITEMSID,DESCRIPTION,QUANTITY,UOM,PRICE,QTYPURCHASE,UOMPURCHASE,PRICEPURCHASE,TOTAL,CURRENCYID,KURS,DISCOUNT,PPN,CONVER" +
                                       " FROM tblpurchasedetail WHERE PONO=@PONO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
                strQuery.Parameters.AddWithValue("@ID", ID);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblpurchasedetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(purchasedetail k)
        {
            bool stat = false;
            Connection ConnG = new Connection();
            try
            {

                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblpurchasedetail(PONO,ID,COSTINGNO,COSTINGID,COSTINGDESC,MATERIALTYPEID,ITEMSID,DESCRIPTION,QUANTITY,UOM, PRICE,QTYPURCHASE,UOMPURCHASE,PRICEPURCHASE,TOTAL,CURRENCYID,KURS,DISCOUNT,PPN,CONVER)"+ 
                                        " VALUES(@PONO,@ID,@COSTINGNO,@COSTINGID,@COSTINGDESC,@MATERIALTYPEID,@ITEMSID,@DESCRIPTION,@QUANTITY,@UOM," +
                                        "@PRICE,@QTYPURCHASE,@UOMPURCHASE,@PRICEPURCHASE,@TOTAL,@CURRENCYID,@KURS,@DISCOUNT,@PPN,@CONVER)";
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@COSTINGID", k.COSTINGID);
                strQuery.Parameters.AddWithValue("@COSTINGDESC", k.COSTINGDESC);
                strQuery.Parameters.AddWithValue("@MATERIALTYPEID", k.MATERIALTYPEID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);
                strQuery.Parameters.AddWithValue("@PRICEPURCHASE", k.PRICEPURCHASE);
                strQuery.Parameters.AddWithValue("@TOTAL", k.TOTAL);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@DISCOUNT", k.DISCOUNT);
                strQuery.Parameters.AddWithValue("@PPN", k.PPN);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
                strQuery.ExecuteNonQuery();
                stat = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnG.Putus();
            }
            return stat;
        }
        public bool updateData(purchasedetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                
                strQuery.CommandText = "UPDATE tblpurchasedetail SET COSTINGNO=@COSTINGNO,COSTINGID=@COSTINGID,COSTINGDESC=@COSTINGDESC,MATERIALTYPEID=@MATERIALTYPEID,ITEMSID=@ITEMSID,DESCRIPTION=@DESCRIPTION,QUANTITY=@QUANTITY,UOM=@UOM, " +
                                        "PRICE=@PRICE,QTYPURCHASE=@QTYPURCHASE,UOMPURCHASE=@UOMPURCHASE,PRICEPURCHASE=@PRICEPURCHASE,TOTAL=@TOTAL,CURRENCYID=@CURRENCYID,KURS=@KURS,DISCOUNT=@DISCOUNT,PPN=@PPN,CONVER=@CONVER " +
                                        " WHERE PONO=@PONO AND ID=@ID";
                

                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@COSTINGID", k.COSTINGID);
                strQuery.Parameters.AddWithValue("@COSTINGDESC", k.COSTINGDESC);
                strQuery.Parameters.AddWithValue("@MATERIALTYPEID", k.MATERIALTYPEID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);
                strQuery.Parameters.AddWithValue("@PRICEPURCHASE", k.PRICEPURCHASE);
                strQuery.Parameters.AddWithValue("@TOTAL", k.TOTAL);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@DISCOUNT", k.DISCOUNT);
                strQuery.Parameters.AddWithValue("@PPN", k.PPN);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
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
        public bool deleteData(string PONO,int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblpurchasedetail  WHERE PONO=@PONO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@PONO", PONO);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMD
{
    class costingdetailCRUD
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
                strQuery.CommandText = "SELECT COSTINGNO,ID,COSTID,DESCRIPTION,WIDTH,USAG,CONSUMPTION,UOMID,"+
                                       "PRICE,AMOUNT,CURRENCY,KURS,ALLOWANCE,APPROVE,APPROVEDATE,APPROVEBY"+
                                       " FROM tblcostingdetail";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblcostingdetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string COSTINGNO)
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
                strQuery.CommandText = "SELECT COSTINGNO,ID,COSTID,DESCRIPTION,WIDTH,USAG,CONSUMPTION,UOMID," +
                                       "PRICE,AMOUNT,CURRENCY,KURS,ALLOWANCE,APPROVE,APPROVEDATE,APPROVEBY" +
                                       " FROM tblcostingdetail WHERE COSTINGNO=@COSTINGNO";
                strQuery.Parameters.AddWithValue("@COSTINGNO",COSTINGNO);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblcostingdetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        
        public bool insertData(costingdetail k)
        {
            bool stat = false;
            Connection ConnG = new Connection();
            try
            {
                
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblcostingdetail VALUES(@COSTINGNO,@ID,@COSTID,@DESCRIPTION,@WIDTH,@USAG,@CONSUMPTION,@UOMID," +
                                       "@PRICE,@AMOUNT,@CURRENCY,@KURS,@ALLOWANCE,@APPROVE,@APPROVEDATE,@APPROVEBY)";
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COSTID", k.COSTID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@WIDTH", k.WIDTH);
                strQuery.Parameters.AddWithValue("@USAG", k.USAG);
                strQuery.Parameters.AddWithValue("@CONSUMPTION", k.CONSUMPTION);
                strQuery.Parameters.AddWithValue("@UOMID", k.UOMID);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@AMOUNT", k.AMOUNT);
                strQuery.Parameters.AddWithValue("@CURRENCY", k.CURRENCY);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
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
        public bool updateData(costingdetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblcostingdetail SET ID=@ID,COSTID=@COSTID,DESCRIPTION=@DESCRIPTION,WIDTH=@WIDTH,USAG=@USAG,CONSUMPTION=@CONSUMPTION,UOMID=@UOMID," +
                                       "PRICE=@PRICE,AMOUNT=@AMOUNT,CURRENCY=@CURRENCY,KURS=@KURS,ALLOWANCE=@ALLOWANCE,APPROVE=@APPROVE,APPROVEDATE=@APPROVEDATE,APPROVEBY=@APPROVEBY WHERE COSTINGNO=@COSTINGNO";
                strQuery.Parameters.AddWithValue("@COSTINGNO", k.COSTINGNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@COSTID", k.COSTID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@WIDTH", k.WIDTH);
                strQuery.Parameters.AddWithValue("@USAG", k.USAG);
                strQuery.Parameters.AddWithValue("@CONSUMPTION", k.CONSUMPTION);
                strQuery.Parameters.AddWithValue("@UOMID", k.UOMID);
                strQuery.Parameters.AddWithValue("@PRICE", k.PRICE);
                strQuery.Parameters.AddWithValue("@AMOUNT", k.AMOUNT);
                strQuery.Parameters.AddWithValue("@CURRENCY", k.CURRENCY);
                strQuery.Parameters.AddWithValue("@KURS", k.KURS);
                strQuery.Parameters.AddWithValue("@ALLOWANCE", k.ALLOWANCE);
                strQuery.Parameters.AddWithValue("@APPROVE", k.APPROVE);
                strQuery.Parameters.AddWithValue("@APPROVEDATE", k.APPROVEDATE);
                strQuery.Parameters.AddWithValue("@APPROVEBY", k.APPROVEBY);
                strQuery.ExecuteNonQuery();

                ConnG.Putus();
                stat = true;

            }
            catch
            {
            }
            return stat;
        }
        public bool deleteData(string costID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblcosting WHERE COSTINGNO = @CostID";
                strQuery.Parameters.AddWithValue("@CostID", costID);
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

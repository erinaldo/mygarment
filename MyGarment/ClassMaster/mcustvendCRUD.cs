using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassMaster
{
    class mcustvendCRUD
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
                strQuery.CommandText = "SELECT * from tblmcustvend";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcustvend");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string CustVendCode, string Name,string Type)
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
                //strQuery.CommandText = "SELECT CUSTVENDCODE,NAME,TYPE,ACTIVE from tblmcustvend WHERE CUSTVENDCODE LIKE @CustVendCode AND NAME LIKE @Name AND TYPE LIKE @Type";
                strQuery.CommandText = "SELECT * from tblmcustvend WHERE CUSTVENDCODE LIKE @CUSTVENDCODE AND NAME LIKE @NAME AND TYPE LIKE @TYPE ";
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CustVendCode + "%");
                strQuery.Parameters.AddWithValue("@NAME", "%" + Name + "%");
                strQuery.Parameters.AddWithValue("@TYPE", "%" + Type + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcustvend");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }
 

        public bool insertData(mcustvend k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                
                strQuery.CommandText = "INSERT INTO tblmcustvend(CUSTVENDCODE,NAME,TYPE,ACTIVE,DATE,CONTACTPERSON,CONTACTTITLE,ADDRESS,CITY,ZIPCODE,COUNTRY,HP,PHONE,FAX,REMARKS,TAX,CURRENCYID,NPWP,NPKP) "+
                    " VALUES(@CUSTVENDCODE,@NAME,@TYPE,@ACTIVE,@DATE,@CONTACTPERSON,@CONTACTTITLE,@ADDRESS,@CITY,@ZIPCODE,@COUNTRY,@HP,@PHONE,@FAX,@REMARKS,@TAX,@CURRENCYID,@NPWP,@NPKP)";
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@NAME", k.NAME);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);
                strQuery.Parameters.AddWithValue("@ACTIVE", k.ACTIVE);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@CONTACTPERSON", k.CONTACTPERSON);
                strQuery.Parameters.AddWithValue("@CONTACTTITLE", k.CONTACTTITLE);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@CITY", k.CITY);
                strQuery.Parameters.AddWithValue("@ZIPCODE", k.ZIPCODE);
                strQuery.Parameters.AddWithValue("@COUNTRY", k.COUNTRY);
                strQuery.Parameters.AddWithValue("@HP", k.HP);
                strQuery.Parameters.AddWithValue("@PHONE", k.PHONE);
                strQuery.Parameters.AddWithValue("@FAX", k.FAX);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@TAX", k.TAX);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@NPWP", k.NPWP);
                strQuery.Parameters.AddWithValue("@NPKP", k.NPKP);

                
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
        public bool updateData(mcustvend k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmcustvend SET NAME=@NAME,TYPE=@TYPE,ACTIVE=@ACTIVE," +
                            "DATE=@DATE,CONTACTPERSON=@CONTACTPERSON,CONTACTTITLE=@CONTACTTITLE,ADDRESS=@ADDRESS,CITY=@CITY,ZIPCODE=@ZIPCODE,"+
                            "COUNTRY=@COUNTRY,HP=@HP,PHONE=@PHONE,FAX=@FAX,REMARKS=@REMARKS,TAX=@TAX,CURRENCYID=@CURRENCYID,NPWP=@NPWP,"+
                            "NPKP=@NPKP WHERE CUSTVENDCODE=@CUSTVENDCODE";
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", k.CUSTVENDCODE);
                strQuery.Parameters.AddWithValue("@NAME", k.NAME);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);
                strQuery.Parameters.AddWithValue("@ACTIVE", k.ACTIVE);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@CONTACTPERSON", k.CONTACTPERSON);
                strQuery.Parameters.AddWithValue("@CONTACTTITLE", k.CONTACTTITLE);
                strQuery.Parameters.AddWithValue("@ADDRESS", k.ADDRESS);
                strQuery.Parameters.AddWithValue("@CITY", k.CITY);
                strQuery.Parameters.AddWithValue("@ZIPCODE", k.ZIPCODE);
                strQuery.Parameters.AddWithValue("@COUNTRY", k.COUNTRY);
                strQuery.Parameters.AddWithValue("@HP", k.HP);
                strQuery.Parameters.AddWithValue("@PHONE", k.PHONE);
                strQuery.Parameters.AddWithValue("@FAX", k.FAX);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
                strQuery.Parameters.AddWithValue("@TAX", k.TAX);
                strQuery.Parameters.AddWithValue("@CURRENCYID", k.CURRENCYID);
                strQuery.Parameters.AddWithValue("@NPWP", k.NPWP);
                strQuery.Parameters.AddWithValue("@NPKP", k.NPKP);

                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;

            }
            catch
            {
                //MessageBox.Show("error");
            }
            return stat;
        }
        public bool deleteData(string CustVendCode)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblmcost WHERE CUSTVENDCODE = @CUSTVENDCODE";
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", CustVendCode);
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

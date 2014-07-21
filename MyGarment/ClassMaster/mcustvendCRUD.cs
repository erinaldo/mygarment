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
                strQuery.CommandText = "SELECT CUSTVENDCODE,NAME,TYPE,ACTIVE from tblmcustvend";
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
                strQuery.CommandText = "SELECT CUSTVENDCODE,NAME,TYPE,ACTIVE from tblmcustvend WHERE CUSTVENDCODE LIKE @CustVendCode AND NAME LIKE @Name AND TYPE LIKE @Type";
                strQuery.Parameters.AddWithValue("@CustVendCode", "%" + CustVendCode + "%");
                strQuery.Parameters.AddWithValue("@Name", "%" + Name + "%");
                strQuery.Parameters.AddWithValue("@Type", "%" + Type + "%");
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
                
                strQuery.CommandText = "INSERT INTO tblmcustvend(CUSTVENDCODE,NAME,TYPE,ACTIVE) VALUES(@CustVendCode,@Name,@Type,@Active)";
                strQuery.Parameters.AddWithValue("@CustVendCode", k.CustVendCode);
                strQuery.Parameters.AddWithValue("@Name", k.Name);
                strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                
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
                strQuery.CommandText = "UPDATE tblmvendcode SET NAME=@Name,TYPE=@Type,ACTIVE=@Active WHERE CUSTVENDCODE=@CusVendCode";
                strQuery.Parameters.AddWithValue("@Name", k.Name);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.ExecuteNonQuery();
                ConnG.Putus();
                stat = true;

            }
            catch
            {
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
                strQuery.CommandText = "DELETE FROM tblmcost WHERE CUSTVENDCODE = @CustVendCode";
                strQuery.Parameters.AddWithValue("@CostID", CustVendCode);
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

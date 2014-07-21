using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMaster
{
    class mstoreCRUD
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
                strQuery.CommandText = "SELECT STOREID,NAME,ADDRESS,ACTIVE from tblmstore";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmstore");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }


 
        public DataSet getData(string StoreID, string Name, string Address)
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
                strQuery.CommandText = "SELECT STOREID,NAME,ADDRESS,ACTIVE FROM tblmstore WHERE STOREID LIKE @StoreID AND NAME LIKE @Name AND ADDRESS LIKE @Address ";
                strQuery.Parameters.AddWithValue("@StoreID", "%" + StoreID + "%");
                strQuery.Parameters.AddWithValue("@Name", "%" + Name + "%");
                strQuery.Parameters.AddWithValue("@Address", "%" + Address + "%");
                //strQuery.Parameters.AddWithValue("@CategoryID", item);


                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmstore");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

       

        public bool insertData(mstore k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmstore VALUES(@StoreID,@Name,@Address,@Active)";
                strQuery.Parameters.AddWithValue("@StoreID", k.StoreID);
                strQuery.Parameters.AddWithValue("@Name", k.Name);
                strQuery.Parameters.AddWithValue("@Address", k.Address);
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
        public bool updateData(mstore k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmstore SET NAME=@Name,ADDRESS=@Address,ACTIVE=@Active WHERE STOREID=@StoreID";
                strQuery.Parameters.AddWithValue("@StoreID", k.StoreID);
                strQuery.Parameters.AddWithValue("@Name", k.Name);
                strQuery.Parameters.AddWithValue("@Address", k.Address);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
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
                strQuery.CommandText = "DELETE FROM tblmstore WHERE STOREID = @StoreID";
                strQuery.Parameters.AddWithValue("@StoreID", costID);
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

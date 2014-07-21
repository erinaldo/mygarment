using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassMaster
{
    class mitemsCRUD
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
                strQuery.CommandText = "SELECT ITEMSID,DESCRIPTION,ITEMSTYPEID,TYPE,ACTIVE from tblmitems";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitems");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }



        public DataSet getData(string ItemsID, string Description,string ItemsTypeID,string Type)
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
                strQuery.CommandText = "SELECT ITEMSID,DESCRIPTION,ITEMSTYPEID,TYPE,ACTIVE FROM tblmitems WHERE ITEMSID LIKE @ItemsID AND DESCRIPTION LIKE @Description AND ITEMSTYPEID LIKE @ItemsTypeID AND TYPE LIKE @Type";
                strQuery.Parameters.AddWithValue("@ItemsID","%"+ ItemsID+"%");
                strQuery.Parameters.AddWithValue("@Description","%"+Description+"%");
                strQuery.Parameters.AddWithValue("@ItemsTypeID","%"+ ItemsTypeID+"%");
                strQuery.Parameters.AddWithValue("@Type", "%"+Type+"%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitems");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }



        public bool insertData(mitems k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "INSERT INTO tblmitems VALUES(@ItemsID,@Description,@ItemsTypeID,@Type,@Active)";
                strQuery.Parameters.AddWithValue("@ItemsID", k.ItemsID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@ItemsTypeID", k.ItemsTypeID);
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
        public bool updateData(mitems k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmitems SET DESCRIPTION=@Description,ITEMSTYPEID=@ItemsTypeID,TYPE=@Type,ACTIVE=@Active WHERE ITEMSID=@ITEMSID";
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ItemsID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@ItemsTypeID", k.ItemsTypeID);
                strQuery.Parameters.AddWithValue("@Type", k.Type);
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
                strQuery.CommandText = "DELETE FROM tblmitems WHERE ITEMSID = @ItemsID";
                strQuery.Parameters.AddWithValue("@ItemsID", costID);
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

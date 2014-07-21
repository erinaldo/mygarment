using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassMaster
{
    class mitemstypeCRUD
    {
        private MySql.Data.MySqlClient.MySqlCommand strQuery = null;
        public DataSet getData()
        {
            DataSet ds = null;
            try
            {
                ds=new DataSet();
                Connection Con = new Connection();
                Con.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = Con.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT ITEMSTYPEID,DESCRIPTION,ACTIVE,CATEGORYID FROM tblmitemstype";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemstype");
                Con.Putus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string ItemsTypeID, string Description, string CategoryID)
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
                strQuery.CommandText = "SELECT ITEMSTYPEID,DESCRIPTION,ACTIVE,CATEGORYID FROM tblmitemstype WHERE CATEGORYID LIKE @CategoryID AND DESCRIPTION LIKE @Description AND CATEGORYID LIKE @CategoryID ";
                strQuery.Parameters.AddWithValue("@ItemsTypeID", "%" + ItemsTypeID + "%");
                strQuery.Parameters.AddWithValue("@Description", "%" + Description + "%");
                strQuery.Parameters.AddWithValue("@CategoryID", "%" + CategoryID + "%");
                //strQuery.Parameters.AddWithValue("@CategoryID", item);

                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmitemstype");

                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public bool insertData(mitemstype k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                //strQuery.CommandText = "INSERT INTO tKaryawan VALUES('" + k.getNIP() + "','" + k.getNama() + "','" + k.getAlamat() + "','" + k.getNotelp() + "','" + k.getHP() + "')";
                strQuery.CommandText = "INSERT INTO tblmitemstype VALUES(@ItemsTypeID,@Description,@Active,@CategoryID)";
                strQuery.Parameters.AddWithValue("@ItemsTypeID", k.ItemsTypeID);
                strQuery.Parameters.AddWithValue("@CategoryID", k.CategoryID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
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
        public bool updateData(string nip, mitemstype k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmitemstype SET DESCRIPTION=@Description,ACTIVE=@Active,CATEGORYID=@CategoryID WHERE ITEMSTYPEID=@ItemsTypeID";
                strQuery.Parameters.AddWithValue("@ItemsTypeID", k.ItemsTypeID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@CategoryID", k.CategoryID);
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
                strQuery.CommandText = "DELETE FROM tblmitemstype WHERE ITEMSTYPEID = @ItemsTypeID";
                strQuery.Parameters.AddWithValue("@ItemsTypeID", costID);
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

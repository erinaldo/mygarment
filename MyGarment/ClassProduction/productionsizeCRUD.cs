using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace MyGarment.ClassProduction
{
    class productionsizeCRUD
    {
        private MySqlCommand strQuery = null;
        public bool insertData(productionsize k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblproductionsize(STYLEID,SIZEID,NOURUT,COSUMPTION,RATIO,QTYPLAN) " +
                        "VALUES(@STYLEID,@SIZEID,@NOURUT,@COSUMPTION,@RATIO,@QTYPLAN)";
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@NOURUT", k.NOURUT);
                strQuery.Parameters.AddWithValue("@COSUMPTION", k.COSUMPTION);
                strQuery.Parameters.AddWithValue("@RATIO", k.RATIO);
                strQuery.Parameters.AddWithValue("@QTYPLAN", k.QTYPLAN);

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
        public bool updateData(productionsize k, string STYLEID1, string SIZEID1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblproductionsize SET STYLEID=@STYLEID,SIZEID=@SIZEID,NOURUT=@NOURUT,COSUMPTION=@COSUMPTION,RATIO=@RATIO,QTYPLAN=@QTYPLAN" +
                    " WHERE  STYLEID=@STYLEID1 AND SIZEID=@SIZEID1 ";
                //key
                strQuery.Parameters.AddWithValue("@STYLEID1", STYLEID1);
                strQuery.Parameters.AddWithValue("@SIZEID1", SIZEID1);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@NOURUT", k.NOURUT);
                strQuery.Parameters.AddWithValue("@COSUMPTION", k.COSUMPTION);
                strQuery.Parameters.AddWithValue("@RATIO", k.RATIO);
                strQuery.Parameters.AddWithValue("@QTYPLAN", k.QTYPLAN);
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
        public bool deleteData(string STYLEID, string SIZEID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblproductionsize WHERE  STYLEID=@STYLEID AND SIZEID=@SIZEID";
                strQuery.Parameters.AddWithValue("@STYLEID", STYLEID);
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

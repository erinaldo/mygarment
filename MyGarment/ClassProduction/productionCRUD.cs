using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassProduction
{
    class productionCRUD
    {
        private MySqlCommand strQuery = null;



        public DataSet getStyleColor(string STYLE, string COLORID)
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
                strQuery.CommandText = "SELECT MAX(case when NOURUT=0 then SizeID end ) Size0,"+
                                       "MAX(case when NOURUT=1 then SizeID end ) Size1,"+
                                       "MAX(case when NOURUT=2 then SizeID end ) Size2,"+
                                       "MAX(case when NOURUT=3 then SizeID end ) Size3,"+
                                       "MAX(case when NOURUT=4 then SizeID end ) Size4,"+
                                       "MAX(case when NOURUT=5 then SizeID end ) Size5,"+
                                       "MAX(case when NOURUT=6 then SizeID end ) Size6,"+
                                       "MAX(case when NOURUT=7 then SizeID end ) Size7,"+
                                       "MAX(case when NOURUT=8 then SizeID end ) Size8"+
                                       " FROM tblproduction "+
                                       " INNER JOIN tblmitems ON tblmitems.ITEMSID=tblproduction.STYLEID"+
                                       " INNER JOIN tblproductionsize ON tblproductionsize.STYLEID=tblproduction.STYLEID "+
                                       " WHERE tblproduction.STYLEID LIKE @STYLE AND COLORID=@COLORID" +
                                       " GROUP BY tblproduction.STYLEID,tblproduction.COLORID";
                strQuery.Parameters.AddWithValue("@STYLE",  STYLE) ;
                strQuery.Parameters.AddWithValue("@COLORID", COLORID);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblproduction");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }


        public DataSet findStyle(string Style,string DESC)
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
                strQuery.CommandText = "SELECT tblproduction.STYLEID,tblmitems.DESCRIPTION,tblproduction.DELIVERYDATE,tblproduction.COLORID  FROM tblproduction "+
                        " INNER JOIN tblmitems ON tblmitems.ITEMSID=tblproduction.STYLEID "+
                        " WHERE tblmitems.DESCRIPTION LIKE @STYLE  AND tblmitems.DESCRIPTION LIKE @DESC ";
                strQuery.Parameters.AddWithValue("@STYLE","%"+ Style+"%");
                strQuery.Parameters.AddWithValue("@DESC", "%" + DESC + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblproduction");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(production k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblproduction(JONO,STYLEID,COLORID,DELIVERYDATE,BUTTONING,WASHING,STARTDATE,CLOSEDATE) " +
                        "VALUES(@JONO,@STYLEID,@COLORID,@DELIVERYDATE,@BUTTONING,@WASHING,@STARTDATE,@CLOSEDATE)";
                strQuery.Parameters.AddWithValue("@JONO", k.JONO);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@DELIVERYDATE", k.DELIVERYDATE);
                strQuery.Parameters.AddWithValue("@BUTTONING", k.BUTTONING);
                strQuery.Parameters.AddWithValue("@WASHING", k.WASHING);
                strQuery.Parameters.AddWithValue("@STARTDATE", k.STARTDATE);
                strQuery.Parameters.AddWithValue("@CLOSEDATE", k.CLOSEDATE);
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
        public bool updateData(production k, string JONO1, string STYLEID1, string COLORID1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblproduction SET JONO=@JONO,STYLEID=@STYLEID,COLORID=@COLORID,DELIVERYDATE=@DELIVERYDATE,BUTTONING=@BUTTONING,"+
                    "WASHING=@WASHING,STARTDATE=@STARTDATE,CLOSEDATE=@CLOSEDATE"+
                    " WHERE JONO=@JONO1 AND STYLEID=@STYLEID1 AND COLORID=@COLORID1 ";
                //key
                strQuery.Parameters.AddWithValue("@JONO1", JONO1);
                strQuery.Parameters.AddWithValue("@STYLEID1", STYLEID1);
                strQuery.Parameters.AddWithValue("@COLORID1", COLORID1);

                strQuery.Parameters.AddWithValue("@JONO", k.JONO);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@DELIVERYDATE", k.DELIVERYDATE);
                strQuery.Parameters.AddWithValue("@BUTTONING", k.BUTTONING);
                strQuery.Parameters.AddWithValue("@WASHING", k.WASHING);
                strQuery.Parameters.AddWithValue("@STARTDATE", k.STARTDATE);
                strQuery.Parameters.AddWithValue("@CLOSEDATE", k.CLOSEDATE);
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
        public bool deleteData(string JONO, string STYLEID, string COLORID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblproduction WHERE JONO=@JONO AND STYLEID=@STYLEID AND COLORID=@COLORID";
                strQuery.Parameters.AddWithValue("@JONO", JONO);
                strQuery.Parameters.AddWithValue("@STYLEID", STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", COLORID);
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

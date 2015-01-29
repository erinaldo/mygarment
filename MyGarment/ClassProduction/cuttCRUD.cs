using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassProduction
{
	class cuttCRUD
	{

        private MySqlCommand strQuery = null;

        public DataSet getCutt(string STYLE, string COLORID)
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
                strQuery.CommandText = "SELECT tblcutt.CUTNO,tblcutt.STYLEID,tblcutt.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,"+
                                " MAX(case when NOURUT=0 then tblproductionsize.SizeID end ) Size0,"+
                                " MAX(case when NOURUT=1 then tblproductionsize.SizeID end ) Size1," +
                                " MAX(case when NOURUT=2 then tblproductionsize.SizeID end ) Size2,"+
                " MAX(case when NOURUT=3 then tblproductionsize.SizeID end ) Size3,"+
                    " MAX(case when NOURUT=4 then tblproductionsize.SizeID end ) Size4,"+
                    " MAX(case when NOURUT=5 then tblproductionsize.SizeID end ) Size5,"+
                    " MAX(case when NOURUT=6 then tblproductionsize.SizeID end ) Size6,"+
                    " MAX(case when NOURUT=7 then tblproductionsize.SizeID end ) Size7,"+
                    " SUM(case when NOURUT=0 then tblcuttdetail.QTY end ) Qty0,"+
                    " SUM(case when NOURUT=1 then tblcuttdetail.QTY end ) Qty1,"+
                    " SUM(case when NOURUT=2 then tblcuttdetail.QTY end ) Qty2,"+
                    " SUM(case when NOURUT=3 then tblcuttdetail.QTY end ) Qty3,"+
                    " SUM(tblcuttdetail.QTY)  TOTAL"+
                    " FROM tblproductionsize  "+
                    " LEFT OUTER JOIN tblcuttdetail ON tblproductionsize.SIZEID=tblcuttdetail.SIZEID"+
                    " LEFT OUTER JOIN tblcutt ON tblcutt.CUTNO=tblcuttdetail.CUTNO"+
                    " LEFT OUTER JOIN tblproduction ON tblproduction.STYLEID=tblproductionsize.STYLEID and tblproduction.COLORID=tblcutt.COLORID"+
                    " WHERE tblcutt.STYLEID = @STYLE AND tblcutt.COLORID=@COLORID " +
                    " GROUP BY tblcutt.STYLEID,tblcutt.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,tblcutt.CUTNO";
                strQuery.Parameters.AddWithValue("@STYLE", STYLE);
                strQuery.Parameters.AddWithValue("@COLORID", COLORID);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblcutt");
                Conn.Putus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }


        public bool insertData(cutt k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblcutt(CUTNO,OFFICER,DATE,JONO,STYLEID,COLORID,CREATEDATE,NOOFCUT,NOOFLAYER,LINE) " +
                        "VALUES(@CUTNO,@OFFICER,@DATE,@JONO,@STYLEID,@COLORID,@CREATEDATE,@NOOFCUT,@NOOFLAYER,@LINE)";
                strQuery.Parameters.AddWithValue("@CUTNO", k.CUTNO);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@JONO", k.JONO);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@CREATEDATE", k.CREATEDATE);
                strQuery.Parameters.AddWithValue("@NOOFCUT", k.NOOFCUT);
                strQuery.Parameters.AddWithValue("@NOOFLAYER", k.NOOFLAYER);
                strQuery.Parameters.AddWithValue("@LINE", k.LINE);


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
        public bool updateData(cutt k, string CUTNO1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblcutt SET CUTNO=@CUTNO,OFFICER=@OFFICER,DATE=@DATE,JONO=@JONO,STYLEID=@STYLEID,COLORID=@COLORID,CREATEDATE=@CREATEDATE,NOOFCUT=@NOOFCUT,NOOFLAYER=@NOOFLAYER,LINE=@LINE" +
                    " WHERE  CUTNO=@CUTNO1 ";
                //key
                strQuery.Parameters.AddWithValue("@CUTNO1", CUTNO1);
                //no key
                strQuery.Parameters.AddWithValue("@CUTNO", k.CUTNO);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@JONO", k.JONO);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@CREATEDATE", k.CREATEDATE);
                strQuery.Parameters.AddWithValue("@NOOFCUT", k.NOOFCUT);
                strQuery.Parameters.AddWithValue("@NOOFLAYER", k.NOOFLAYER);
                strQuery.Parameters.AddWithValue("@LINE", k.LINE);

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
        public bool deleteData(string CUTNO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblcutt WHERE  CUTNO=@CUTNO";
                strQuery.Parameters.AddWithValue("@CUTNO", CUTNO);
                
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

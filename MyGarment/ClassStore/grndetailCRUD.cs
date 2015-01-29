using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassStore
{
    class grndetailCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet getItemsByStyle(string StyleID)
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
                strQuery.CommandText = "SELECT *,(-1*(SELECT IFNULL(SUM(QUANTITY),0) FROM tblgindetail a Where a.ITEMSID=b.ITEMSID AND a.COLORID = b.COLORID AND a.SIZEID = b.SIZEID AND a.GRADE=b.GRADE)+QUANTITY ) QTYOH " +
                    "FROM tblgrndetail b " +
                    " WHERE JENIS='RAW' AND STYLEID=@StyleID  ";
                strQuery.Parameters.AddWithValue("@StyleID", StyleID);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet SearchDataGrn(string StyleID,string StyleDesc,string Type)
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
                strQuery.CommandText = "SELECT DISTINCT tblgrndetail.ITEMSID,tblmitems.DESCRIPTION from tblgrndetail " +
                            "INNER JOIN tblmitems ON tblgrndetail.ITEMSID=tblmitems.ITEMSID " +
                            "WHERE tblgrndetail.ITEMSID LIKE @StyleID AND TYPE like @Type AND tblmitems.DESCRIPTION LIKE @StyleDesc ";
                strQuery.Parameters.AddWithValue("@StyleID","%"+ StyleID+"%");
                strQuery.Parameters.AddWithValue("@StyleDesc", "%" + StyleDesc + "%");
                strQuery.Parameters.AddWithValue("@Type", "%" + Type + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getDataStyle(string StyleID)
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
                //strQuery.CommandText = "select * from tblgrndetail WHERE ITEMSID=@StyleID ";
                strQuery.CommandText = "SELECT *,(-1*(SELECT IFNULL(SUM(QUANTITY),0) FROM tblgindetail a Where a.ITEMSID=b.ITEMSID AND a.COLORID = b.COLORID AND a.SIZEID = b.SIZEID AND a.GRADE=b.GRADE)+QUANTITY ) QTYOH " +
                    "FROM tblgrndetail b " +
                    "WHERE ITEMSID=@StyleID ";
                strQuery.Parameters.AddWithValue("@StyleID", StyleID);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getDataItems(string StyleID)
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
                //strQuery.CommandText = "select * from tblgrndetail WHERE ITEMSID=@StyleID ";
                strQuery.CommandText = "SELECT *,(-1*(SELECT IFNULL(SUM(QUANTITY),0) FROM tblgindetail a Where a.ITEMSID=b.ITEMSID AND a.STYLEID=b.STYLEID)+QUANTITY ) QTYOH " +
                    "FROM tblgrndetail b " +
                    "WHERE ITEMSID=@StyleID ";
                strQuery.Parameters.AddWithValue("@StyleID", StyleID);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData()
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
                strQuery.CommandText = "SELECT * " +
                                    " FROM tblgrndetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string GRNNO)
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
                strQuery.CommandText = "SELECT * " +
                                " FROM tblgrndetail WHERE GRNNO LIKE @GRNNO";
                strQuery.Parameters.AddWithValue("@GRNNO", "%" + GRNNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgrndetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public bool insertData(grndetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblgrndetail (GRNNO,ID,ITEMSID,DESCRIPTION,JENIS,COLORID,SIZEID,GRADE,STYLEID,PONO,QUANTITY,UOM,CONVER,QTYPURCHASE,UOMPURCHASE) "+
                            " VALUES(@GRNNO,@ID,@ITEMSID,@DESCRIPTION,@JENIS,@COLORID,@SIZEID,@GRADE,@STYLEID,@PONO,@QUANTITY,@UOM,@CONVER,@QTYPURCHASE,@UOMPURCHASE)";
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@GRADE", k.GRADE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);



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
        public bool updateData(grndetail k,string GRNNo,int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgrndetail SET GRNNO=@GRNNO,ID=@ID,ITEMSID=@ITEMSID,DESCRIPTION=@DESCRIPTION,JENIS=@JENIS,COLORID=@COLORID,SIZEID=@SIZEID,GRADE=@GRADE,STYLEID=@STYLEID,PONO=@PONO,QUANTITY=@QUANTITY,UOM=@UOM,CONVER=@CONVER,QTYPURCHASE=@QTYPURCHASE,UOMPURCHASE=@UOMPURCHASE"+
                            " WHERE GRNNO=@GRNNO1 AND ID=@ID1";
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@GRADE", k.GRADE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                strQuery.Parameters.AddWithValue("@CONVER", k.CONVER);
                strQuery.Parameters.AddWithValue("@QTYPURCHASE", k.QTYPURCHASE);
                strQuery.Parameters.AddWithValue("@UOMPURCHASE", k.UOMPURCHASE);
                //key
                strQuery.Parameters.AddWithValue("@GRNNO1", GRNNo);
                strQuery.Parameters.AddWithValue("@ID1", ID);


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
        public bool deleteData(string GRNNO,int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblgrndetail WHERE GRNNO = @GRNNO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@GRNNO", GRNNO);
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

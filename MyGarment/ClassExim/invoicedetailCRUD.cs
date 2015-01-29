using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassExim
{
    class invoicedetailCRUD
    {
        private MySqlCommand strQuery = null;
    
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
                                    " FROM tblinvoicedetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblinvoicedetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string INVNO)
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
                                " FROM tblinvoicedetail WHERE INVNO LIKE @INVNO";
                strQuery.Parameters.AddWithValue("@INVNO", "%" + INVNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblinvoicedetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public bool insertData(invoicedetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblinvoicedetail (INVNO,ID,ITEMSID,DESCRIPTION,JENIS,COLORID,SIZEID,GRADE,STYLEID,PONO,QUANTITY,UOM) " +
                            " VALUES(@INVNO,@ID,@ITEMSID,@DESCRIPTION,@JENIS,@COLORID,@SIZEID,@GRADE,@STYLEID,@PONO,@QUANTITY,@UOM)";
                strQuery.Parameters.AddWithValue("@INVNO", k.INVNO);
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
        public bool updateData(invoicedetail k, string INVNo, int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgrndetail SET GRNNO=@GRNNO,ID=@ID,ITEMSID=@ITEMSID,DESCRIPTION=@DESCRIPTION,JENIS=@JENIS,COLORID=@COLORID,SIZEID=@SIZEID,GRADE=@GRADE,STYLEID=@STYLEID,PONO=@PONO,QUANTITY=@QUANTITY,UOM=@UOM,CONVER=@CONVER,QTYPURCHASE=@QTYPURCHASE,UOMPURCHASE=@UOMPURCHASE" +
                            " WHERE INVONO=@INVNO1 AND ID=@ID1";
                strQuery.Parameters.AddWithValue("@INVNO", k.INVNO);
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
                //key
                strQuery.Parameters.AddWithValue("@INVNO1", INVNo);
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
        public bool deleteData(string INVNO, int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblinvoicedetail WHERE INVNO = @INVNO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@INVNO", INVNO);
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

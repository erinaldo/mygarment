using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassStore
{
    class gindetailCRUD
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
                            " FROM tblgindetail";
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }
        public DataSet getData(string GINNO)
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
                strQuery.CommandText = "SELECT *" +
                                " FROM tblgindetail WHERE GINNO LIKE @GINNO";
                strQuery.Parameters.AddWithValue("@GINNO", "%" + GINNO + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getData(string GINNO, string TYPEID, string STAT, string OFFICER, string CUSTVENDCODE, int APPROVE)
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
                strQuery.CommandText = "SELECT GINNO,ITEMSID,COLORID,COSTINGNO,PONO,QUANTITY,UOM,PRICE," +
                            "CURRENCYID,KURS,REMARKS,STATUSCODA,QTYPURCHASE,UOMPURCHASE" +
                        " FROM tblgindetail WHERE ginNO LIKE @ginNO AND TYPEID LIKE @TYPEID AND IFNULL(STAT,1) LIKE @STAT " +
                        "AND IFNULL(OFFICER,1) LIKE @OFFICER AND CUSTVENDCODE LIKE @CUSTVENDCODE AND APPROVE LIKE @APPROVE";
                strQuery.Parameters.AddWithValue("@ginNO", "%" + GINNO + "%");
                strQuery.Parameters.AddWithValue("@TYPEID", "%" + TYPEID + "%");
                strQuery.Parameters.AddWithValue("@STAT", "%" + STAT + "%");
                strQuery.Parameters.AddWithValue("@OFFICER", "%" + OFFICER + "%");
                strQuery.Parameters.AddWithValue("@CUSTVENDCODE", "%" + CUSTVENDCODE + "%");
                strQuery.Parameters.AddWithValue("@APPROVE", "%" + APPROVE + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblgindetail");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public bool insertData(gindetail k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tblgindetail(GINNO,ID,GRNNO,ITEMSID,DESCRIPTION,JENIS,COLORID,SIZEID,GRADE,STYLEID,STYLEIDTO,PONO,QUANTITY,UOM) "+ 
                     " VALUES(@GINNO,@ID,@GRNNO,@ITEMSID,@DESCRIPTION,@JENIS,@COLORID,@SIZEID,@GRADE,@STYLEID,@STYLEIDTO,@PONO,@QUANTITY,@UOM" +
                      ")";
                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@GRADE", k.GRADE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@STYLEIDTO", k.STYLEIDTO);
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
        public bool updateData(gindetail k,string GINNO1,int ID1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblgindetail SET GINNO=@GINNO,ID=@ID,GRNNO=@GRNNO,ITEMSID=@ITEMSID,DESCRIPTION=@DESCRIPTION,JENIS=@JENIS,COLORID=@COLORID,SIZEID=@SIZEID,GRADE=@GRADE,STYLEID=@STYLEID,STYLEIDTO=@STYLEIDTO,PONO=@PONO,QUANTITY=@QUANTITY,UOM=@UOM" +
                        " WHERE GINNO=@GINNO AND ID=@ID1";
                strQuery.Parameters.AddWithValue("@GINNO", k.GINNO);
                strQuery.Parameters.AddWithValue("@ID", k.ID);
                strQuery.Parameters.AddWithValue("@GRNNO", k.GRNNO);
                strQuery.Parameters.AddWithValue("@ITEMSID", k.ITEMSID);
                strQuery.Parameters.AddWithValue("@DESCRIPTION", k.DESCRIPTION);
                strQuery.Parameters.AddWithValue("@JENIS", k.JENIS);
                strQuery.Parameters.AddWithValue("@COLORID", k.COLORID);
                strQuery.Parameters.AddWithValue("@SIZEID", k.SIZEID);
                strQuery.Parameters.AddWithValue("@GRADE", k.GRADE);
                strQuery.Parameters.AddWithValue("@STYLEID", k.STYLEID);
                strQuery.Parameters.AddWithValue("@STYLEIDTO", k.STYLEIDTO);
                strQuery.Parameters.AddWithValue("@PONO", k.PONO);
                strQuery.Parameters.AddWithValue("@QUANTITY", k.QUANTITY);
                strQuery.Parameters.AddWithValue("@UOM", k.UOM);
                //key
                strQuery.Parameters.AddWithValue("@GINNO", GINNO1);
                strQuery.Parameters.AddWithValue("@ID", ID1);

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
        public bool deleteData(string GINNO,int ID)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tblgindetail WHERE GINNO = @GINNO AND ID=@ID";
                strQuery.Parameters.AddWithValue("@GINNO", GINNO);
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

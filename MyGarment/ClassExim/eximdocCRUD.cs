using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGarment.ClassExim
{
    class eximdocCRUD
    {
        private MySqlCommand strQuery = null;

        public DataSet prBeaCukai1(DateTime dateFrom,DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,tbleximdoc.DOCTYPE,  tbleximdoc.DOCNO,tbleximdoc.DOCDATE,tbleximdocdetail.TRANSNO,tblgrn.DATE,tblgrn.PONO,tblmcustvend.NAME,tbleximdocdetail.ITEMSID,tblmitems.DESCRIPTION,tblgrndetail.UOM,tblgrndetail.QUANTITY,tbleximdocdetail.CURRENCY,tbleximdocdetail.TOTAL " +
                    " FROM tbleximdoc " +
                    " INNER JOIN tbleximdocdetail ON tbleximdoc.AJUNO=tbleximdocdetail.NOAJU" +
                    " INNER JOIN tblgrn ON tbleximdocdetail.TRANSNO=tblgrn.GRNNO" +
                    " INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO" +
                    " INNER JOIN tblpurchase ON tblpurchase.PONO=tblgrn.PONO" +
                    " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblpurchase.CUSTVENDID" +
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID" +
                    " WHERE tbleximdoc.`TYPE`='PEMASUKAN' AND date(DOCDATE) BETWEEN date(@dateFrom) AND date(@dateTo)";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom );
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai2(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,tbleximdoc.DOCTYPE,  tbleximdoc.DOCNO,tbleximdoc.DOCDATE,tbleximdocdetail.TRANSNO,tblgin.DATE,tblmcustvend.NAME,tbleximdocdetail.ITEMSID,tblmitems.DESCRIPTION,tblgindetail.UOM,tblgindetail.QUANTITY,tbleximdocdetail.CURRENCY,tbleximdocdetail.TOTAL " +
                   " FROM tbleximdoc "+
                   " INNER JOIN tbleximdocdetail ON tbleximdoc.AJUNO=tbleximdocdetail.NOAJU "+
                   " INNER JOIN tblgin ON tbleximdocdetail.TRANSNO=tblgin.GINNO"+
                   " INNER JOIN tblgindetail ON tblgindetail.GINNO=tblgin.GINNO"+
                   " INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblgin.CUSTVENDCODE"+
                   " INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID"+
                   " WHERE tbleximdoc.`TYPE`='PENGELUARAN' AND date(DOCDATE) BETWEEN date(@dateFrom) AND date(@dateTo)";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai3(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,tblgindetail.ITEMSID, tblmitems.DESCRIPTION,tblgindetail.QUANTITY,tblgindetail.UOM,tblgindetail.STYLEIDTO " +
                    " FROM tblgin "+
                    " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO"+
                    " INNER JOIN tblmcustvend ON tblgin.CUSTVENDCODE=tblmcustvend.CUSTVENDCODE"+
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=tblgindetail.ITEMSID" +
                    " WHERE tblgindetail.JENIS='RAW' AND tblmcustvend.`TYPE`='CMT' AND date(tblgin.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
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
                strQuery.CommandText = "SELECT * FROM tbleximdoc";

                
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai4(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,DT.ITEMSID,tblmitems.DESCRIPTION,"+
                    " DT.UOM,SUM(DT.OPENING) OPENING,SUM(DT.PEMASUKAN) PEMASUKAN,SUM(DT.PENGELUARAN) PENGELUARAN, "+
                    " SUM(DT.PENYESUAIAN)PENYESUAIAN,SUM(DT.CLOSING) CLOSING,SUM(DT.STOCKOPNAME) OPNAME,SUM(DT.SELISIH) SELISIH"+
                    " FROM"+
                    " ("+
                    " SELECT "+
                    " tblgrndetail.ITEMSID,"+
                    " tblgrndetail.UOM,"+
                    " CASE WHEN date(tblgrn.DATE) <  date(@dateFrom) THEN tblgrndetail.QUANTITY ELSE 0 END OPENING," +
                    " CASE WHEN date(tblgrn.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgrndetail.QUANTITY ELSE 0 END PEMASUKAN," +
                    " 0 PENGELUARAN, 0 PENYESUAIAN,"+
                    " CASE WHEN date(tblgrn.DATE) <= date(@dateTo) THEN tblgrndetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH"+
                    " FROM tblgrn"+
                    " INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO"+
                    " WHERE tblgrndetail.JENIS='RAW'"+
                    " UNION ALL"+
                    " SELECT "+
                    " tblgindetail.ITEMSID,"+
                    " tblgindetail.UOM,"+
                    " CASE WHEN date(tblgin.DATE) <  date(@dateFrom) THEN -1*tblgindetail.QUANTITY ELSE 0 END OPENING," +
                    " 0 PEMASUKAN,"+
                    " CASE WHEN date(tblgin.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgindetail.QUANTITY ELSE 0 END PENGELUARAN," +
                    " 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgin.DATE) <= date(@dateTo) THEN -1*tblgindetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH"+
                    " FROM tblgin"+
                    " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO"+
                    " WHERE tblgindetail.JENIS='RAW'"+
                    " )DT "+
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=DT.ITEMSID "+
                    " GROUP BY DT.ITEMSID,tblmitems.DESCRIPTION,DT.UOM";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai5(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,DT.ITEMSID,tblmitems.DESCRIPTION," +
                    " DT.UOM,SUM(DT.OPENING) OPENING,SUM(DT.PEMASUKAN) PEMASUKAN,SUM(DT.PENGELUARAN) PENGELUARAN, " +
                    " SUM(DT.PENYESUAIAN)PENYESUAIAN,SUM(DT.CLOSING) CLOSING,SUM(DT.STOCKOPNAME) OPNAME,SUM(DT.SELISIH) SELISIH" +
                    " FROM" +
                    " (" +
                    " SELECT " +
                    " tblgrndetail.ITEMSID," +
                    " tblgrndetail.UOM," +
                    " CASE WHEN date(tblgrn.DATE) <  date(@dateFrom) THEN tblgrndetail.QUANTITY ELSE 0 END OPENING," +
                    " CASE WHEN date(tblgrn.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgrndetail.QUANTITY ELSE 0 END PEMASUKAN," +
                    " 0 PENGELUARAN, 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgrn.DATE) <= date(@dateTo) THEN tblgrndetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgrn" +
                    " INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO" +
                    " WHERE tblgrndetail.JENIS='PRODUCT'" +
                    " UNION ALL" +
                    " SELECT " +
                    " tblgindetail.ITEMSID," +
                    " tblgindetail.UOM," +
                    " CASE WHEN date(tblgin.DATE) <  date(@dateFrom) THEN -1*tblgindetail.QUANTITY ELSE 0 END OPENING," +
                    " 0 PEMASUKAN," +
                    " CASE WHEN date(tblgin.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgindetail.QUANTITY ELSE 0 END PENGELUARAN," +
                    " 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgin.DATE) <= date(@dateTo) THEN -1*tblgindetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgin" +
                    " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO" +
                    " WHERE tblgindetail.JENIS='PRODUCT'" +
                    " )DT " +
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=DT.ITEMSID " +
                    " GROUP BY DT.ITEMSID,tblmitems.DESCRIPTION,DT.UOM";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai6(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,DT.ITEMSID,tblmitems.DESCRIPTION," +
                    " DT.UOM,SUM(DT.OPENING) OPENING,SUM(DT.PEMASUKAN) PEMASUKAN,SUM(DT.PENGELUARAN) PENGELUARAN, " +
                    " SUM(DT.PENYESUAIAN)PENYESUAIAN,SUM(DT.CLOSING) CLOSING,SUM(DT.STOCKOPNAME) OPNAME,SUM(DT.SELISIH) SELISIH" +
                    " FROM" +
                    " (" +
                    " SELECT " +
                    " tblgrndetail.ITEMSID," +
                    " tblgrndetail.UOM," +
                    " CASE WHEN date(tblgrn.DATE) <  date(@dateFrom) THEN tblgrndetail.QUANTITY ELSE 0 END OPENING," +
                    " CASE WHEN date(tblgrn.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgrndetail.QUANTITY ELSE 0 END PEMASUKAN," +
                    " 0 PENGELUARAN, 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgrn.DATE) <= date(@dateTo) THEN tblgrndetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgrn" +
                    " INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO" +
                    " WHERE tblgrndetail.JENIS='SCRAP'" +
                    " UNION ALL" +
                    " SELECT " +
                    " tblgindetail.ITEMSID," +
                    " tblgindetail.UOM," +
                    " CASE WHEN date(tblgin.DATE) <  date(@dateFrom) THEN -1*tblgindetail.QUANTITY ELSE 0 END OPENING," +
                    " 0 PEMASUKAN," +
                    " CASE WHEN date(tblgin.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgindetail.QUANTITY ELSE 0 END PENGELUARAN," +
                    " 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgin.DATE) <= date(@dateTo) THEN -1*tblgindetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgin" +
                    " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO" +
                    " WHERE tblgindetail.JENIS='SCRAP'" +
                    " )DT " +
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=DT.ITEMSID " +
                    " GROUP BY DT.ITEMSID,tblmitems.DESCRIPTION,DT.UOM";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet prBeaCukai7(DateTime dateFrom, DateTime dateTo)
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
                strQuery.CommandText = "SELECT @dateFrom dateFrom,@dateTo dateTo,DT.ITEMSID,tblmitems.DESCRIPTION," +
                    " DT.UOM,SUM(DT.OPENING) OPENING,SUM(DT.PEMASUKAN) PEMASUKAN,SUM(DT.PENGELUARAN) PENGELUARAN, " +
                    " SUM(DT.PENYESUAIAN)PENYESUAIAN,SUM(DT.CLOSING) CLOSING,SUM(DT.STOCKOPNAME) OPNAME,SUM(DT.SELISIH) SELISIH" +
                    " FROM" +
                    " (" +
                    " SELECT " +
                    " tblgrndetail.ITEMSID," +
                    " tblgrndetail.UOM," +
                    " CASE WHEN date(tblgrn.DATE) <  date(@dateFrom) THEN tblgrndetail.QUANTITY ELSE 0 END OPENING," +
                    " CASE WHEN date(tblgrn.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgrndetail.QUANTITY ELSE 0 END PEMASUKAN," +
                    " 0 PENGELUARAN, 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgrn.DATE) <= date(@dateTo) THEN tblgrndetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgrn" +
                    " INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO" +
                    " WHERE tblgrndetail.JENIS='MACHINE'" +
                    " UNION ALL" +
                    " SELECT " +
                    " tblgindetail.ITEMSID," +
                    " tblgindetail.UOM," +
                    " CASE WHEN date(tblgin.DATE) <  date(@dateFrom) THEN -1*tblgindetail.QUANTITY ELSE 0 END OPENING," +
                    " 0 PEMASUKAN," +
                    " CASE WHEN date(tblgin.DATE) BETWEEN date(@dateFrom) AND date(@dateTo)THEN tblgindetail.QUANTITY ELSE 0 END PENGELUARAN," +
                    " 0 PENYESUAIAN," +
                    " CASE WHEN date(tblgin.DATE) <= date(@dateTo) THEN -1*tblgindetail.QUANTITY ELSE 0 END CLOSING," +
                    " 0 STOCKOPNAME,0 SELISIH" +
                    " FROM tblgin" +
                    " INNER JOIN tblgindetail ON tblgin.GINNO=tblgindetail.GINNO" +
                    " WHERE tblgindetail.JENIS='MACHINE'" +
                    " )DT " +
                    " INNER JOIN tblmitems ON tblmitems.ITEMSID=DT.ITEMSID " +
                    " GROUP BY DT.ITEMSID,tblmitems.DESCRIPTION,DT.UOM";
                strQuery.Parameters.AddWithValue("@dateFrom", dateFrom);
                strQuery.Parameters.AddWithValue("@dateTo", dateTo);
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();
            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string AJUNO)
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
                        " FROM tbleximdoc WHERE AJUNO LIKE @AJUNO";

                strQuery.Parameters.AddWithValue("@AJUNO", "%" + AJUNO + "%");
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet findData(string AJUNO)
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
                        " FROM tbleximdoc WHERE AJUNO = @AJUNO";

                strQuery.Parameters.AddWithValue("@AJUNO", AJUNO );
                MySqlDataAdapter data = new MySqlDataAdapter(strQuery);
                data.Fill(ds, "tbleximdoc");
                Conn.Putus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }



        public bool insertData(eximdoc k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;

                strQuery.CommandText = "INSERT INTO tbleximdoc (AJUNO,AJUDATE,TRANSNO,OFFICER,DOCNO,DOCTYPE,DOCREASON,DOCDATE,INVNO,INVDATE,BLNO,BLDATE,TYPE,DATE,REMARKS) " +
                    "VALUES (@AJUNO,@AJUDATE,@TRANSNO,@OFFICER,@DOCNO,@DOCTYPE,@DOCREASON,@DOCDATE,@INVNO,@INVDATE,@BLNO,@BLDATE,@TYPE,@DATE,@REMARKS)";
                strQuery.Parameters.AddWithValue("@AJUNO", k.AJUNO);
                strQuery.Parameters.AddWithValue("@AJUDATE", k.AJUDATE);
                strQuery.Parameters.AddWithValue("@TRANSNO", k.TRANSNO);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DOCNO", k.DOCNO);
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@DOCREASON", k.DOCREASON);
                strQuery.Parameters.AddWithValue("@DOCDATE", k.DOCDATE);
                strQuery.Parameters.AddWithValue("@INVNO", k.INVNO);
                strQuery.Parameters.AddWithValue("@INVDATE", k.INVDATE);
                strQuery.Parameters.AddWithValue("@BLNO", k.BLNO);
                strQuery.Parameters.AddWithValue("@BLDATE", k.BLDATE);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
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
        public bool updateData(eximdoc k, string AJUNO1)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tbleximdoc SET AJUDATE=@AJUDATE,TRANSNO=@TRANSNO,OFFICER=@OFFICER,DOCNO=@DOCNO,DOCTYPE=@DOCTYPE,DOCREASON=@DOCREASON,DOCDATE=@DOCDATE,INVNO=@INVNO,INVDATE=@INVDATE,BLNO=@BLNO,BLDATE=@BLDATE,TYPE=@TYPE,DATE=@DATE,REMARKS=@REMARKS" +
                                       " WHERE AJUNO=@AJUNO1";
                //key
                strQuery.Parameters.AddWithValue("@AJUNO1", AJUNO1);
                //strQuery.Parameters.AddWithValue("@AJUNO", AJUNO1);
                //en key
                //strQuery.Parameters.AddWithValue("@AJUNO", k.AJUNO);
                strQuery.Parameters.AddWithValue("@AJUDATE", k.AJUDATE);
                strQuery.Parameters.AddWithValue("@TRANSNO", k.TRANSNO);
                strQuery.Parameters.AddWithValue("@OFFICER", k.OFFICER);
                strQuery.Parameters.AddWithValue("@DOCNO", k.DOCNO);
                strQuery.Parameters.AddWithValue("@DOCTYPE", k.DOCTYPE);
                strQuery.Parameters.AddWithValue("@DOCREASON", k.DOCREASON);
                strQuery.Parameters.AddWithValue("@DOCDATE", k.DOCDATE);
                strQuery.Parameters.AddWithValue("@INVNO", k.INVNO);
                strQuery.Parameters.AddWithValue("@INVDATE", k.INVDATE);
                strQuery.Parameters.AddWithValue("@BLNO", k.BLNO);
                strQuery.Parameters.AddWithValue("@BLDATE", k.BLDATE);
                strQuery.Parameters.AddWithValue("@TYPE", k.TYPE);
                strQuery.Parameters.AddWithValue("@DATE", k.DATE);
                strQuery.Parameters.AddWithValue("@REMARKS", k.REMARKS);
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
        public bool deleteData(string AJUNO)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "DELETE FROM tbleximdoc WHERE AJUNO = @AJUNO";
                strQuery.Parameters.AddWithValue("@AJUNO", AJUNO);
          
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

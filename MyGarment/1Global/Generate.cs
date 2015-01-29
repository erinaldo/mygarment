using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyGarment
{
    class Generate
    {
        //public string GStrCode;
        private MySqlCommand strQuery = null;

        public DateTime genNow(string str) //generate nomor
        {
            DateTime stat;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = str;
                stat = Convert.ToDateTime(strQuery.ExecuteScalar());
                //stat = Convert.ToDateTime(stat1);
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                //stat = ex.Message;
                Console.WriteLine(ex.Message);
                stat = DateTime.Now;
            }
            return stat;
        }
        public string genNO(string table,string field,string title) //generate nomor
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(" + field + ",'" + title + ".',DATE_FORMAT(NOW(), '%Y%m'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(" + field + "),0),5)+ 1),5)),LENGTH(" + field + ")+1))  THEN CONCAT('" + title + ".',DATE_FORMAT(NOW(), '%Y%m'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(" + field + ",'" + title + ".',DATE_FORMAT(NOW(), '%Y%m'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(" + field + ",5)+ 1),5))),LENGTH(" + field + ")+1)  " +
                        " END " +
                        " FROM "+table;
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }



        public string genPIN()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GINNO,'PIN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GINNO),0),5)+ 1),5)),LENGTH(GINNO)+1))  THEN CONCAT('PIN.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GINNO,'PIN.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GINNO,5)+ 1),5))),LENGTH(GINNO)+1)  " +
                        " END " +
                        " FROM tblgin";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }


        public string genMIN()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GINNO,'MIN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GINNO),0),5)+ 1),5)),LENGTH(GINNO)+1))  THEN CONCAT('MIN.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GINNO,'MIN.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GINNO,5)+ 1),5))),LENGTH(GINNO)+1)  " +
                        " END " +
                        " FROM tblgin";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }


        public string genGIN()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GINNO,'GIN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GINNO),0),5)+ 1),5)),LENGTH(GINNO)+1))  THEN CONCAT('GIN.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GINNO,'GIN.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GINNO,5)+ 1),5))),LENGTH(GINNO)+1)  " +
                        " END " +
                        " FROM tblgin";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }



        public string genGRO()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GRNNO,'GRO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GRNNO),0),5)+ 1),5)),LENGTH(GRNNO)+1))  THEN CONCAT('GRO.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GRNNO,'GRO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GRNNO),0),5)+ 1),5)),LENGTH(GRNNO)+1) " +
                        " END " +
                        " FROM tblgrn";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }


        public string genGRN()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GRNNO,'GRN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GRNNO),0),5)+ 1),5)),LENGTH(GRNNO)+1))  THEN CONCAT('GRN.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GRNNO,'GRN.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GRNNO,5)+ 1),5))),LENGTH(GRNNO)+1)  " +
                        " END " +
                        " FROM tblgrn";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }

        
        //generate Mrn supplier
        public string genMRN()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  "+
                        "WHEN isnull(SUBSTR(CONCAT(GRNNO,'MRN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GRNNO),0),5)+ 1),5)),LENGTH(GRNNO)+1))  THEN CONCAT('MRN.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE "+
                        " SUBSTR(CONCAT(GRNNO,'MRN.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GRNNO,5)+ 1),5))),LENGTH(GRNNO)+1)  " +
                        " END "+
                        " FROM tblgrn";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }

        //end grn
// MRN others
        public string genMRO()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "SELECT CASE  " +
                        "WHEN isnull(SUBSTR(CONCAT(GRNNO,'MRO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(GRNNO),0),5)+ 1),5)),LENGTH(GRNNO)+1))  THEN CONCAT('MRO.',DATE_FORMAT(NOW(), '%Y'),'.','00001')" +
                        " ELSE " +
                        " SUBSTR(CONCAT(GRNNO,'MRO.',DATE_FORMAT(NOW(), '%Y'),'.',MAX(RIGHT(CONCAT('000000000',RIGHT(GRNNO,5)+ 1),5))),LENGTH(GRNNO)+1)  " +
                        " END " +
                        " FROM tblgrn";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }


        
        public string genCosting()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                

                //strQuery.CommandText = "SELECT SUBSTR(CONCAT(COSTINGNO,'COST.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(COSTINGNO),0),4)+ 1),4)),LENGTH(COSTINGNO)+1) COSTINGNO from tblcosting";
                strQuery.CommandText = "SELECT CASE  "+
                        "WHEN isnull(SUBSTR(CONCAT(COSTINGNO,'MRN.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(COSTINGNO),0),5)+ 1),5)),LENGTH(COSTINGNO)+1))  THEN CONCAT('COST.',DATE_FORMAT(NOW(), '%Y'),'.','00001')"+
                        " ELSE "+
                        " SUBSTR(CONCAT(COSTINGNO,'COST.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(COSTINGNO),0),5)+ 1),5)),LENGTH(COSTINGNO)+1) "+
                        " END "+
                        " FROM tblcosting";
                

                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
               //essageBox.Show(ex.Message);
                stat = ex.Message;
            }
            return stat;
        }

        //generate PONO

        public string genPONO()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                //strQuery.CommandText = "SELECT SUBSTR(CONCAT(PONO,'PO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(PONO),0),4)+ 1),4)),LENGTH(PONO)+1) PONO from tblpurchase";
                strQuery.CommandText = "SELECT CASE  "+
                        " WHEN isnull(SUBSTR(CONCAT(PONO,'PO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(PONO),0),5)+ 1),5)),LENGTH(PONO)+1))  THEN CONCAT('PO.',DATE_FORMAT(NOW(), '%Y'),'.','00001')"+
                        " ELSE "+
                        " SUBSTR(CONCAT(PONO,'PO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(PONO),0),5)+ 1),5)),LENGTH(PONO)+1) "+
                        " END "+
                        " FROM tblpurchase";
                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                stat = ex.Message;
            }
            return stat;
        }

        //gen JO
        public string genJO()
        {
            string stat = "";
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                //strQuery.CommandText = "SELECT SUBSTR(CONCAT(ORDERNO,'JO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(ORDERNO),0),4)+ 1),4)),LENGTH(ORDERNO)+1) JONO from tbljoborder";
                strQuery.CommandText = "SELECT CASE  "+
                         "WHEN isnull(SUBSTR(CONCAT(ORDERNO,'JO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(ORDERNO),0),5)+ 1),5)),LENGTH(ORDERNO)+1))  THEN CONCAT('JO.',DATE_FORMAT(NOW(), '%Y'),'.','00001') "+
                         "ELSE "+
                         " SUBSTR(CONCAT(ORDERNO,'JO.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(ORDERNO),0),5)+ 1),5)),LENGTH(ORDERNO)+1) " +
                         "END "+
                         "FROM tbljoborder";

                Object stat1 = Convert.ToString(strQuery.ExecuteScalar());
                stat = stat1.ToString();
                ConnG.Putus();
            }
            catch (Exception ex)
            {
                stat = ex.Message;
            }
            return stat;
        }


    }
}

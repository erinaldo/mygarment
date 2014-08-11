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
                //strQuery.CommandText = "SELECT COSTINGNO from tblcosting";

                strQuery.CommandText = "SELECT SUBSTR(CONCAT(COSTINGNO,'COST.',DATE_FORMAT(NOW(), '%Y'),'.',RIGHT(CONCAT('000000000',RIGHT(IFNULL(MAX(COSTINGNO),0),4)+ 1),4)),LENGTH(COSTINGNO)+1) COSTINGNO from tblcosting";
                
                //strQuery.Parameters.AddWithValue("@CategoryID", costID);
                //strQuery.ExecuteNonQuery();
                // stat = dt.Columns["COSTINGNO"].ToString();

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
    }
}

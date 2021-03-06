﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using MyGarment.Global;

namespace MyGarment
{
    class mcostCRUD
    {
        private MySql.Data.MySqlClient.MySqlCommand strQuery = null;

        public DataSet getData()
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
                strQuery.CommandText = "SELECT COSTID,DESCRIPTION,ACTIVE from tblmcost";
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcost");

                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public DataSet getData(string CostID,string Description)
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
                strQuery.CommandText = "SELECT COSTID,DESCRIPTION,ACTIVE from tblmcost WHERE COSTID LIKE @CostID AND DESCRIPTION LIKE @Description";
                strQuery.Parameters.AddWithValue("@CostID","%"+CostID+"%");
                strQuery.Parameters.AddWithValue("@Description", "%"+Description+"%");
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "tblmcost");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }
        public DataSet getDataFilter(string nama)
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
                strQuery.CommandText = "SELECT COSTID,DESCRIPTION,ACTIVE,TYPE FROM tblmcost WHERE  COSTID=@CostID";
                strQuery.Parameters.AddWithValue("@CostID", nama);
                MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(strQuery);
                data.Fill(ds, "mcost");
                Conn.Putus();

            }
            catch
            {
            }
            return ds;
        }

        public bool insertData(mcost k)
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
                strQuery.CommandText = "INSERT INTO tblmcost VALUES(@CostID,@Description,@Active)";
                strQuery.Parameters.AddWithValue("@CostID", k.CostID);
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
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
        public bool updateData(string nip, mcost k)
        {
            bool stat = false;
            try
            {
                Connection ConnG = new Connection();
                ConnG.Konek();
                strQuery = new MySql.Data.MySqlClient.MySqlCommand();
                strQuery.Connection = ConnG.Conn;
                strQuery.CommandType = CommandType.Text;
                strQuery.CommandText = "UPDATE tblmcost SET DESCRIPTION=@Description,ACTIVE=@Active WHERE COSTID=@CostID";
                strQuery.Parameters.AddWithValue("@Description", k.Description);
                strQuery.Parameters.AddWithValue("@Active", k.Active);
                //strQuery.Parameters.AddWithValue("@Type", k.Type);
                strQuery.Parameters.AddWithValue("@CostID", k.CostID);
                strQuery.ExecuteNonQuery();

                ConnG.Putus();
                stat = true;

            }
            catch
            {
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
                strQuery.CommandText = "DELETE FROM tblmcost WHERE COSTID = @CostID";
                strQuery.Parameters.AddWithValue("@CostID", costID);
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

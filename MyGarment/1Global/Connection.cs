using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MyGarment
{
    class Connection
    {
        //string strCon = "Server=192.168.1.243;Port=3306;UID=root;PWD='';Database=mygarment";
        //string strCon = "Server=localhost;Port=3306;UID=root;PWD='';Database=mygarment";
        string Server = Properties.Settings.Default.Server;
        string Database = Properties.Settings.Default.Database;
        string strCon;
        //= "Server="+Server+";Port=3306;UID=root;PWD='';Database=mygarment";
        

        public MySqlConnection Conn = new MySqlConnection();

        //method untuk koneksi database
        public void Konek()
        {
            Conn.Close();
            try
            {
                strCon = "Server=" + Server + ";Port=3306;UID=root;PWD='';Database="+Database;
                Conn.ConnectionString = strCon;
                Conn.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        // method untuk putus koneksi database
        public void Putus()
        {
            Conn.Close();
        }


        //private MySql.Data.MySqlClient.MySqlCommand strQuery = null;
        public bool SQL(string query)
        {
            //bool stat = false;
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            //open connection
            Konek();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            //Execute command
            cmd.ExecuteNonQuery();
            Putus();
            //close connection
            return true;
        }


    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace MyGarment
{
    class mysql
    {
        //string koneksi
       // string Server = Properties.Settings.Default.Server;
       // string Database = Properties.Settings.Default.Database;
        //string strCon;

        public string strCon = "Server=" + Properties.Settings.Default.Server + ";Port=3306;UID=root;PWD='';Database=" + Properties.Settings.Default.Database;
    }
}

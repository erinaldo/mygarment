namespace MyGarment
{
    public static class GlobalVariables
    {
        //public static int MrGlobalInt = 5;
        public static string GUserID = "";
        public static string GName = "";
        public static string GDIV = "";
        public static string GCode = "";
        public static int GID = 0;
        public static string GPassword;
        //untuk default date
        public static string GCulture = "id";
        public static string GFormat = "dd/MM/yyyy";
        public static string strCon = "Server=" + Properties.Settings.Default.Server + ";Port=3306;UID=root;PWD='';Database=" + Properties.Settings.Default.Database;



    }
}
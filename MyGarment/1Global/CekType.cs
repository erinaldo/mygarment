using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace MyGarment._1Global
{
    class CekType
    {
        public bool date(object data)
        {
            DateTime dt;
            if (data == null)
            {
                return false;
            }else if (DateTime.TryParse(data.ToString(), new System.Globalization.CultureInfo(GlobalVariables.GCulture), System.Globalization.DateTimeStyles.None, out dt))
            {
                return true;
            }
            else { return false; }
        }

        //test
        public bool strdouble(string data)
        {
            double Num;
            bool isNum = double.TryParse(data, out Num);
            if (isNum)
                return true;
            else
                return false;
        }
        public bool strdouble(object data)
        {
            double Num;
            bool isNum = double.TryParse(data.ToString(), out Num);
            if (isNum)
                return true;
            else
                return false;
        }
        public bool strint(string data)
        {
            int Num;
            bool isNum = int.TryParse(data, out Num);
            if (isNum)
                return true;
            else
                return false;
        }
        public bool strint(object data)
        {
            int Num;
           // bool isNum;
            if (data == null)
            {
                return false;
            }
            else
            {
                if (int.TryParse(data.ToString(), out Num))
                    return true;
                else
                    return false;
            }

        }
        

    }
}

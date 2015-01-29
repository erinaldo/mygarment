using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGarment._1Global
{
    class Conversion
    {   // konversi ke string
        public int cint(object data)
        {
            int Num;
            if (data == null)
                return 0;
            else
            {
                bool isNum = int.TryParse(data.ToString(), out Num);
                if (isNum)
                    return Num;
                else
                    return 0;
            }
        }
        
        public int cint(string data)
        {
            int Num;
            bool isNum = int.TryParse(data, out Num);
            if (isNum)
                return Num;
            else
                return 0;
        }
        //koversi ke double
        public double cdouble(string data)
        {
            double Num;
            bool isNum = double.TryParse(data, out Num);
            if (isNum)
                return Num;
            else
                return 0;
        }
        public double cdouble(object data)
        {
            double Num;
            if (data == null)
               return 0;
            else
                 {
                     bool isNum = double.TryParse(data.ToString(), out Num);
                     if (isNum)
                         return Num;
                     else
                         return 0;
                 }
        }
        //konversi ke date
        public DateTime? cdate(string data)
        {
            DateTime dt;
            if (data == null)
            {
                return null;
            }
            else if (DateTime.TryParse(data, new System.Globalization.CultureInfo(GlobalVariables.GCulture), System.Globalization.DateTimeStyles.None, out dt))
            {
                return dt;
            }
            else { return null; }
        }

        public DateTime? cdate(object data)
        {
            DateTime dt;
            if (data == null)
            {
                return null;
            }
            else if (DateTime.TryParse(data.ToString(), new System.Globalization.CultureInfo(GlobalVariables.GCulture), System.Globalization.DateTimeStyles.None, out dt))
            {
                return dt;
            }
            else { return null; }
        }

    }
}

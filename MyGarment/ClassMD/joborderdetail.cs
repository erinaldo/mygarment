using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGarment.ClassMD
{
    class joborderdetail
    {
        public string ORDERNO { get; set; }
        public string POCUSTOMER { get; set; }
        public string COLORID { get; set; }
        public string SIZEID { get; set; }
        public int NOURUT { get; set; }
        public DateTime? DELIVERY { get; set; }
        public float QUANTITY { get; set; }
        public float CUTTINGQTY { get; set; }
        public float ALLOWANCE { get; set; }
        public string DESTINATION { get; set; }

    }
}

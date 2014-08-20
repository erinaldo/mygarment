using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGarment.ClassMD
{
    class purchase
    {
        public string PONO { get; set; }
        public DateTime DATE { get; set; }
        public string OFFICER { get; set; }
        public string GDIV { get; set; }
        public string CUSTVENDID { get; set; }
        public string DELIVERYTONAME { get; set; }
        public string DELIVERYTOADDRESS { get; set; }
        public string TERMOFPAYMENT { get; set; }
        public int APPROVE { get; set; }
        public string APPROVEDATE { get; set; }
        public string APPROVEBY { get; set; }
        public int CLOSE { get; set; }
        public string REMARKS { get; set; }
        public int ACKNOWLEDGEMENT { get; set; }
        public string ACKNOWLEDGEMENTDATE { get; set; }
        public string ACKNOWLEDGEMENTBY { get; set; }
        public float TOTALAMOUNT { get; set; }
        public float TOTALDISCOUNT { get; set; }
        public float TOTALPPN { get; set; }
        public string CURRENCYID { get; set; }
        public int CHECKED { get; set; }
        public DateTime CHECKDATE { get; set; }
        public string CHECKBY { get; set; }
        public string NOTE { get; set; }
        public DateTime ETA { get; set; }
        public string REFERTO { get; set; }
        public float TOTALPAID { get; set; }
        public int REVISE { get; set; }
        public string REVISEDATE { get; set; }
        public DateTime REVISEBY { get; set; }
        public string NONREQ { get; set; }
        public float TOTALUPCHARGES { get; set; }
        public DateTime ETD { get; set; }
        public DateTime DUEDATE { get; set; }
        public string SHIPMODA { get; set; }
        public DateTime REVISEDUEDATE { get; set; }
    }
}

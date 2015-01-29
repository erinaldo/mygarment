using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGarment.ClassMD
{
    class costingdetail
    { 

        public string COSTINGNO{ get; set; }
        public int ID{ get; set; }
        public string COSTID{ get; set; }
        public string DESCRIPTION{ get; set; }
        public string WIDTH{ get; set; }
        public string USAG{ get; set; }
        public float CONSUMPTION{ get; set; }
        public string UOMID{ get; set; }
        public float PRICE{ get; set; }
        public float AMOUNT{ get; set; }
        public string CURRENCY{ get; set; }
        public float KURS{ get; set; }
        public float ALLOWANCE{ get; set; }
        public int APPROVE{ get; set; }
        public DateTime? APPROVEDATE{ get; set; }
        public string APPROVEBY{ get; set; }
        /*
        public string CostingNo;
        public int ID;
        public string CostID;
        public string Description;
        public string Width;
        public string Usag;
        public float Comsumption;
        public string UomID;
        public float Price;
        public float Amount;
        public string Currency;
        public float Kurs;
        public float Allowance;
        public int Approve;
        public DateTime ApproveDate;
        public string ApproveBy;
       */
    }
}

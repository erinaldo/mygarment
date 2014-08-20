using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGarment.ClassMaster
{
    class mitems
    {
        public string ItemsID { get; set; }
        public string Description { get; set; }
        public string ItemsTypeID { get; set; }
        public string Type { get; set; }
        public int Active { get; set; }
        public byte[] Image { get; set; }
        public string Path{get;set;}
    }
}

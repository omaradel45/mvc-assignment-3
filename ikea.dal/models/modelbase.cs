using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.dal.models
{
    internal class modelbase
    {
        public int Id { get; set; } 
        public int createdby { get; set; }  
        public DateTime createdon { get; set; }
        public int lastmodificationby { get; set; }
        public DateTime lastmodifiedon { get; set; }
        public bool isdeleted { get; set; }
    }
}

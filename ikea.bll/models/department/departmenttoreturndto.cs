using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.bll.models.department
{
    public class departmenttoreturndto
    {
        public int Id { get; set; }
        //public int createdby { get; set; }
        //public DateTime createdon { get; set; }
        //public int lastmodificationby { get; set; }
        //public DateTime lastmodifiedon { get; set; }
        //public bool isdeleted { get; set; }
        public string name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string? description { get; set; }
        public DateOnly creationdate { get; set; }

    }
}

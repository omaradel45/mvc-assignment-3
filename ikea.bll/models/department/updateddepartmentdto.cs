 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.bll.models.department
{
    internal class updateddepartmentdto
    {
        public int  Id { get; set; }
        public string name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string? description { get; set; }
        public DateOnly creationdate { get; set; }
    }
}
}

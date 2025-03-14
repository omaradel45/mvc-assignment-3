using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.bll.models.department
{
    public class createddepartmentdto
    {
        public string name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string? description { get; set; }
        public DateOnly creationdate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.dal.models.departments
{
    internal class depatment:modelbase
    {
        public string name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string description { get; set; }
        public DateOnly creationdate { get; set; }


    }
}

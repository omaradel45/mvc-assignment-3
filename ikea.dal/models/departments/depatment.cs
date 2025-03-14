using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.dal.models.departments
{

    public class Department : modelbase
    {
        public Department(string name, string code, string description, DateOnly creationdate)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.creationdate = creationdate;
        }

        public string name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string description { get; set; }
        public DateOnly creationdate { get; set; }


    }
}

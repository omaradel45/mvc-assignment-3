using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.dal.models.departments;

namespace ikea.dal.presistance.repository.departments
{
    internal interface Idepartmentrepository
    {
        IEnumerable<depatment> getall(bool withasnotracking = true);
        depatment? getbyid(int id);
        int add(depatment entity);
        int update(depatment entity);
        int delete(depatment entity);   
    }
}

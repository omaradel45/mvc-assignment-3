using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.dal.models.departments;

namespace ikea.dal.presistance.repository.departments
{
    public interface Idepartmentrepository
    {
        IEnumerable<Department> getall(bool withasnotracking = true);
        IQueryable<Department> getallasquarable();
        Department? getbyid(int id);
        int add(Department entity);
        int update(Department entity);
        int delete(Department entity);   
    }
}

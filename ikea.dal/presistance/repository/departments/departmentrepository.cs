using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.dal.models.departments;
using ikea.dal.presistance.data;
using Microsoft.EntityFrameworkCore;

namespace ikea.dal.presistance.repository.departments
{
    internal class departmentrepository : Idepartmentrepository   
    {

        public departmentrepository(applicationdbcontext dbcontext) {

            _dbcontext = dbcontext;
        }
        
        public IEnumerable<depatment> getall(bool withasnotracking = true)
        {
            if (withasnotracking)
            {

                _dbcontext.departments.asknitracking().tolist();
            }
            return _dbcontext.departments.tolist();
        }

        public depatment? getbyid(int id)
        {
            var departmennt = _dbcontext.departments.local.firstordefault(D => D.id == id);
            var department = _dbcontext.departments.find(id);
            return departmennt;
        }

        public int add(depatment entity)
        {
            _dbcontext.departments.add(entity);
            return _dbcontext.savechanges();
        }
        public int update(depatment entity)
        {
            _dbcontext.departments.update(entity);
            return _dbcontext.savechanges();


        }
        public int delete(depatment entity)
        {
            dbcontext.departments.remove(entity);
            return _dbcontext.savechanges();
        }

    }
}

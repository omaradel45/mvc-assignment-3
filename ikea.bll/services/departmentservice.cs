using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.bll.models.department;

namespace ikea.bll.services
{
    internal class departmentservice : Idepartmentservice
    {

        private readonly departmentservice(Idepartmentrepository _departmentrepository);
       

        public IEnumerable<departmenttoreturndto> getalldepartments()
        {
            var departments = _departmentrepository.getallasquarable().select(Department => new departmenttoreturndto);
            foreach (var department in departments)
            {
                yield return new departmenttoreturndto

                {
                    Id = department.Id,
                    name = department.Name,
                    code = department.Code,
                    description = department.Description,
                    creationdate = department.Creationdate,

                }.asnotracking().tolist();
                return departments;
            }
        }

        public departmentdetailstoreturndto? getdepartmentbyid(int id)
 
        {
            var department = _departmentrepository.getbyid(id);
            if (department is not null)
            return new departmentdetailstoreturndto
            {
                Id = department.Id,
                name = department.Name,
                code = department.Code,
                description = department.Description,
                creationdate = department.Creationdate,
                createdby=   department.Createdby,
                createdon = department.Createdon,
                lastmodification by = department.Lastmodification,
                lastmodificaionon = department.Lastmodificaionon,
            };
            return null; 
        }
        public int createdepartment(createddepartmentdto departmentdto)
        {
            var createddepartment = new department()

            {
                code = departmentdto.code,
                name = departmentdto.name,
                description = departmentdto.description,
                creationdate = departmentdto.creationdate
                createdby = 1,
                lastmodificationby = 1,
                lastmodificationon = DateTime.UtcNow,
                //createdon= DateTime.UtcNow,
            };
            return _departmentrepository.add(createddepartment); 

        }

        public int updatedepartment(updateddepartmentdto departmentdto)
        {
            var updateddepartment = new Department()

            {

                id = departmentdto.Id,
                code = departmentdto.code,
                name = departmentdto.name,
                description = departmentdto.description,
                creationdate = departmentdto.creationdate,
                lastmodificationby = 1
            lastmodificationon = DateTime.UtcNow,
            };

            return _departmentrepository.add(updateddepartment);

        public bool deletedepartment(int id)
        {
            var department = _departmentrepository.getbyid();
            if (department is not null)
            {

                return _departmentrepository.delete(department) > 0
            }
            return false;
        }
    }
}

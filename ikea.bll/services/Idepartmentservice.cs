using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikea.bll.models.department;

namespace ikea.bll.services
{
    internal interface Idepartmentservice
    {

        IEnumerable<departmenttoreturndto> getalldepartments();
        departmentdetailstoreturndto? getdepartmentbyid(int id);
        int createdepartment(createddepartmentdto departmentdto);
        int updatedepartment(updateddepartmentdto departmentdto);
        bool deletedepartment(int id);

    }

}

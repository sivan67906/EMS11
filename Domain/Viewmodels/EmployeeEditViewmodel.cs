using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Viewmodel
{
    public class EmployeeEditViewmodel : EmployeeViewmodel
    {
        public EmpType lstEmpType { get; set; }
        public EmpDepartment lstEmpDepartments { get; set; }
        public EmpAccount lstEmpAccount { get; set; }
        public EmpRole lstEmpRole { get; set; }
        public EmpAuthentication lstEmpAuthentication { get; set; }
        public EmpContactDetail lstEmpContactDetail { get; set; }
    }
}

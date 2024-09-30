using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Viewmodel
{
    public class EmployeeViewmodel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gndr { get; set; }
        public DateTime DateofBirth { get; set; }
        public string CommunicationAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string EmpTypeName { get; set; }
        public string DepartmentName { get; set; }
        public string UserName { get; set; }
        public string IsAccountLock { get; set; }
        public string IsAccountBlock { get; set; }
        public string IsEmailVerified { get; set; }
        public string AuthenticationName { get; set; }
        public string EmpRole { get; set; }

    }
}

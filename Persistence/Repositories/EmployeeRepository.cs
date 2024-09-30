using Application;
using Domain.Entities;
using Domain.Viewmodel;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeDbContext.Employees.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<EmployeeEditViewmodel> GetEditEmployee(int Id)
        {
          
            IEnumerable<EmployeeEditViewmodel> model = null;
            model = (from e in _employeeDbContext.Employees
                            join a in _employeeDbContext.EmpAccounts on e.EmpAccount.Id equals a.Id
                            join auth in _employeeDbContext.EmpAuthentications on e.Authentication.Id equals auth.Id
                            join c in _employeeDbContext.EmpContactDetails on e.EmpContactDetail.Id equals c.Id
                            join d in _employeeDbContext.EmpDepartments on e.EmpDepartmentId equals d.Id
                            join r in _employeeDbContext.EmpRole on e.EmpRole.Id equals r.Id
                            join t in _employeeDbContext.EmpTypes on e.EmpType.Id equals t.Id
                            select new EmployeeEditViewmodel
                            {
                                lstEmpType = t,
                                lstEmpDepartments = d,
                                lstEmpAccount = a,
                                lstEmpRole = r,
                                lstEmpAuthentication = auth,
                                lstEmpContactDetail = c
                            });

            return model;
        }
        public List<EmployeeViewmodel> GetAllEmployees()
        {
            var employees = (from e in _employeeDbContext.Employees
                             join a in _employeeDbContext.EmpAccounts on e.EmpAccount.Id equals a.Id
                             join auth in _employeeDbContext.EmpAuthentications on e.Authentication.Id equals auth.Id
                             join c in _employeeDbContext.EmpContactDetails on e.EmpContactDetail.Id equals c.Id
                             join d in _employeeDbContext.EmpDepartments on e.EmpDepartmentId equals d.Id
                             join r in _employeeDbContext.EmpRole on e.EmpRole.Id equals r.Id
                             join t in _employeeDbContext.EmpTypes on e.EmpType.Id equals t.Id
                             select new EmployeeViewmodel {
                                 Id = e.Id,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName
                                 , Gndr = e.Gender
                                 , DateofBirth = e.DateofBirth
                                 , CommunicationAddress = c.CommunicationAddress
                             , PermanentAddress = c.PermanentAddress
                             , Email = c.Email
                             , PhoneNo = c.PhoneNo
                             , EmpTypeName = t.Name
                             , DepartmentName = d.Name
                             , UserName = a.UserName
                             , IsAccountLock = a.IsAccountLock
                             , IsAccountBlock = a.IsAccountBlock
                             , IsEmailVerified = a.IsEmailVerified
                             , AuthenticationName = auth.Name
                             , EmpRole = r.Name });

            return employees.ToList();
        }

        public EmployeeViewmodel GetEmployeeById(int Id)
        {
            var employees = (from e in _employeeDbContext.Employees
                             join a in _employeeDbContext.EmpAccounts on e.EmpAccount.Id equals a.Id
                             join auth in _employeeDbContext.EmpAuthentications on e.Authentication.Id equals auth.Id
                             join c in _employeeDbContext.EmpContactDetails on e.EmpContactDetail.Id equals c.Id
                             join d in _employeeDbContext.EmpDepartments on e.EmpDepartmentId equals d.Id
                             join r in _employeeDbContext.EmpRole on e.EmpRole.Id equals r.Id
                             join t in _employeeDbContext.EmpTypes on e.EmpType.Id equals t.Id
                             where e.Id == Id
                             select new EmployeeViewmodel
                             {
                                 Id = e.Id,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName
                                 ,
                                 Gndr = e.Gender
                                 ,
                                 DateofBirth = e.DateofBirth
                                 ,
                                 CommunicationAddress = c.CommunicationAddress
                             ,
                                 PermanentAddress = c.PermanentAddress
                             ,
                                 Email = c.Email
                             ,
                                 PhoneNo = c.PhoneNo
                             ,
                                 EmpTypeName = t.Name
                             ,
                                 DepartmentName = d.Name
                             ,
                                 UserName = a.UserName
                             ,
                                 IsAccountLock = a.IsAccountLock
                             ,
                                 IsAccountBlock = a.IsAccountBlock
                             ,
                                 IsEmailVerified = a.IsEmailVerified
                             ,
                                 AuthenticationName = auth.Name
                             ,
                                 EmpRole = r.Name
                             }).FirstOrDefault();

            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDbContext.Update(employee);
            _employeeDbContext.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            _employeeDbContext.Remove(employee);
            _employeeDbContext.SaveChanges();
        }

    }
}

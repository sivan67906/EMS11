using Domain.Entities;
using Domain.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation;
public interface IEmployeeService
{
    Employee GetEmployee(int Id);
    List<EmployeeViewmodel> GetAllEmployees();
    EmployeeViewmodel GetEmployeeById(int Id);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(Employee employee);

    IEnumerable<EmployeeEditViewmodel> GetEditEmployee(int Id);
}

using Application.Services.Implementation;
using Domain.Entities;
using Domain.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public void DeleteEmployee(Employee employee)
    {
        _employeeRepository.DeleteEmployee(employee);
    }

    public List<EmployeeViewmodel> GetAllEmployees()
    {
        return _employeeRepository.GetAllEmployees();
    }

    public IEnumerable<EmployeeEditViewmodel> GetEditEmployee(int Id)
    {
        return _employeeRepository.GetEditEmployee(Id);
    }

    public Employee GetEmployee(int Id)
    {
        return _employeeRepository.GetEmployee(Id);
    }

    public EmployeeViewmodel GetEmployeeById(int Id)
    {
        return _employeeRepository.GetEmployeeById(Id);
    }

    public void UpdateEmployee(Employee employee)
    {
        _employeeRepository.UpdateEmployee(employee);
    }
}

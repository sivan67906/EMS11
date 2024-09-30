using Domain.Entities;
using Domain.Viewmodel;

namespace Application;

public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
    List<EmployeeViewmodel> GetAllEmployees();

    EmployeeViewmodel GetEmployeeById(int Id);

    void UpdateEmployee(Employee employee);
    void DeleteEmployee(Employee employee);

    IEnumerable<EmployeeEditViewmodel> GetEditEmployee(int Id);
}

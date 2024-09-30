using Domain.Common;

namespace Domain.Entities;

public class EmpDepartment : BaseEntity
{
    public string Name { get; set; }

    public List<Employee> Employees { get; set; }
}

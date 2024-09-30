using Domain.Common;

namespace Domain.Entities;

public class EmpRole : BaseEntity
{
    public string Name { get; set; }

    public List<Employee> Employees { get; set; }
}

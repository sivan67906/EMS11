using Domain.Common;

namespace Domain.Entities;

public class EmpType : BaseEntity
{
    public string Name { get; set; }

    public List<Employee> Employees { get; set; }
}

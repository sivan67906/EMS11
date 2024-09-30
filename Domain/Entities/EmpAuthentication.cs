using Domain.Common;

namespace Domain.Entities;

public class EmpAuthentication : BaseEntity
{
    public string Name { get; set; }
    public List<Employee> Employee { get; set; }

}

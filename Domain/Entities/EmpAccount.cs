using Domain.Common;

namespace Domain.Entities;

public class EmpAccount : BaseEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string IsAccountLock { get; set; }
    public string IsAccountBlock { get; set; }
    public string IsEmailVerified { get; set; }
    public Employee Employee { get; set; }

}

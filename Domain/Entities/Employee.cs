using Domain.Common;

namespace Domain.Entities;

public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateofBirth { get; set; }

    public int EmpContactDetailId { get; set; }
    public EmpContactDetail EmpContactDetail { get; set; }

    public int EmpTypeId { get; set; }
    public EmpType EmpType { get; set; }
    public int EmpDepartmentId { get; set; }
    public EmpDepartment EmpDepartment { get; set; }

    public int EmpAccountId { get; set; }
    public EmpAccount EmpAccount { get; set; }
    public int EmpAuthenticationId { get; set; }
    public EmpAuthentication Authentication { get; set; }

    public int EmpRoleId { get; set; }

    public EmpRole EmpRole { get; set; }
}

public enum Gender
{
    MALE,
    FEMALE,
    UNKNOWN
}

using Domain.Common;

namespace Domain.Entities;

public class EmpContactDetail : BaseEntity
{
    public string CommunicationAddress { get; set; }
    public string PermanentAddress { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }
    //public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

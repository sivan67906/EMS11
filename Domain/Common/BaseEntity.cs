namespace Domain.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime Created_Date { get; set; }
    public DateTime Modified_Date { get; set; }
    public int CreatedBy { get; set; }
    public int ModifiedBy { get; set; }

}

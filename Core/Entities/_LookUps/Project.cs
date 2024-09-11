namespace Core.Entities._LookUps;

public class Project : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsActive { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

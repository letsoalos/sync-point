namespace Core.Entities._LookUps;

public class Supplier : BaseEntity
{
    public required string Name { get; set; }
    public required string ContactPersonId { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string StreetName { get; set; }
    public required string Suburb { get; set; }
    public required string City { get; set; }
    public int Code { get; set; }
    public bool IsActive { get; set; }
}

namespace Core.Entities._LookUps;

public class Branch : BaseEntity
{
    public required string Name { get; set; }
    public required string StreetName { get; set; }
    public required string Suburb { get; set; }
    public required string City { get; set; }
    public int Code { get; set; }
    public int ProvinceId { get; set; }
    public int ContactPersonId { get; set; }

    public  Province? Province { get; set; }
}

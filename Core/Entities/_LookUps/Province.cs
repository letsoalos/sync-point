namespace Core.Entities._LookUps;

public class Province : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<Branch>? Branches { get; set; }
}

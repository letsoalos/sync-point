namespace Core.Entities._LookUps;

public class AssetBrand : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsActive { get; set; }
}

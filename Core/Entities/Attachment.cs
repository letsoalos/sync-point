namespace Core.Entities;

public class Attachment : BaseEntity
{
    public int AssetId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string ImageData { get; set; }
    public DateTime CreatedDate { get; set; }
}

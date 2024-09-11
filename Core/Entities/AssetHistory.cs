using Core.Entities._LookUps;

namespace Core.Entities;

public class AssetHistory : BaseEntity
{
    public int AssetId { get; set; }
    public int StatusId { get; set; }
    public DateTime ChangeDate { get; set; }
    public int ChangedByUserId { get; set; }

    public required Status Status { get; set; }
    public required Asset Asset { get; set; }
}

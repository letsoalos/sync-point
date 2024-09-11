using Core.Entities._LookUps;

namespace Core.Entities;

public class AssetMovement : BaseEntity
{
    public int AssetId { get; set; }
    public int FromBranchId { get; set; }
    public int ToBranchId { get; set; }
    public DateTime MovementDate { get; set; }
    public int MovedByUserId { get; set; }

    public required Asset Asset { get; set; }
    public required Branch FromBranch { get; set; }
    public required Branch ToBranch { get; set; }
}

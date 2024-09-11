using Core.Entities._LookUps;

namespace Core.Entities;

public class AuditRecord : BaseEntity
{
    public int AssetId { get; set; }
    public int AuditorId { get; set; }
    public int ConditionId { get; set; }
    public required string Remarks { get; set; }

    public required Asset Asset { get; set; }
    public required Condition Condition { get; set; }
    public bool IsVerified { get; set; }
}

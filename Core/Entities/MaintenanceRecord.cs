using Core.Entities._LookUps;

namespace Core.Entities;

public class MaintenanceRecord : BaseEntity
{
    public int AssetId { get; set; }
    public required string Remarks { get; set; }
    public DateTime MaintenanceDate { get; set; }
    public decimal Cost { get; set; }   
    public DateTime? NextMaintenanceDate { get; set; }
    public int? ServiceProviderId { get; set; }

    public required ServiceProvider ServiceProvider { get; set; }
     public required Asset Asset { get; set; }

}

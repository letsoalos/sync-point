using Core.Entities._LookUps;

namespace Core.Entities
{
    public class Asset : BaseEntity
    {
        // Basic Asset Information
        public required string Name { get; set; }
        public string? SerialNumber { get; set; }
        public string? Description { get; set; }
        public string? PictureUrl { get; set; }
        public string? Barcode { get; set; }

        // Vehicle-Specific Fields
        public string? VehicleRegistration { get; set; }
        public string? VIN { get; set; }
        public string? EngineNumber { get; set; }
        public string? VehicleRegisterNumber { get; set; }
        public string? VehicleModel { get; set; }
        public string? Mileage { get; set; }

        // Foreign Keys
        public int AssetTypeId { get; set; }
        public int AssetBrandId { get; set; }
        public int BranchId { get; set; }
        public int OwnershipCategoryId { get; set; }
        public int ServiceProviderId { get; set; }
        public int StatusId { get; set; }
        public int ConditionId { get; set; }
        public int? InsurerId { get; set; }
        public int? BinLocationId { get; set; }

        // Financial and Status Information
        public decimal? RentalAmount { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public DateTime? AssignedDate { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }

        // User Tracking
        public int AssignedToUserId { get; set; }
        public int AssignedByUserId { get; set; }
        public int? ApprovedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? DateLastModified { get; set; }
        public int? ModifiedByUserId { get; set; }

        // Status
        public bool IsActive { get; set; }

        // Navigation Properties
        public AssetType? AssetType { get; set; }
        public AssetBrand? AssetBrand { get; set; }
        public Branch? Branch { get; set; }
        public OwnershipCategory? OwnershipCategory { get; set; }
        public ServiceProvider? ServiceProvider { get; set; }
        public Status? Status { get; set; }
        public Condition? Condition { get; set; }
        public Insurer? Insurer { get; set; }
        public BinLocation? BinLocation { get; set; }
    }
}

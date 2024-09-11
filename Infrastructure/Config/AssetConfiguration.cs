using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.Property(x => x.RentalAmount).HasColumnType("decimal(18,2)");
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.Description).HasMaxLength(255);
        builder.Property(x => x.SerialNumber).HasMaxLength(255);
        builder.Property(x => x.Barcode).HasMaxLength(255);
        builder.Property(x => x.VehicleRegisterNumber).HasMaxLength(255);
        builder.Property(x => x.VehicleRegistration).HasMaxLength(255);
        builder.Property(x => x.EngineNumber).HasMaxLength(255);
        builder.Property(x => x.VehicleModel).HasMaxLength(255);
        builder.Property(x => x.Mileage).HasMaxLength(255);
        builder.Property(x => x.VIN).HasMaxLength(255);
    }
}

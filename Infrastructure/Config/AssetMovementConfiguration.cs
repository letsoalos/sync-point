using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class AssetMovementConfiguration : IEntityTypeConfiguration<AssetMovement>
{
    public void Configure(EntityTypeBuilder<AssetMovement> builder)
    {
        builder.HasOne(ah => ah.FromBranch)
            .WithMany()
            .HasForeignKey(ah => ah.FromBranchId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(ah => ah.ToBranch)
            .WithMany()
            .HasForeignKey(ah => ah.ToBranchId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

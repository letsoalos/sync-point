using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class AuditRecordConfiguration : IEntityTypeConfiguration<AuditRecord>
{
    public void Configure(EntityTypeBuilder<AuditRecord> builder)
    {
        builder.HasOne(ah => ah.Asset)
            .WithMany()
            .HasForeignKey(ah => ah.AssetId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(ah => ah.Condition)
            .WithMany()
            .HasForeignKey(ah => ah.ConditionId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

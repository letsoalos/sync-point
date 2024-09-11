using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class AssetHistoryConfiguration : IEntityTypeConfiguration<AssetHistory>
{
    public void Configure(EntityTypeBuilder<AssetHistory> builder)
    {
        builder.HasOne(ah => ah.Status)
            .WithMany()
            .HasForeignKey(ah => ah.StatusId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(ah => ah.Asset)
            .WithMany()
            .HasForeignKey(ah => ah.AssetId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

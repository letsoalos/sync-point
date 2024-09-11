using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class OwnershipCategoryConfiguration : IEntityTypeConfiguration<OwnershipCategory>
{
    public void Configure(EntityTypeBuilder<OwnershipCategory> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.Description).HasMaxLength(255);
    }
}

using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.StreetName).HasMaxLength(255);
        builder.Property(x => x.Suburb).HasMaxLength(255);
        builder.Property(x => x.City).HasMaxLength(255);
    }
}

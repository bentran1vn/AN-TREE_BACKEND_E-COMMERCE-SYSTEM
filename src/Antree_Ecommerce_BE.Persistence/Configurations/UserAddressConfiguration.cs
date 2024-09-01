using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
{
    public void Configure(EntityTypeBuilder<UserAddress> builder)
    {
        builder.ToTable(TableNames.UserAddress);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Address).HasMaxLength(500).IsRequired(true);
        builder.Property(x => x.City).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Province).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired(true);
        builder.Property(x => x.IsOrder).IsRequired(true);
    }
}
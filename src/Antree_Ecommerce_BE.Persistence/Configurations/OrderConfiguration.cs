using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(TableNames.Order);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Address).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.Note).HasMaxLength(500).IsRequired(true);
        builder.Property(x => x.Total).IsRequired(true);
    }
}
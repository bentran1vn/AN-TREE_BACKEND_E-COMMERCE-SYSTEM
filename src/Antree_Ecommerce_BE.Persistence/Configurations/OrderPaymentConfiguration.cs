using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class OrderPaymentConfiguration : IEntityTypeConfiguration<OrderPayment>
{
    public void Configure(EntityTypeBuilder<OrderPayment> builder)
    {
        builder.ToTable(TableNames.OrderPayment);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Cvc).HasMaxLength(20).IsRequired(true);
        builder.Property(x => x.Expire).HasMaxLength(20).IsRequired(true);
        builder.Property(x => x.CardNumber).HasMaxLength(100).IsRequired(true);
    }
}
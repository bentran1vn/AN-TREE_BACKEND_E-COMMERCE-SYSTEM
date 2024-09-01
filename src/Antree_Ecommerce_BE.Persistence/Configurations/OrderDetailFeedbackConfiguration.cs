using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class OrderDetailFeedbackConfiguration : IEntityTypeConfiguration<OrderDetailFeedback>
{
    public void Configure(EntityTypeBuilder<OrderDetailFeedback> builder)
    {
        builder.ToTable(TableNames.OrderDetailFeedback);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Content).HasMaxLength(500).IsRequired(true);
        builder.Property(x => x.Rating).IsRequired(true);
    }
}
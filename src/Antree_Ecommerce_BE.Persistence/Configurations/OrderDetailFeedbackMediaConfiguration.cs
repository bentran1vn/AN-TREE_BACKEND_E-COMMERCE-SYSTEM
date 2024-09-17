using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class OrderDetailFeedbackMediaConfiguration: IEntityTypeConfiguration<OrderDetailFeedbackMedia>
{
    public void Configure(EntityTypeBuilder<OrderDetailFeedbackMedia> builder)
    {
        builder.ToTable(TableNames.OrderDetailFeedbackMedia);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.ImageUrl).HasMaxLength(500).IsRequired(true);
    }
}
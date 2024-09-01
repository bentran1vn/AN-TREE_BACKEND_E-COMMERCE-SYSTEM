using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class ProductFeedbackConfiguration : IEntityTypeConfiguration<ProductFeedback>
{
    public void Configure(EntityTypeBuilder<ProductFeedback> builder)
    {
        builder.ToTable(TableNames.ProductFeedback);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Rate).IsRequired(true);
        builder.Property(x => x.Total).IsRequired(true);
    }
}
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable(TableNames.ProductCategory);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(500).IsRequired(true);
        
        builder.HasData(
            new ProductCategory(
                Guid.Parse("26df3c94-715f-4048-a96a-04a6e80bbd15"), "Cate1",
                "Des1",Guid.Parse("2cd8a571-f443-4623-97dd-c8d4a41a80bf"),
                Guid.Empty
            ),
            new ProductCategory(
                Guid.Parse("acc02cc0-825a-4453-b923-e6ae7f4007a4"), "Cate2",
                "Des2",Guid.Parse("2cd8a571-f443-4623-97dd-c8d4a41a80bf"),
                Guid.Empty
            ),
            new ProductCategory(
                Guid.Parse("8d81bd6c-b108-4611-acee-ef78286eec24"), "Cate3",
                "Des3",Guid.Parse("2cd8a571-f443-4623-97dd-c8d4a41a80bf"),
                Guid.Empty
            )
        );
        
    }
}
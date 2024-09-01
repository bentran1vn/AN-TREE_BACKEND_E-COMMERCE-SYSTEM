using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(TableNames.Product);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()"); ;
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.Description)
            .HasMaxLength(500).IsRequired(true);
        builder.Property(x => x.Sku).IsRequired();
        builder.Property(x => x.Sold).IsRequired();

        for (int i = 0; i <= 40; i++)
        {
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Name" + i.ToString(),
                    Description = "Description" + i.ToString(),
                    Price = decimal.Parse(i.ToString()),
                    Sku = i,
                    Sold = i,
                    CreatedBy = Guid.NewGuid(),
                    ProductCategoryId = i % 2 == 0 ?
                        Guid.Parse("26df3c94-715f-4048-a96a-04a6e80bbd15") 
                        : Guid.Parse("acc02cc0-825a-4453-b923-e6ae7f4007a4"),
                }
            );
        }
    }
}
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
            var id = Guid.NewGuid();
            var name = "Name" + i.ToString();
            var description = "Description" + i.ToString();
            var price = decimal.Parse((i * 1000).ToString());
            var sku = i;
            var sold = 0;
            var createdBy = Guid.NewGuid();
            var productCategoryId = i % 2 == 0
                ? Guid.Parse("26df3c94-715f-4048-a96a-04a6e80bbd15")
                : Guid.Parse("acc02cc0-825a-4453-b923-e6ae7f4007a4");
            var vendorId = i % 2 == 0
                ? Guid.Parse("f5ef2d83-48fd-41ea-952b-c3803a59b2c1")
                : Guid.Parse("d5ab34c8-d8ce-4e30-9446-13735a334ef2");
            builder.HasData(
                new Product(id, productCategoryId, vendorId, name, price, price, description, sku, sold, "", createdBy, Guid.Empty)
            );
        }
    }
}
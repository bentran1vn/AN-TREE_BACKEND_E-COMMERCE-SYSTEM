using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.ToTable(TableNames.Vendor);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Address).IsRequired();
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.City).IsRequired();
        builder.Property(x => x.Phonenumber).IsRequired();
        
        builder.HasData(
            new Vendor(
                Guid.Parse("f5ef2d83-48fd-41ea-952b-c3803a59b2c1"), "Vendor1@gmail.com",
                "Vendor1", "VendorAddress1", "VendorCity1", "VendorProvince1",
                "VendorPhone1"),
            new Vendor(
                Guid.Parse("d5ab34c8-d8ce-4e30-9446-13735a334ef2"), "Vendor2@gmail.com",
                "Vendor2", "VendorAddress2", "VendorCity2", "VendorProvince2",
                "VendorPhone2"),
            new Vendor(
                Guid.Parse("f5565937-575b-462a-903c-404727ba3765"), "Vendor3@gmail.com",
                "Vendor3", "VendorAddress3", "VendorCity3", "VendorProvince3",
                "VendorPhone3")
        );
    }
}
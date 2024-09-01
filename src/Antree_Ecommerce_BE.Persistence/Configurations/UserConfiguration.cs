using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(TableNames.User);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Firstname).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Password).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.Lastname).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Username).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Role).IsRequired(true);
        builder.Property(x => x.Phonenumber).HasMaxLength(100).IsRequired(true);
    }
}
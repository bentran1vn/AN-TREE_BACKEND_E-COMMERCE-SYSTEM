using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence.Constrants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Antree_Ecommerce_BE.Persistence.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable(TableNames.Transaction);

        builder.HasKey(x => x.Id);
    }
}
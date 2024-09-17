using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder) =>
        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

    public DbSet<Product> Products { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<OrderPayment> OrderPayments { get; set; }
    public DbSet<OrderDetailFeedback> OrderDetailFeedbacks { get; set; }
    public DbSet<ProductFeedback> ProductFeedbacks { get; set; }
    public DbSet<ProductDiscount> ProductDiscounts { get; set; }
    public DbSet<ProductCategory> ProductCategorys { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserAddress> UserAddresses { get; set; }
    public DbSet<UserPayment> UserPayments { get; set; }
    public DbSet<ProductMedia> ProductMedias { get; set; }
    public DbSet<OrderDetailFeedbackMedia> OrderDetailFeedbackMedias { get; set; }
}
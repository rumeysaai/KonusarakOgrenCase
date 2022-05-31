using KonusarakOgren.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonusarakOgren.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public ApplicationDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-TGHGBD6;Database=KonusarakOgren;integrated security =true;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.ApplyConfiguration(new ProductEntityConfiguration());
        builder.ApplyConfiguration(new OrderEntityConfiguration());
        builder.ApplyConfiguration(new CommentEntityConfiguration());
        builder.ApplyConfiguration(new OrderProductsEntityConfiguration());
    }

    public DbSet<KonusarakOgren.Areas.Identity.Data.Products>? Products { get; set; }
}

internal class OrderProductsEntityConfiguration : IEntityTypeConfiguration<OrderProducts>
{
    public void Configure(EntityTypeBuilder<OrderProducts> builder)
    {
        builder.HasNoKey();
    }
}

public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(u => u.Id).UseIdentityColumn(1, 1);
        builder.Property(u => u.Text).HasMaxLength(255);
    }
}

public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(u => u.Id).UseIdentityColumn(1, 1);
    }
}

public class ProductEntityConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.Property(u => u.Id).UseIdentityColumn(1, 1);
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
        builder.Property(u => u.UserRole).IsRequired();
    }
}
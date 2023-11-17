using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Persistense.DBContext.TableConfiguration;

public class OrderItemTableConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("order_items");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        
        builder
            .HasOne(o => o.Order)
            .WithMany(i => i.OrderItems)
            .HasForeignKey(x => x.OrderUnitId);
        
    }
}
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Persistense.DBContext.TableConfiguration;

public class OrderTableConfiguration : IEntityTypeConfiguration<OrderUnit>
{
    public void Configure(EntityTypeBuilder<OrderUnit> builder)
    {
        builder.ToTable("orders");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseHiLo("orders_id");

        builder
            .HasMany(x => x.OrderItems)
            .WithOne(x=>x.Order)
            .HasForeignKey(x => x.OrderUnitId);
        builder.HasOne(p => p.Provider)
            .WithOne()
            .HasForeignKey<OrderUnit>(x => x.ProviderId);
    }
}
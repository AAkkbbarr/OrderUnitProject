using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Persistense.DBContext.TableConfiguration;

public class ProviderTableConfiguration : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> builder)
    {
        builder.ToTable("provider");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
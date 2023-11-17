using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructura.Persistense.DBContext;

public class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<Context>();
        optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OrderDbUsername=postgres;Password=postgres");
        return new Context(optionBuilder.Options);
    }
}
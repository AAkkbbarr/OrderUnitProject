using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Persistense.DBContext
{
    public class Context : DbContext
    {
        
        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseNpgsql(@"Host=localhost;Port=5432;Database=OrderDb;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<EntityBase>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TableConfiguration.OrderTableConfiguration).Assembly);
        }
    }
}

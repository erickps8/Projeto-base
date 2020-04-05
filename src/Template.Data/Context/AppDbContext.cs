using Microsoft.EntityFrameworkCore;
using System.Linq;
using Template.Business.Models;

namespace Template.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Example> Exemple { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //foreach (var property in builder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //        .Where(p => p.ClrType == typeof(string))))
            //    property.SetColumnType("varchar(100)");

            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            base.OnModelCreating(builder);
        }

    }
}

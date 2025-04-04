using App.Domain.Core.Mayne.Connection;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Db.SqlServer
{
    public class MayneDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration.CostomerConfiguration.CostomerConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.OperatorConfiguration.OperatorConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.CarConfiguration.CarConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}

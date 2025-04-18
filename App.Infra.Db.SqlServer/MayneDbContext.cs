using App.Domain.Core.Mayne.Connection;
using App.Infra.Db.SqlServer.Configuration.CarConfiguration;
using App.Infra.Db.SqlServer.Configuration.CostomerConfiguration;
using App.Infra.Db.SqlServer.Configuration.OperatorConfiguration;
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
            modelBuilder.ApplyConfiguration(new CostomerConfiguration());
            modelBuilder.ApplyConfiguration(new OperatorConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}

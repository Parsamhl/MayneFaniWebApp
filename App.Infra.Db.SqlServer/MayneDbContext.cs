using App.Domain.Core.Mayne.Base.Entities;
using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.City.Entities;
using App.Domain.Core.Mayne.Connection;
using App.Domain.Core.Mayne.History.Entites;
using App.Domain.Core.Mayne.Reservation.Entities;
using App.Domain.Core.Mayne.User.Entities;
using App.Infra.Db.SqlServer.Configuration.BaseConfiguration;
using App.Infra.Db.SqlServer.Configuration.CarConfiguration;
using App.Infra.Db.SqlServer.Configuration.CarHistoryConfiguratiom;
using App.Infra.Db.SqlServer.Configuration.CostomerConfiguration;
using App.Infra.Db.SqlServer.Configuration.OperatorConfiguration;
using App.Infra.Db.SqlServer.Configuration.ReservationConfiguration;
using App.Infra.Db.SqlServer.Configuration.UserConfiguration;
using Microsoft.EntityFrameworkCore;
using System;

namespace App.Infra.Db.SqlServer
{
    public class MayneDbContext : DbContext
    {


        public MayneDbContext(DbContextOptions<MayneDbContext> options) : base(options)
        {
        }
    
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
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BaseConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new CarHistoryConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Operator> Operator { get; set; }
        public DbSet<CarHistory> CarHistory { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Costomer> Costomers { get; set; }
        public DbSet<Base> Bases { get; set; }

    }
}

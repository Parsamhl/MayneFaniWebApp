using App.Domain.Core.Mayne.Cars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Configuration.CarConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(c => c.PlateNumber);

            builder.HasOne(c => c.CarOwner).WithMany(c => c.CostomerCars)
                .HasForeignKey(c => c.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}

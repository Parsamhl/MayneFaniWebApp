using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.Reservation.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Configuration.ReservationConfiguration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Car)
                .WithOne(x => x.reserve)
                .HasForeignKey<Car>(x => x.CarId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x=>x.Base)
                .WithMany(x=>x.DailyReservations)
                .HasForeignKey(x=> x.BaseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

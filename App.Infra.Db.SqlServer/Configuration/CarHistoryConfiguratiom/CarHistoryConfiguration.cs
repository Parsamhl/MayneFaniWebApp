using App.Domain.Core.Mayne.History.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.CarHistoryConfiguratiom
{
    public class CarHistoryConfiguration : IEntityTypeConfiguration<CarHistory>
    {
        public void Configure(EntityTypeBuilder<CarHistory> builder)
        {
            builder.ToTable("CarHistory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Car)
                .WithMany(x=> x.CarHistory)
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }



}


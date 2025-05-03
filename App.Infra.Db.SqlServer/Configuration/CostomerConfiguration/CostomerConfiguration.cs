using App.Domain.Core.Mayne.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.CostomerConfiguration
{
    public class CostomerConfiguration : IEntityTypeConfiguration<Costomer>
    {
        public void Configure(EntityTypeBuilder<Costomer> builder)
        {
            builder.ToTable("Costomers");

          //  builder.HasKey(x => x.NationalCode);

            builder.HasMany(x=> x.CostomerCars)
                .WithOne(x=>x.CarOwner)
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

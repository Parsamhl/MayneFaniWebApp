﻿using App.Domain.Core.Mayne.Base.Entities;
using App.Domain.Core.Mayne.City.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.BaseConfiguration
{
    public class BaseConfiguration : IEntityTypeConfiguration<Base>
    {
        public void Configure(EntityTypeBuilder<Base> builder)
        {
            builder.ToTable("Bases");

            builder.HasKey(x => x.BaseNumber);

            builder.HasOne(x => x.City)
                .WithMany(x => x.Bases)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);

             

        }
    }
}

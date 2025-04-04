using App.Domain.Core.Mayne.City.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Configuration.CityConfiguration.cs
{
    public class CityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
        }
    }
}

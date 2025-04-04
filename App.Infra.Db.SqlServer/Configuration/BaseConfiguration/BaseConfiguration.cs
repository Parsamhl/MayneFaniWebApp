using App.Domain.Core.Mayne.Base.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.BaseConfiguration
{
    public class BaseConfiguration : IEntityTypeConfiguration<Base>
    {
        public void Configure(EntityTypeBuilder<Base> builder)
        {
            builder.ToTable("Bases");

        }
    }
}

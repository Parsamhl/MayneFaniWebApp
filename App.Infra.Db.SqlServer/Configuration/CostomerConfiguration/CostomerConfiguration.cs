using App.Domain.Core.Mayne.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Configuration.CostomerConfiguration
{
    public class CostomerConfiguration : IEntityTypeConfiguration<Costomer>
    {
        public void Configure(EntityTypeBuilder<Costomer> builder)
        {
            builder.ToTable("Costomers")l
        }
    }
}

using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembleia.Sede.Cadastro.Data.Mappings
{
    public class CongregationMap : IEntityTypeConfiguration<Congregation>
    {
        public void Configure(EntityTypeBuilder<Congregation> builder)
        {
            builder.ToTable("TB_Congregation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            //Relacionamento
            builder.HasOne(x => x.City).WithMany(c => c.Congregations).HasForeignKey(x => x.CityId);
        }
    }
}

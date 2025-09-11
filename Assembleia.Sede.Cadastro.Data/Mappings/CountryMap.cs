using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assembleia.Sede.Cadastro.Data.Mappings
{
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("TB_Country");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.IsoTwo).HasMaxLength(3);

            //Relacionamento

            builder.HasMany(x => x.States).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);
        }
    }
}

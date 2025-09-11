using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assembleia.Sede.Cadastro.Data.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("TB_State");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();



            //Relacionamento

            builder.Property(x => x.Uf).HasMaxLength(2);
            builder.HasOne(x => x.Country).WithMany(x => x.States).HasForeignKey(x => x.CountryId);
            builder.HasMany(x => x.Cities).WithOne(x => x.State).HasForeignKey(x => x.StateId);
        }
    }
}

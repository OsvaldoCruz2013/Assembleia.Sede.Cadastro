using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assembleia.Sede.Cadastro.Data.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(nameof(City));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();




            //Relacionamento
        
            builder.HasOne(x => x.State).WithMany(x => x.Cities).HasForeignKey(x => x.StateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Members).WithOne(x => x.City).HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

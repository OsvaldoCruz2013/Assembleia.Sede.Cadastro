using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assembleia.Sede.Cadastro.Data.Mappings
{
    public class MemberMap : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("TB_Member");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();


            //Relacionamento
            builder.HasOne(c => c.City).WithMany(c => c.Members).HasForeignKey(x => x.CityId);

        }
    }
}

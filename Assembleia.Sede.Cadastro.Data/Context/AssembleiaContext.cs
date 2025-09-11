using Assembleia.Sede.Cadastro.Data.Mappings;
using Assembleia.Sede.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assembleia.Sede.Cadastro.Data.Context
{
    public class AssembleiaContext(DbContextOptions<AssembleiaContext> option) : DbContext(option)
    {
        public DbSet<Member> Member => Set<Member>();
        public DbSet<City> City => Set<City>();
        public DbSet<State> State => Set<State>();
        public DbSet<Country> Country => Set<Country>();
        public DbSet<Congregation> Congregation => Set<Congregation>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MemberMap).Assembly);
        }
    }
}

using Assembleia.Sede.Cadastro.Domain.Entites.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entities
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        public string Iso2 { get; set; }

        public ICollection<State> States { get; set; } = new List<State>();
    }
}

using Assembleia.Sede.Cadastro.Domain.Entities.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entities
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        public string IsoTwo { get; set; }

        public ICollection<State> States { get; set; }
    }
}

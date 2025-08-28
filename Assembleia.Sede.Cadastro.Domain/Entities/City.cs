using Assembleia.Sede.Cadastro.Domain.Entities.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entities
{
    public class City : EntityBase
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}

using Assembleia.Sede.Cadastro.Domain.Entities;
using Assembleia.Sede.Cadastro.Domain.Entities.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entities;

public class Congregation : EntityBase
{
    public string Name { get; set; }

    public ICollection<Member> Members { get; set; }
}

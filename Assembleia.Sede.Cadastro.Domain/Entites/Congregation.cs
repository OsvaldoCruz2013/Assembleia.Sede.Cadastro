using Assembleia.Sede.Cadastro.Domain.Entites.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entites;

public class Congregation : EntityBase
{
    public string Name { get; set; }

    public ICollection<Member> Members { get; set; }
}

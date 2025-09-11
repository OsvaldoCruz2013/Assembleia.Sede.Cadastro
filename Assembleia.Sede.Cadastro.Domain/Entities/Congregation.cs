using Assembleia.Sede.Cadastro.Domain.Entities;
using Assembleia.Sede.Cadastro.Domain.Entities.Base;

namespace Assembleia.Sede.Cadastro.Domain.Entities;

public class Congregation : EntityBase
{
    public string Name { get; set; }
    public virtual City City { get; set; }
    public int CityId { get; set; }
   

    public ICollection<Member> Members { get; set; } 
    

 
}

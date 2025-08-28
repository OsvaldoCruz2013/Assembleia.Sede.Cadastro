using Assembleia.Sede.Cadastro.Domain.Entites.Base;
using System.Collections.Generic;


namespace Assembleia.Sede.Cadastro.Domain.Entities
{
    public class State : EntityBase
    {
        public string Name { get; set; }     
        public string Uf { get; set; }        

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; } 
    }
}

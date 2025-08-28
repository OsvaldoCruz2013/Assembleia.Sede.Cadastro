using Assembleia.Sede.Cadastro.Domain.Entities.Base;
using Assembleia.Sede.Cadastro.Domain.Entities;
using Assembleia.Sede.Cadastro.Domain.Enums;

namespace Assembleia.Sede.Cadastro.Domain.Entities;

public class Member : EntityBase
{
    public Sector Sector { get; set; } //setor - (entidade)
    public string Name { get; set; } // nome
    public string Nationality { get; set; } //nacionalidade - (enum)
    public string Maritalstatus { get; set; } //estado civil  - (enum)
    public string Cpf { get; set; } //cpf 
    public string Rg { get; set; }//rg
    public string VoterRegistrationCard { get; set; } //t. eleitor
    public string Zona { get; set; } //zona
    public string Secction { get; set; } //seção
    public string Profission { get; set; } //profissão
    public string School { get; set; } //escolaridade - (enum)
    public string NativeOf { get; set; } //natural de - (entidade)
    public string Uf { get; set; } //estado - (entidade)
    public string State { get; set; } //estado - (entidade)
    public DateTime? DateOfBirth { get; set; } //data nascimento 
    public string Spouse { get; set; } //conjuge
    public string HowManyChildren { get; set; } //quantos filhos
    public string PhoneNumberOne { get; set; } //telefone
    public string PhoneNumberTwo { get; set; } //telefone
    public bool IsMusic { get; set; } //é musico?
    public bool IsDriver { get; set; } //é motorista
    public bool IsVehicle { get; set; } //possui veiculo?
    public bool IsHouse { get; set; } //Mora em casa própria?
    public bool IsFemaleChurchMember { get; set; } //o conjuge é membro da igreja?
    public bool IsChildrenAreInChurch { get; set; } //os filhos estão na igreja?
    public bool IsWhichChurchIsComing { get; set; } //qual igreja está vindo?
    public DateTime? BaptizedBbyImmersion { get; set; } //  batizado por imersão em:
    public string ByTheChruch { get; set; } //nome da igreja 
    public string WithHolySpirit { get; set; } //com espirito santo em:
    public DateTime Admitted { get; set; } // admitido em:
    
    /// <summary>
    /// Relacionation Congregação com members
    /// </summary>
    public int CongregationId { get; set; }
    public Congregation Congregation { get; set; }

    /// <summary>
    /// Relacionation City com members
    /// </summary>
    public int CityId { get; set; }
    public City City { get; set; } 
}
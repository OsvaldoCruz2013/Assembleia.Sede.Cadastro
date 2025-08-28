using System.ComponentModel;

namespace Assembleia.Sede.Cadastro.Domain.Enums
{
    public enum Nationality : byte
    {
        [Description("Não Informado")]
        Unknown = 0,      
        [Description("Brasileira")]
        Brazilian,    
        [Description("Estrangeiro")]
        foreigner  
    }
}

using System.ComponentModel;

namespace Assembleia.Sede.Cadastro.Domain.Enums
{
    public enum Maritalstatus : byte
    {
        [Description("Não Informado")]
        None = 0,        
        [Description("Solteiro")]
        Single ,      
        [Description("Casado(a)")]
        Married,
        [Description("Viúvo(a)")]
        Widowed,     
        [Description("Divorciado(a)")]
        Divorced,    
        [Description("Separado(a)")]
        Separated,  
        [Description("União Estável")]
        StableUnion 
    }
}

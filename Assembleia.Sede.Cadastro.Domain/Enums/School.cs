using System.ComponentModel;

namespace Assembleia.Sede.Cadastro.Domain.Enums
{
    public enum School : byte
    {
        [Description("Não Informado")]
        Unknown = 0,
        [Description("Fundamental")]
        Elementary,   
        [Description("Médio")]
        HighSchool,   
        [Description("Técnico")]
        Technical,   
        [Description("Superior - Completo")]
        CompleteGraduation,
        [Description("Superior - Incompleto")]
        IncompleteGraduation,
        [Description("Pós - Graduação")]
        Postgraduate, 
        [Description("Mestrado")]
        Masters,      
        [Description("Doutorado")]
        Doctorate     
    }
}

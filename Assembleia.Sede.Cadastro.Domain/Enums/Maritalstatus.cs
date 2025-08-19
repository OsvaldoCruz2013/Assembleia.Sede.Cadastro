namespace Assembleia.Sede.Cadastro.Domain.Enums
{
    public enum Maritalstatus : byte
    {
        None = 0,        // não informado
        Single = 1,      // solteiro(a)
        Married = 2,     // casado(a)
        Widowed = 3,     // viúvo(a)
        Divorced = 4,    // divorciado(a)
        Separated = 5,   // separado(a)
        StableUnion = 6  // união estável
    }
}

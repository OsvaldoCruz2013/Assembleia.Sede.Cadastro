using Assembleia.Sede.Cadastro.Domain.Enums;

namespace Assembleia.Sede.Cadastro.Domain.Entities.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public Situation Situation { get; set; } = Situation.Active;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

        public int UserCreatedId { get; set; }

        public int? UserModifiedId { get; set; }

        public int? UserDeletedId { get; set; }
    }
}

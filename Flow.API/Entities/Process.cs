using Flow.API.Database.Configuration;
using Flow.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Flow.API.Entities
{
    [EntityTypeConfiguration(typeof(ProcessEntityConfiguration))]
    public class Process : IAggregateRoot
    {
        public int Id { get; set; }
        public Guid ProcessoId { get; set; }
        public Guid? ProcessoPaiId { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? Ativo { get; set; }
    }
}

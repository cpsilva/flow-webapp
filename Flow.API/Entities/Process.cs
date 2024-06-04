using Flow.API.Database.Configuration;
using Flow.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Flow.API.Entities
{
    [EntityTypeConfiguration(typeof(ProcessEntityConfiguration))]
    public class Process : IAggregateRoot
    {
        public int Id { get; init; }
        public Guid ProcessId { get; init; }
        public int? OriginProcessId { get; init; }
        public DateTime InclusionDate { get; init; }
        public DateTime? UpdatedDate { get; init; }
        public bool? Active { get; init; }
    }
}

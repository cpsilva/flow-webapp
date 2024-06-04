using Flow.Core.Domain;

namespace Flow.API.Entities
{
    public class ProcessMap : IAggregateRoot
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public string XmlDiagram { get; set; }
        public virtual Process Process { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

using Flow.Core.Domain;

namespace Flow.API.Entities
{
    public class ProcessMap : IAggregateRoot
    {
        public int Id { get; set; }
        public int ProcessoId { get; set; }
        public string XmlDiagram { get; set; }
        public virtual Process Processo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}

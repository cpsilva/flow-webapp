using Flow.Core.Domain;

namespace Flow.API.Entidades
{
    public class MapeamentoProcesso : IAggregateRoot
    {
        public int Id { get; set; }
        public int ProcessoId { get; set; }
        public string XmlDiagram { get; set; }
        public virtual Processo Processo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}

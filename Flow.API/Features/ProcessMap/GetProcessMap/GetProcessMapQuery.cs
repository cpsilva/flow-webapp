using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.GetProcessMap
{
    public class GetProcessMapQuery : IRequest<Result<ProcessMapResponse>>
    {
        public GetProcessMapQuery(int mapeamentoProcessoId)
        {
            MapeamentoProcessoId = mapeamentoProcessoId;
        }

        public int MapeamentoProcessoId { get; set; }
    }
}

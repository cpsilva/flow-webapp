using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.GetProcessMap
{
    public class ObterMapeamentoProcessoQuery : IRequest<Result<MapeamentoProcessoResponse>>
    {
        public ObterMapeamentoProcessoQuery(int mapeamentoProcessoId)
        {
            MapeamentoProcessoId = mapeamentoProcessoId;
        }

        public int MapeamentoProcessoId { get; set; }
    }
}
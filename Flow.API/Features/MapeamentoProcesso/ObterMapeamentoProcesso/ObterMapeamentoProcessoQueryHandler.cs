using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.ObterMapeamentoProcesso
{
    public class ObterMapeamentoProcessoQueryHandler : IRequestHandler<ObterMapeamentoProcessoQuery, Result<MapeamentoProcessoResponse>>
    {
        public Task<Result<MapeamentoProcessoResponse>> Handle(ObterMapeamentoProcessoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

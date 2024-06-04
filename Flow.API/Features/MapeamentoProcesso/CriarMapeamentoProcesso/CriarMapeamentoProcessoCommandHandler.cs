using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.CriarMapeamentoProcesso
{
    public class CriarMapeamentoProcessoCommandHandler : IRequestHandler<CriarMapeamentoProcessoCommand, Result<int>>
    {
        public Task<Result<int>> Handle(CriarMapeamentoProcessoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

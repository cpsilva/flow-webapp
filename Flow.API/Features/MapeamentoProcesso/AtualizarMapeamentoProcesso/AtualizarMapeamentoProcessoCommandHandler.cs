using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.AtualizarMapeamentoProcesso
{
    public class AtualizarMapeamentoProcessoCommandHandler : IRequestHandler<AtualizarMapeamentoProcessoCommand, Result<int>>
    {
        public Task<Result<int>> Handle(AtualizarMapeamentoProcessoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.UpdateProcessMap
{
    public class AtualizarMapeamentoProcessoCommand : IRequest<Result<int>>
    {
        public AtualizarMapeamentoProcessoCommand(AtualizarMapeamentoProcessoRequest request)
        {

        }
    }
}
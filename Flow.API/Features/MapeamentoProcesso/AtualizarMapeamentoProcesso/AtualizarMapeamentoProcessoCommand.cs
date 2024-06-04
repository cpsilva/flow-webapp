using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.AtualizarMapeamentoProcesso
{
    public class AtualizarMapeamentoProcessoCommand : IRequest<Result<int>>
    {
        public AtualizarMapeamentoProcessoCommand(AtualizarMapeamentoProcessoRequest request)
        {

        }
    }
}
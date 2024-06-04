using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.CriarMapeamentoProcesso
{
    public class CriarMapeamentoProcessoCommand : IRequest<Result<int>>
    {
        public CriarMapeamentoProcessoCommand(CriarMapeamentoProcessoRequest request)
        {

        }
    }
}
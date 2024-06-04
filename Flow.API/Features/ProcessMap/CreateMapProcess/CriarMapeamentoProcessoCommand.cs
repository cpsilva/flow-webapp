using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CriarMapeamentoProcessoCommand : IRequest<Result<int>>
    {
        public CriarMapeamentoProcessoCommand(CriarMapeamentoProcessoRequest request) { }
    }
}

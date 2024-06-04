using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CriarMapeamentoProcessoCommandHandler : IRequestHandler<CriarMapeamentoProcessoCommand, Result<int>>
    {
        public Task<Result<int>> Handle(CriarMapeamentoProcessoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

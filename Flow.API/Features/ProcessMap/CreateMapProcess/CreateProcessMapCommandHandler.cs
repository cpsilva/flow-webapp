using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CreateProcessMapCommandHandler
        : IRequestHandler<CreateProcessMapCommand, Result<int>>
    {
        public Task<Result<int>> Handle(
            CreateProcessMapCommand request,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }
    }
}

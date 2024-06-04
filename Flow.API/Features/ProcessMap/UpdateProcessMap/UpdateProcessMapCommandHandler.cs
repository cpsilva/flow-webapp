using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.UpdateProcessMap
{
    public class UpdateProcessMapCommandHandler
        : IRequestHandler<UpdateProcessMapCommand, Result<int>>
    {
        public Task<Result<int>> Handle(
            UpdateProcessMapCommand request,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }
    }
}

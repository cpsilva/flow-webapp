using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.GetProcessMap
{
    public class GetProcessMapQueryHandler
        : IRequestHandler<GetProcessMapQuery, Result<ProcessMapResponse>>
    {
        public Task<Result<ProcessMapResponse>> Handle(
            GetProcessMapQuery request,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }
    }
}

using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.UpdateProcessMap
{
    public class UpdateProcessMapCommand : IRequest<Result<int>>
    {
        public UpdateProcessMapCommand(UpdateProcessMapRequest request) { }
    }
}

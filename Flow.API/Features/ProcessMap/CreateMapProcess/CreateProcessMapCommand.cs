using CSharpFunctionalExtensions;
using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CreateProcessMapCommand : IRequest<Result<int>>
    {
        public CreateProcessMapCommand(CreateProcessMapRequest request) { }
    }
}

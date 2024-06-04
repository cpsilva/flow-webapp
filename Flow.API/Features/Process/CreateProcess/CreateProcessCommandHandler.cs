using MediatR;

namespace Flow.API.Features.Process.CreateProcess
{
    public class CreateProcessCommandHandler : IRequestHandler<CreateProcessCommand, int>
    {
        public Task<int> Handle(CreateProcessCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

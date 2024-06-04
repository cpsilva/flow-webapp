using MediatR;

namespace Flow.API.Features.Process.CreateProcess
{
    public class CriarProcessoCommandHandler : IRequestHandler<CriarProcessoCommand, int>
    {
        public Task<int> Handle(CriarProcessoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

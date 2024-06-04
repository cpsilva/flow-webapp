using MediatR;

namespace Flow.API.Features.Processo.CriarProcesso
{
    public class CriarProcessoCommandHandler : IRequestHandler<CriarProcessoCommand, int>
    {
        public Task<int> Handle(CriarProcessoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

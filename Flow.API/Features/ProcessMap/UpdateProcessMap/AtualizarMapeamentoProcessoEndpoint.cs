using Flow.API.Features.ProcessMap.AtualizarMapeamentoProcesso;
using MediatR;

namespace Flow.API.Features.ProcessMap.UpdateProcessMap
{
    public class AtualizarMapeamentoProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut("mapeamento-processo", async (AtualizarMapeamentoProcessoRequest request, ISender sender, CancellationToken cancellationToken) =>
            {
                var command = new AtualizarMapeamentoProcessoCommand(request);
                return Results.Ok(await sender.Send(command, cancellationToken));
            })
                .WithTags(Tags.ProcessMap);
        }
    }
}

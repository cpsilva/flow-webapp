using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CriarMapeamentoProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost("mapeamento-processo", async (CriarMapeamentoProcessoRequest request, ISender sender, CancellationToken cancellationToken) =>
            {
                var command = new CriarMapeamentoProcessoCommand(request);
                return Results.Ok(await sender.Send(command, cancellationToken));
            })
                .WithTags(Tags.ProcessMap);
        }
    }
}

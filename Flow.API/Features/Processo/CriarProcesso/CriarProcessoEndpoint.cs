using MediatR;

namespace Flow.API.Features.Processo.CriarProcesso
{
    public class CriarProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost("processo", async (CriarProcessoRequest request, ISender sender, CancellationToken cancellationToken) =>
            {
                var command = new CriarProcessoCommand();
                return Results.Ok(await sender.Send(command, cancellationToken));
            })
                .WithTags(Tags.Processo);
        }
    }
}

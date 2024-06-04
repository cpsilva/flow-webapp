
using Flow.API.Features;
using MediatR;

namespace Flow.API.Features.MapeamentoProcesso.ObterMapeamentoProcesso
{
    public class ObterMapeamentoProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("mapeamento-processo/{mapeamentoProcessoId}", async (int mapeamentoProcessoId, ISender sender, CancellationToken cancellationToken) =>
            {
                var query = new ObterMapeamentoProcessoQuery(mapeamentoProcessoId);
                return Results.Ok(await sender.Send(query, cancellationToken));
            })
                .WithTags(Tags.MapeamentoProcesso);
        }
    }
}

using Flow.API.Features.MapeamentoProcesso.ObterMapeamentoProcesso;
using Flow.API.Features.ProcessMap.ObterMapeamentoProcesso;
using MediatR;

namespace Flow.API.Features.ProcessMap.GetProcessMap
{
    public class ObterMapeamentoProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet(
                    "mapeamento-processo/{mapeamentoProcessoId}",
                    async (
                        int mapeamentoProcessoId,
                        ISender sender,
                        CancellationToken cancellationToken
                    ) =>
                    {
                        var query = new ObterMapeamentoProcessoQuery(mapeamentoProcessoId);
                        return Results.Ok(await sender.Send(query, cancellationToken));
                    }
                )
                .WithTags(Tags.ProcessMap);
        }
    }
}

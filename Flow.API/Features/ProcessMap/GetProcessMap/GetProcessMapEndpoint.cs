using MediatR;

namespace Flow.API.Features.ProcessMap.GetProcessMap
{
    public class GetProcessMapEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet(
                    "process-map/{mapeamentoProcessoId}",
                    async (
                        int mapeamentoProcessoId,
                        ISender sender,
                        CancellationToken cancellationToken
                    ) =>
                    {
                        var query = new GetProcessMapQuery(mapeamentoProcessoId);
                        return Results.Ok(await sender.Send(query, cancellationToken));
                    }
                )
                .WithTags(Tags.ProcessMap);
        }
    }
}

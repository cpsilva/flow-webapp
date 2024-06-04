using MediatR;

namespace Flow.API.Features.ProcessMap.UpdateProcessMap
{
    public class UpdateProcessMapEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut(
                    "process-map",
                    async (
                        UpdateProcessMapRequest request,
                        ISender sender,
                        CancellationToken cancellationToken
                    ) =>
                    {
                        var command = new UpdateProcessMapCommand(request);
                        return Results.Ok(await sender.Send(command, cancellationToken));
                    }
                )
                .WithTags(Tags.ProcessMap);
        }
    }
}

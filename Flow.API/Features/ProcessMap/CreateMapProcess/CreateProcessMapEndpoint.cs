using MediatR;

namespace Flow.API.Features.ProcessMap.CreateMapProcess
{
    public class CreateProcessMapEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost(
                    "process-map",
                    async (
                        CreateProcessMapRequest request,
                        ISender sender,
                        CancellationToken cancellationToken
                    ) =>
                    {
                        var command = new CreateProcessMapCommand(request);
                        return Results.Ok(await sender.Send(command, cancellationToken));
                    }
                )
                .WithTags(Tags.ProcessMap);
        }
    }
}

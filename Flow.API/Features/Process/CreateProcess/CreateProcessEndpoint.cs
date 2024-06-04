using MediatR;

namespace Flow.API.Features.Process.CreateProcess
{
    public class CreateProcessEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost(
                    "process",
                    async (
                        CreateProcessRequest request,
                        ISender sender,
                        CancellationToken cancellationToken
                    ) =>
                    {
                        var command = new CreateProcessCommand();
                        return Results.Ok(await sender.Send(command, cancellationToken));
                    }
                )
                .WithTags(Tags.Process);
        }
    }
}

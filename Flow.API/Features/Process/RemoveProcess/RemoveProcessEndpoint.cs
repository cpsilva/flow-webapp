namespace Flow.API.Features.Process.RemoveProcess
{
    public class RemoveProcessEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapDelete("process/{processId}", async () => { }).WithTags(Tags.Process);
        }
    }
}

namespace Flow.API.Features.Process.GetProcess
{
    public class GetProcessEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("process/{processId}", async () => { }).WithTags(Tags.Process);
        }
    }
}

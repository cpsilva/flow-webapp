namespace Flow.API.Features.Process.GetProcesses
{
    public class GetProcessesEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("processes", async () => { }).WithTags(Tags.Process);
        }
    }
}

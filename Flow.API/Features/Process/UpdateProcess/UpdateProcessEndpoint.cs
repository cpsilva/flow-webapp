namespace Flow.API.Features.Process.UpdateProcess
{
    public class UpdateProcessEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut("process", async (UpdateProcessRequest request) => { })
                .WithTags(Tags.Process);
        }
    }
}

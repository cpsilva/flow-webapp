namespace Flow.API.Features.Process.GetProcesses
{
    public class ObterProcessosEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("processos", async () =>
            {

            })
                .WithTags(Tags.Process);
        }
    }
}

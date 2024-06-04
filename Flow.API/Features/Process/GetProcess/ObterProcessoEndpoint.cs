namespace Flow.API.Features.Process.GetProcess
{
    public class ObterProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("processo/{processoId}", async () =>
            {

            })
                .WithTags(Tags.Process);
        }
    }
}

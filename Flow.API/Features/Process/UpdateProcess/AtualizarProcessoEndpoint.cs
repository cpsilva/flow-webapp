namespace Flow.API.Features.Process.UpdateProcess
{
    public class AtualizarProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut("processo", async (AtualizarProcessoRequest request) =>
            {

            })
                .WithTags(Tags.Process);
        }
    }
}

namespace Flow.API.Features.Processo.ObterProcesso
{
    public class ObterProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("processo/{processoId}", async () =>
            {

            })
                .WithTags(Tags.Processo);
        }
    }
}

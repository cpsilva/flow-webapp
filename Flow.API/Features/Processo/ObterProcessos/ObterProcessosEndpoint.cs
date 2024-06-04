namespace Flow.API.Features.Processo.ObterProcessos
{
    public class ObterProcessosEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("processos", async () =>
            {

            })
                .WithTags(Tags.Processo);
        }
    }
}

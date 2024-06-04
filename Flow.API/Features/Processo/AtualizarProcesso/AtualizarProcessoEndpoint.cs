namespace Flow.API.Features.Processo.AtualizarProcesso
{
    public class AtualizarProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut("processo", async (AtualizarProcessoRequest request) =>
            {

            })
                .WithTags(Tags.Processo);
        }
    }
}

namespace Flow.API.Features.Processo.RemoverProcesso
{
    public class RemoverProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapDelete("processos/{processoId}", async () =>
            {

            })
                .WithTags(Tags.Processo);
        }
    }
}

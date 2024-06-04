namespace Flow.API.Features.Process.RemoveProcess
{
    public class RemoverProcessoEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapDelete("processos/{processoId}", async () =>
            {

            })
                .WithTags(Tags.Process);
        }
    }
}

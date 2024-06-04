namespace Flow.API.Features;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}

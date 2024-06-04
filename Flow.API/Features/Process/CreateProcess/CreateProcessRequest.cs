namespace Flow.API.Features.Process.CreateProcess
{
    public class CreateProcessRequest
    {
        public int? OriginProcessId { get; init; }
        public string Name { get; init; }
    }
}

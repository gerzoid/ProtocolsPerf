using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class PerfHub : Hub
    {
        public Task<PerfPayload> EchoPayload(PerfPayload payload)
        {
            payload.Timestamp = DateTime.UtcNow;
            return Task.FromResult(payload);
        }
    }
}

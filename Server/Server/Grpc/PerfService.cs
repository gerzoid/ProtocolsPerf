using Grpc.Core;

namespace Server.Grpc
{
    public class PerfService : Perf.PerfBase
    {
        public override Task<PingReply> Ping(PingRequest request, ServerCallContext context)
        {
            var reply = new PingReply
            {
                Message = request.Message,
                Count = request.Count,
                Value = request.Value,
                IsActive = request.IsActive,
                Nested = request.Nested,
            };

            reply.Tags.AddRange(request.Tags);

            return Task.FromResult(reply);
        }
    }
}

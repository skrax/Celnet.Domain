using System.Collections.Generic;

namespace Celnet.Domain
{
    public class ReceiveContext<TRequestBody, TResponseBody>
        where TResponseBody : class
        where TRequestBody : class
    {
        public uint PeerId { get; set; }

        public uint ChannelId { get; set; }

        public Request<TRequestBody>? Request { get; set; }

        public Response<TResponseBody>? Response { get; set; }
        
        public IDictionary<string, object>? Keys { get; set; }
    }
}
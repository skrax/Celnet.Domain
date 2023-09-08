namespace Celnet.Domain
{
    public class PeerReceiveEvent
    {
        public uint PeerId { get; set; }
        
        public uint ChannelId { get; set; }
        
        public byte[] Data { get; set; }
    }
}
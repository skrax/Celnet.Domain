namespace Celnet.Domain
{
    public class PeerSendArgs
    {
        public uint PeerId { get; set; }
        
        public byte ChannelId { get; set; }
        
        public byte[]? Data { get; set; }
    }
}
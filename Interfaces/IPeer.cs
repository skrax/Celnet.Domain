using System;

namespace Celnet.Domain
{
    public interface IPeer
    {
        event Action<PeerConnectEvent> OnPeerConnected;
        event Action<PeerDisconnectEvent> OnPeerDisconnected;
        event Action<PeerTimeoutEvent> OnPeerTimeout;
        event Action<PeerReceiveEvent> OnPeerReceive;
        
        void Poll();

        bool TrySend(PeerSendArgs sendArgs);
    }
}
using System;
using Celnet.Domain.Events;

namespace Celnet.Domain.Interfaces
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
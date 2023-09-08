using System;

namespace Celnet.Domain
{
    public interface IClient : IPeer, IDisposable
    {
        bool IsConnected { get; }

        void Connect(string ip, ushort port, int channelLimit);

        void Disconnect();
    }
}
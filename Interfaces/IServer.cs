using System;

namespace Celnet.Domain
{
    public interface IServer : IPeer, IDisposable
    {
        bool IsRunning { get; }

        void Create(ushort port, int maxClients);
    }
}
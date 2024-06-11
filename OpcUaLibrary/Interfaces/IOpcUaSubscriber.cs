using System;
using Opc.UaFx.Client;

namespace OpcUaLibrary.Interfaces
{
    public interface IOpcUaSubscriber
    {
        event EventHandler<OpcDataChangeReceivedEventArgs> SubscriptionDataUpdated;
        void SubscribeNodes(int intervalInMiliseconds, bool onlyConfiguredNodes);
    }
}

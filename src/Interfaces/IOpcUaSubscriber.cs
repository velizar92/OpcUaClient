﻿using System;
using Opc.UaFx.Client;

namespace OpcUaClient.src.Interfaces
{
    public interface IOpcUaSubscriber
    {
        event EventHandler<OpcDataChangeReceivedEventArgs> SubscriptionDataUpdated;
        void SubscribeNodes(int intervalInMiliseconds, bool onlyConfiguredNodes);
    }
}

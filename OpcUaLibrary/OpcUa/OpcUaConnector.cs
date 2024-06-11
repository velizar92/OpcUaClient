using System;
using Opc.UaFx.Client;
using OpcUaLibrary.Interfaces;
using Opc.UaFx;

namespace OpcUaLibrary.OpcUa
{
    public class OpcUaConnector : IOpcUaConnector
    {
        private readonly OpcClient _opcClient;

        public bool IsClientConnected { get; private set; }

        public OpcUaConnector(OpcClient opcClient)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
        }


        public void Connect()
        {
            if (IsClientConnected == true)
            {
                throw new InvalidOperationException("The client is already connected.");
            }

            OpcAutomatism.UseDynamic = true;
            _opcClient.UseDynamic = true;

            _opcClient.Connect();
            IsClientConnected = true;
        }

        public void Disconnect()
        {
            if (IsClientConnected == false)
            {
                throw new InvalidOperationException("Client is not connected.");
            }

            _opcClient.Disconnect();
            IsClientConnected = false;
        }

    }
}

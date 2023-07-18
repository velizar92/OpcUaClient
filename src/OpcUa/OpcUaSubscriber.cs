using System;
using System.Collections.Generic;
using Opc.UaFx.Client;
using OpcUaClient.Interfaces;
using OpcUaClient.src.Interfaces;
using System.Linq;

namespace OpcUaClient.src.OpcUa
{
    public class OpcUaSubscriber : IOpcUaSubscriber
    {
        private readonly IConfiguration _configuration;
        private readonly IOpcUaBrowser _opcUaBrowser;
        private readonly OpcClient _client;
        
        public event EventHandler<OpcDataChangeReceivedEventArgs> SubscriptionDataUpdated;

        public OpcUaSubscriber(IConfiguration configuration, IOpcUaBrowser opcUaBrowser, OpcClient client)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration)); 
            _opcUaBrowser = opcUaBrowser ?? throw new ArgumentNullException(nameof(opcUaBrowser)); 
            _client = client ?? throw new ArgumentNullException(nameof(client));       
        }

        public void SubscribeNodes(int intervalInMiliseconds, bool onlyConfiguredNodes)
        {
            List<OpcSubscribeDataChange> commands = new List<OpcSubscribeDataChange>();

            OpcNodeInfo rootNode = _client.BrowseNode(_configuration.OpcUaConfiguration.RootNodeId);

            if (rootNode != null)
            {
                if (onlyConfiguredNodes == false)
                {
                    List<OpcUaNodeInfoModel> allServerNodes = _opcUaBrowser.GetBrowsedServerNodes(rootNode, false).ToList();
                    foreach (var node in allServerNodes)
                    {
                        commands.Add(new OpcSubscribeDataChange(node.NodeId, HandleDataChanged));
                    }
                }
                else
                {
                    foreach (string nodeId in _configuration.OpcUaConfiguration.OpcUaServerNodes)
                    {
                        commands.Add(new OpcSubscribeDataChange(nodeId, HandleDataChanged));
                    }
                }

                OpcSubscription subscription = _client.SubscribeNodes(commands);
                subscription.PublishingInterval = intervalInMiliseconds;
                subscription.ApplyChanges();
            }         
        }


        private void HandleDataChanged(object sender, OpcDataChangeReceivedEventArgs e)
        {
            OpcMonitoredItem monitoredItemSender = (OpcMonitoredItem)sender;

            SubscriptionDataUpdated?.Invoke(monitoredItemSender, e);
        }
    }
}

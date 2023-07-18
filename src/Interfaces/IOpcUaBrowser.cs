using System.Collections.Generic;
using Opc.UaFx.Client;

namespace OpcUaClient.src.Interfaces
{
    public interface IOpcUaBrowser
    {      
        IEnumerable<OpcUaNodeInfoModel> GetBrowsedServerNodes(OpcNodeInfo node, bool onlyConfiguredNodes);

        IEnumerable<OpcUaNodeInfoModel> BrowseDirectNodeChildren(string nodeId);
    }
}

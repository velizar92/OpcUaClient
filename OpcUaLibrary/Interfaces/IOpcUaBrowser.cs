using System.Collections.Generic;
using Opc.UaFx.Client;
using OpcUaLibrary.Models;

namespace OpcUaLibrary.Interfaces
{
    public interface IOpcUaBrowser
    {      
        IEnumerable<OpcUaNodeInfoModel> GetBrowsedServerNodes(OpcNodeInfo node, bool onlyConfiguredNodes);

        IEnumerable<OpcUaNodeInfoModel> BrowseDirectNodeChildren(string nodeId);
    }
}

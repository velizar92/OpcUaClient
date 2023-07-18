using System.Collections.Generic;

namespace OpcUaClient.src
{
    public class OpcUaNodeInfoModel
    {
        public OpcUaNodeInfoModel(string nodeId, string nodeType,
            object nodeValue)
        {
            NodeId = nodeId;
            NodeType = nodeType;
            NodeValue = nodeValue;
        }

        public string NodeId { get; private set; }

        public string NodeType { get; private set; }

        public object NodeValue { get; private set; }

    }
}

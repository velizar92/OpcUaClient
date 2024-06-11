using Opc.UaFx.Client;
using Opc.UaFx;
using System;
using OpcUaClient.src.Interfaces;
using System.Collections.Generic;

namespace OpcUaClient.src.OpcUa
{
    public class OpcUaNodeCaster : IOpcUaNodeCaster
    {
        private readonly OpcClient _opcClient;

        public OpcUaNodeCaster(OpcClient opcClient)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
        }

        public OpcDataObject TryCastNodeAsOpcDataObject(OpcNodeInfo childNode)
        {
            return TryCastNodeAsOpcComplexDataObject(childNode.NodeId.ToString());
        }


        public OpcDataObject TryCastNodeAsOpcDataObject(string nodeId)
        {
            return TryCastNodeAsOpcComplexDataObject(nodeId);
        }


        public IEnumerable<OpcDataObject> TryCastNodeAsOpcDataObjectCollection(OpcNodeInfo childNode)
        {
            return TryCastNodeAsOpcComplexDataObjectCollection(childNode.NodeId.ToString());
        }

        public IEnumerable<OpcDataObject> TryCastNodeAsOpcDataObjectCollection(string nodeId)
        {
            return TryCastNodeAsOpcComplexDataObjectCollection(nodeId);
        }


        private OpcDataObject TryCastNodeAsOpcComplexDataObject(string nodeId)
        {
            OpcDataObject opcDataObject = null;

            try
            {
                opcDataObject = _opcClient.ReadNode(nodeId).As<OpcDataObject>();
            }
            catch (InvalidCastException)
            {
                return null;
            }

            return opcDataObject;
        }


        private IEnumerable<OpcDataObject> TryCastNodeAsOpcComplexDataObjectCollection(string nodeId)
        {
            OpcDataObject[] opcDataObject = null;

            try
            {
                opcDataObject = _opcClient.ReadNode(nodeId).As<OpcDataObject[]>();
            }
            catch (InvalidCastException)
            {
                return null;
            }

            return opcDataObject;
        }
    }
}

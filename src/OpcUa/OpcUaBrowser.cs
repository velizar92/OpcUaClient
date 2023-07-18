using System.Linq;
using Opc.UaFx;
using Opc.UaFx.Client;
using OpcUaClient.Interfaces;
using OpcUaClient.src.Interfaces;
using System.Collections.Generic;
using OpcUaClient.src;
using KomaxOpcUaClient.src.Interfaces;
using System;

namespace OpcUaClient
{
    public class OpcUaBrowser : IOpcUaBrowser
    {
        private readonly IConfiguration _configuration;
        private readonly OpcClient _opcClient;
        private readonly IOpcUaNodeCaster _opcNodeCaster;
        private readonly IOpcUaEnumHandler _opcEnumHandler;

        public OpcUaBrowser(IConfiguration configuration, OpcClient opcClient,
            IOpcUaNodeCaster opcNodeCaster, IOpcUaEnumHandler opcEnumHandler)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
            _opcNodeCaster = opcNodeCaster ?? throw new ArgumentNullException(nameof(opcNodeCaster));
            _opcEnumHandler = opcEnumHandler ?? throw new ArgumentNullException(nameof(opcEnumHandler));
        }


        public IEnumerable<OpcUaNodeInfoModel> GetBrowsedServerNodes(OpcNodeInfo node, bool onlyConfiguredNodes = false)
        {
            List<OpcUaNodeInfoModel> serverNodes = new List<OpcUaNodeInfoModel>();
            TraverseNodes(node);
            return serverNodes;

            void TraverseNodes(OpcNodeInfo opcNode)
            {
                foreach (OpcNodeInfo childNode in opcNode.Children())
                {
                    if (onlyConfiguredNodes == true)
                    {
                        if (_configuration.OpcUaConfiguration.OpcUaServerNodes
                            .FirstOrDefault(n => n == childNode.NodeId) != null)
                        {
                            OpcUaNodeInfoModel opcNodeInfoModel = GetServerNodeInfoModel(childNode);
                            serverNodes.Add(opcNodeInfoModel);
                        }
                    }
                    else
                    {
                        OpcUaNodeInfoModel opcNodeInfoModel = GetServerNodeInfoModel(childNode);
                        serverNodes.Add(opcNodeInfoModel);
                    }

                    TraverseNodes(childNode);
                }
            }
        }


        public IEnumerable<OpcUaNodeInfoModel> BrowseDirectNodeChildren(string nodeId)
        {
            List<OpcUaNodeInfoModel> childNodes = new List<OpcUaNodeInfoModel>();
            OpcUaNodeInfoModel nodeInfoModel = null;

            OpcNodeInfo opcNode = _opcClient.BrowseNode(nodeId);

            foreach (OpcNodeInfo childNode in opcNode.Children())
            {
                OpcValue opcValue = _opcClient.ReadNode(childNode.NodeId);

                OpcDataObject opcDataObj = _opcNodeCaster.TryCastNodeAsOpcDataObject(childNode);
                IEnumerable<OpcDataObject> opcDataObjArray = _opcNodeCaster.TryCastNodeAsOpcDataObjectCollection(childNode);

                if (opcDataObj != null)
                {
                    nodeInfoModel =
                       GetNodeInfoModel(opcDataObj.GetFields(), childNode.NodeId.ToString(), opcValue.DataType.ToString());
                }
                else if (opcDataObjArray != null)
                {
                    nodeInfoModel =
                       GetNodeInfoModel(opcDataObjArray, childNode.NodeId.ToString(), opcValue.DataType.ToString());
                }
                else
                {
                    nodeInfoModel =
                        GetNodeInfoModel(childNode, opcValue);
                }

                childNodes.Add(nodeInfoModel);
            }

            return childNodes;
        }


        private OpcUaNodeInfoModel GetServerNodeInfoModel(OpcNodeInfo childNode)
        {
            string nodeId = childNode.AttributeValue(OpcAttribute.NodeId) == null ?
                string.Empty : childNode.AttributeValue(OpcAttribute.NodeId).ToString();

            string nodeType = _opcClient.ReadNode(childNode.NodeId).DataType.ToString();

            OpcDataObject opcDataObj = _opcNodeCaster.TryCastNodeAsOpcDataObject(childNode);
            IEnumerable<OpcDataObject> opcDataObjArray = _opcNodeCaster.TryCastNodeAsOpcDataObjectCollection(childNode);

            if (opcDataObj != null)
            {
                return GetNodeInfoModel(opcDataObj.GetFields(), nodeId, nodeType);
            }
            else if (opcDataObjArray != null)
            {
                return GetNodeInfoModel(opcDataObjArray, nodeId, nodeType);
            }

            string nodeValue = childNode.AttributeValue(OpcAttribute.Value) == null ? string.Empty
                : childNode.AttributeValue(OpcAttribute.Value).ToString();

            return new OpcUaNodeInfoModel(nodeId, nodeType, nodeValue);
        }


        private OpcUaNodeInfoModel GetNodeInfoModel(OpcNodeInfo childNode, OpcValue opcValue)
        {
            OpcVariableNodeInfo variableNodeInfo = _opcClient.BrowseNode(childNode.NodeId) as OpcVariableNodeInfo;

            if (variableNodeInfo != null)
            {
                OpcEnumMember[] statusValues = variableNodeInfo.DataType.GetEnumMembers();

                if (statusValues.Length > 0)
                {
                    IEnumerable<OpcEnumMember> enumMembers =
                        _opcEnumHandler.GetActiveEnumMembers(childNode.NodeId.ToString(), statusValues);

                    return
                         new OpcUaNodeInfoModel(childNode.NodeId.ToString(), opcValue.DataType.ToString(),
                                                string.Join("", enumMembers.Select(x => $"{x.Value} ({x.Name})")));
                }           
            }

            string nodeValue = childNode.AttributeValue(OpcAttribute.Value) == null ? string.Empty
              : childNode.AttributeValue(OpcAttribute.Value).ToString();

            return
                new OpcUaNodeInfoModel(childNode.NodeId.ToString(), opcValue.DataType.ToString(), nodeValue);
        }


        private OpcUaNodeInfoModel GetNodeInfoModel(IEnumerable<OpcDataField> fields, string nodeId, string nodeType)
        {
            string objectValue = string.Join("", fields.Select(x => x.Name + " -> " + x.Value + Environment.NewLine));

            return new OpcUaNodeInfoModel(nodeId, nodeType, objectValue);
        }


        private OpcUaNodeInfoModel GetNodeInfoModel(IEnumerable<OpcDataObject> opcDataObjArray, string nodeId, string nodeType)
        {
            string objectValue = "";

            foreach (OpcDataObject opcDataObject in opcDataObjArray)
            {
                OpcDataField[] fields = opcDataObject.GetFields();

                objectValue += Environment.NewLine +
                           string.Join("", fields.Select(x => x.Name + " -> " + x.Value + Environment.NewLine));
            }

            return new OpcUaNodeInfoModel(nodeId, nodeType, objectValue);

        }
    }
}

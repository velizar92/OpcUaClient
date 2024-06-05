using Opc.UaFx.Client;
using Opc.UaFx;
using OpcUaClient.src.Interfaces;
using System.Collections.Generic;
using System;

namespace OpcUaClient.src.OpcUa
{
    public class OpcUaEnumHandler : IOpcUaEnumHandler
    {
        private readonly OpcClient _opcClient;

        public OpcUaEnumHandler(OpcClient opcClient)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
        }

        public OpcEnumMember GetActiveEnumMember(OpcVariableNodeInfo opcVaribaleNodeInfo, IEnumerable<OpcEnumMember> opcEnumMembers)
        {
            return GetEnumerationMember(opcVaribaleNodeInfo.NodeId.ToString(), opcEnumMembers);
        }

        public OpcEnumMember GetActiveEnumMember(string nodeId, IEnumerable<OpcEnumMember> opcEnumMembers)
        {
            return GetEnumerationMember(nodeId, opcEnumMembers);
        }

        public IEnumerable<OpcEnumMember> GetActiveEnumMembers(string nodeId, IEnumerable<OpcEnumMember> opcEnumMembers)
        {
            OpcValue nodeValue = _opcClient.ReadNode(nodeId);
            List<OpcEnumMember> enumMembers = new List<OpcEnumMember>();

            foreach (OpcEnumMember enumMem in opcEnumMembers)
            {
                if (enumMem.Value == nodeValue.As<int>())
                {
                    enumMembers.Add(enumMem);
                }
            }

            return enumMembers;
        }


        private OpcEnumMember GetEnumerationMember(string nodeId, IEnumerable<OpcEnumMember> opcEnumMembers)
        {
            OpcValue nodeValue = _opcClient.ReadNode(nodeId);
            OpcEnumMember enumMember = null;

            foreach (OpcEnumMember enumMem in opcEnumMembers)
            {
                if (enumMem.Value == nodeValue.As<int>())
                {
                    enumMember = enumMem;
                    break;
                }
            }

            return enumMember;
        }
    }
}

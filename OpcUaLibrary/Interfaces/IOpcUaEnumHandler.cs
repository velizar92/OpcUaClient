using Opc.UaFx.Client;
using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaLibrary.Interfaces
{
    public interface IOpcUaEnumHandler
    {
        OpcEnumMember GetActiveEnumMember(OpcVariableNodeInfo opcVaribaleNodeInfo, IEnumerable<OpcEnumMember> opcEnumMembers);
        OpcEnumMember GetActiveEnumMember(string nodeId, IEnumerable<OpcEnumMember> opcEnumMembers);
        IEnumerable<OpcEnumMember> GetActiveEnumMembers(string nodeId, IEnumerable<OpcEnumMember> opcEnumMembers);
    }
}

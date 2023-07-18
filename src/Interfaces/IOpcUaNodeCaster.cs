using Opc.UaFx.Client;
using Opc.UaFx;
using System.Collections.Generic;

namespace KomaxOpcUaClient.src.Interfaces
{
    public interface IOpcUaNodeCaster
    {
        OpcDataObject TryCastNodeAsOpcDataObject(OpcNodeInfo childNode);

        OpcDataObject TryCastNodeAsOpcDataObject(string nodeId);

        IEnumerable<OpcDataObject> TryCastNodeAsOpcDataObjectCollection(OpcNodeInfo childNode);

        IEnumerable<OpcDataObject> TryCastNodeAsOpcDataObjectCollection(string nodeId);
    }
}

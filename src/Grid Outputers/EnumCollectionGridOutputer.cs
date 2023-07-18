using KomaxOpcUaClient.src.Interfaces;
using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KomaxOpcUaClient
{
    public class EnumCollectionGridOutputer : IOpcUaNodeValueGridOutputer
    {

        private readonly OpcClient _opcClient;
        private readonly IOpcUaEnumHandler _opcUaEnumHandler;
        private readonly int _nodeValueColumnIndex;
        private readonly int _nodeDataTypeColumnIndex;


        public EnumCollectionGridOutputer(OpcClient opcClient, IOpcUaEnumHandler enumHandler,
            int nodeValueColumnIndex, int nodeDataTypeColumnIndex)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
            _opcUaEnumHandler = enumHandler ?? throw new ArgumentNullException(nameof(enumHandler));

            if (nodeValueColumnIndex < 0 || nodeValueColumnIndex > int.MaxValue)
            {
                throw new ArgumentException(nameof(nodeValueColumnIndex));
            }

            if (nodeDataTypeColumnIndex < 0 || nodeDataTypeColumnIndex > int.MaxValue)
            {
                throw new ArgumentException(nameof(nodeDataTypeColumnIndex));
            }

            _nodeValueColumnIndex = nodeValueColumnIndex;
            _nodeDataTypeColumnIndex = nodeDataTypeColumnIndex;
        }


        public void OutputNodeValueInDataGrid(OpcMonitoredItem item, OpcDataChangeReceivedEventArgs e, DataGridViewRow row)
        {
            if (e.Item.Value.DataType.ToString() == "Null")
            {
                OpcVariableNodeInfo variableNodeInfo = _opcClient.BrowseNode(item.NodeId) as OpcVariableNodeInfo;

                if (variableNodeInfo != null)
                {
                    OpcEnumMember[] statusValues = variableNodeInfo.DataType.GetEnumMembers();

                    if (statusValues.Length > 0)
                    {
                        OpcEnumMember[] enumMembers =
                            _opcUaEnumHandler.GetActiveEnumMembers(variableNodeInfo.NodeId.ToString(), statusValues).ToArray();

                        row.Cells[_nodeValueColumnIndex].Value = string.Join(", ", enumMembers
                            .Select(x => x.Value.ToString() + " " + $"({x.Name})"));

                        row.Cells[_nodeDataTypeColumnIndex].Value = e.Item.Value.DataType;
                    }
                }
            }
        }
    }
}

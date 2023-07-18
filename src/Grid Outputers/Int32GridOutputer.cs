using KomaxOpcUaClient.src.Interfaces;
using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Windows.Forms;

namespace KomaxOpcUaClient.src
{
    public class Int32GridOutputer : IOpcUaNodeValueGridOutputer
    {
        private readonly OpcClient _opcClient;
        private readonly IOpcUaEnumHandler _opcUaEnumHandler;
        private readonly int _nodeValueColumnIndex;
        private readonly int _nodeDataTypeColumnIndex;


        public Int32GridOutputer(OpcClient opcClient, IOpcUaEnumHandler enumHandler,
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
            if (e.Item.Value.DataType.ToString() == "Int32")
            {
                OpcVariableNodeInfo variableNodeInfo = _opcClient.BrowseNode(item.NodeId) as OpcVariableNodeInfo;

                if (variableNodeInfo != null)
                {
                    OpcEnumMember[] statusValues = variableNodeInfo.DataType.GetEnumMembers();

                    if (statusValues.Length > 0)
                    {
                        OpcEnumMember enumMember =
                            _opcUaEnumHandler.GetActiveEnumMember(variableNodeInfo, statusValues);

                        row.Cells[_nodeValueColumnIndex].Value = enumMember.Value.ToString() + " " + $"({enumMember.Name})";
                        row.Cells[_nodeDataTypeColumnIndex].Value = e.Item.Value.DataType;
                    }
                    else
                    {
                        row.Cells[_nodeValueColumnIndex].Value = e.Item.Value.ToString();
                        row.Cells[_nodeDataTypeColumnIndex].Value = e.Item.Value.DataType;
                    }
                }
            }
        }
    }
}

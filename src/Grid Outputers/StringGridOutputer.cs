using KomaxOpcUaClient.src.Interfaces;
using Opc.UaFx.Client;
using System;
using System.Windows.Forms;

namespace KomaxOpcUaClient.src
{
    public class StringGridOutputer : IOpcUaNodeValueGridOutputer
    {
        private readonly int _nodeValueColumnIndex;
        private readonly int _nodeDataTypeColumnIndex;

        public StringGridOutputer(int nodeValueColumnIndex, int nodeDataTypeColumnIndex)
        {

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
            if (e.Item.Value.DataType.ToString() != "Null"
                && e.Item.Value.DataType.ToString() != "Int32" && e.Item.Value.DataType.ToString() != "ExtensionObject")
            {
                row.Cells[_nodeValueColumnIndex].Value = e.Item.Value.ToString();
                row.Cells[_nodeDataTypeColumnIndex].Value = e.Item.Value.DataType;
            }
        }
    }
}

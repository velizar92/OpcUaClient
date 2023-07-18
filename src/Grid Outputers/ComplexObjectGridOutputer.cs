using KomaxOpcUaClient.src.Interfaces;
using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KomaxOpcUaClient.src
{
    public class ComplexObjectGridOutputer : IOpcUaNodeValueGridOutputer
    {
        private readonly OpcClient _opcClient;
        private readonly IOpcUaNodeCaster _opcUaNodeCaster;
        private readonly int _nodeValueColumnIndex;

        public ComplexObjectGridOutputer(OpcClient opcClient, IOpcUaNodeCaster opcUaNodeCaster, int nodeValueColumnIndex)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
            _opcUaNodeCaster = opcUaNodeCaster ?? throw new ArgumentNullException(nameof(opcUaNodeCaster));

            if (nodeValueColumnIndex < 0 || nodeValueColumnIndex > int.MaxValue)
            {
                throw new ArgumentException(nameof(nodeValueColumnIndex));
            }

            _nodeValueColumnIndex = nodeValueColumnIndex;   
        }

        public void OutputNodeValueInDataGrid(OpcMonitoredItem item, OpcDataChangeReceivedEventArgs e, DataGridViewRow row)
        {
            row.Cells[_nodeValueColumnIndex].Value = string.Empty;

            if (e.Item.Value.DataType.ToString() == "ExtensionObject")
            {
                OpcDataObject opcDataObject = _opcUaNodeCaster.TryCastNodeAsOpcDataObject(item.NodeId.ToString());

                if (opcDataObject != null)
                {
                    OpcDataField[] fields = opcDataObject.GetFields();

                    row.Cells[_nodeValueColumnIndex].Value =
                        string.Join("", fields.Select(x => x.Name + " -> " + x.Value + Environment.NewLine));
                }
                else
                {
                    OpcDataObject[] opcDataObjectArray = _opcClient.ReadNode(item.NodeId.ToString()).As<OpcDataObject[]>();
                    
                    if (opcDataObjectArray.Length > 0)
                    {
                        foreach (var opcDataObj in opcDataObjectArray)
                        {
                            OpcDataField[] fields = opcDataObj.GetFields();

                            row.Cells[_nodeValueColumnIndex].Value += Environment.NewLine +
                           string.Join("", fields.Select(x => x.Name + " -> " + x.Value + Environment.NewLine));
                        }
                    }
                }
            }
        }


    }
}

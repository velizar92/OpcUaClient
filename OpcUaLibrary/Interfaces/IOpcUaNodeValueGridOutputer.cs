﻿using Opc.UaFx.Client;
using System.Windows.Forms;

namespace OpcUaLibrary.Interfaces
{
    public interface IOpcUaNodeValueGridOutputer
    {
        void OutputNodeValueInDataGrid(OpcMonitoredItem item, OpcDataChangeReceivedEventArgs e, DataGridViewRow row);
    }
}

using KomaxOpcUaClient.src.Interfaces;
using OpcUaClient.src;
using OpcUaClient;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using OpcUaClient.src.Interfaces;
using Opc.UaFx;
using OpcUaClient.Interfaces;
using System.Linq;

namespace KomaxOpcUaClient.src.UI
{
    public partial class Board : Form
    {
        private OpcClient _opcClient;
        private IOpcUaConnector _opcUaConnector;
        private IOpcUaBrowser _opcUaBrowser;
        private IOpcUaSubscriber _opcUaSubscriber;
        private IConfiguration _configuration;
        private IOpcUaNodeCaster _opcUaNodeCaster;
        private IOpcUaEnumHandler _opcUaEnumHandler;

        private IOpcUaNodeValueGridOutputer _complexObjGridOutputer;
        private IOpcUaNodeValueGridOutputer _int32GridOutputer;
        private IOpcUaNodeValueGridOutputer _enumCollectionGridOutputer;
        private IOpcUaNodeValueGridOutputer _stringGridOutputer;

        private const int nodeIdColumnIndex = 0;
        private const int nodeDataTypeColumnIndex = 1;
        private const int nodeValueColumnIndex = 2;

        private List<IOpcUaNodeValueGridOutputer> _gridOutputers;

        public Board()
        {
            InitializeComponent();
        }


        private void Board_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeObjects();

                _gridOutputers = new List<IOpcUaNodeValueGridOutputer>()
                {
                    _complexObjGridOutputer, _int32GridOutputer, _enumCollectionGridOutputer, _stringGridOutputer
                };

                serverNodesGridView.AllowUserToAddRows = false;
                rbConfiguredData.Checked = true;
                rbSelectedData.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _opcUaConnector.Connect();
                _opcUaSubscriber.SubscribeNodes(1000, true);
                var node = _opcClient.BrowseNode(_configuration.OpcUaConfiguration.RootNodeId);

                PopulateTreeView(node, null, serverNodesTreeView);

                var serverNodes = _opcUaBrowser.GetBrowsedServerNodes(node, true);

                DisplayServerNodesInGrid(serverNodes, serverNodesGridView);

                lblSystemStatus.Visible = true;
                OutputEngine.SetStatusMessage("You are connected.", lblSystemStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _opcUaConnector.Disconnect();
                serverNodesTreeView.Nodes.Clear();
                serverNodesGridView.Rows.Clear();

                lblSystemStatus.Visible = true;
                OutputEngine.SetStatusMessage("You are disconnected.", lblSystemStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, "configuration.json");

                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_opcUaConnector.IsClientConnected == false)
            {
                MessageBox.Show("The client is not connected to any server.");
                return;
            }

            try
            {
                _configuration = ConfigurationManager.LoadConfiguration();
                _opcUaBrowser = Factory.CreateOpcUaBrowser(_configuration, _opcClient, _opcUaNodeCaster, _opcUaEnumHandler);

                var node = _opcClient.BrowseNode(_configuration.OpcUaConfiguration.RootNodeId);

                serverNodesGridView.Rows.Clear();
                IEnumerable<OpcUaNodeInfoModel> serverNodes = _opcUaBrowser.GetBrowsedServerNodes(node, true);

                DisplayServerNodesInGrid(serverNodes, serverNodesGridView);

                _opcUaSubscriber.SubscribeNodes(1000, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void DisplayServerNodesInGrid(IEnumerable<OpcUaNodeInfoModel> serverNodes, DataGridView datagridView)
        {
            foreach (var serverNode in serverNodes)
            {
                datagridView.Rows.Add(serverNode.NodeId, serverNode.NodeType, serverNode.NodeValue);
            }
        }


        private void PopulateTreeView(OpcNodeInfo node, TreeNode parentNode, TreeView treeView)
        {
            TreeNode childTreeNode;

            foreach (var childNode in node.Children())
            {
                childTreeNode = new TreeNode()
                {
                    Text = childNode.AttributeValue(OpcAttribute.NodeId) == null ?
                    string.Empty : childNode.AttributeValue(OpcAttribute.NodeId).ToString(),

                    ImageIndex = 3
                };

                if (parentNode == null)
                {
                    treeView.Nodes.Add(childTreeNode);
                }
                else
                {
                    parentNode.Nodes.Add(childTreeNode);
                }

                PopulateTreeView(childNode, childTreeNode, treeView);
            }
        }


        private void InitializeObjects()
        {
            _configuration = ConfigurationManager.LoadConfiguration();
            txtServerAddress.Text = _configuration.OpcUaConfiguration.ServerPath;
            _opcClient = new OpcClient(txtServerAddress.Text);

            _opcUaConnector = Factory.CreateOpcUaConnector(_opcClient);
            _opcUaNodeCaster = Factory.CreateOpcUaNodeCaster(_opcClient);
            _opcUaEnumHandler = Factory.CreateOpcUaEnumHandler(_opcClient);
            _opcUaBrowser = Factory.CreateOpcUaBrowser(_configuration, _opcClient, _opcUaNodeCaster, _opcUaEnumHandler);
            _opcUaSubscriber = Factory.CreateOpcUaSubscriber(_configuration, _opcUaBrowser, _opcClient);

            _complexObjGridOutputer = Factory.CreateOpcUaComplexObjectGridOutputer(_opcClient, _opcUaNodeCaster, nodeValueColumnIndex);

            _int32GridOutputer = Factory.CreateOpcUaInt32GridOutputer(_opcClient, _opcUaEnumHandler,
            nodeValueColumnIndex, nodeDataTypeColumnIndex);

            _enumCollectionGridOutputer = Factory.CreateOpcUaEnumCollectionGridOutputer(_opcClient, _opcUaEnumHandler,
                nodeValueColumnIndex, nodeDataTypeColumnIndex);

            _stringGridOutputer = Factory.CreateOpcUaStringGridOutputer(nodeValueColumnIndex, nodeDataTypeColumnIndex);

            _opcUaSubscriber.SubscriptionDataUpdated += OnOpcUaSubscriptionDataUpdated;
        }


        private void OnOpcUaSubscriptionDataUpdated(object sender, OpcDataChangeReceivedEventArgs e)
        {
            OpcMonitoredItem item = (OpcMonitoredItem)sender;

            foreach (DataGridViewRow row in serverNodesGridView.Rows)
            {
                if (row.Cells[nodeIdColumnIndex].Value != null &&
                    row.Cells[nodeIdColumnIndex].Value.ToString().Equals(item.NodeId.OriginalString))
                {
                    foreach (var gridOutputer in _gridOutputers)
                    {
                        gridOutputer.OutputNodeValueInDataGrid(item, e, row);
                    }
                }
            }
        }

        private void serverNodesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string valueText = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value == null ? string.Empty
                    : senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();

                NodeValueDetails nodeValueDetails = new NodeValueDetails(valueText);

                nodeValueDetails.ShowDialog();
            }
        }


        private void serverNodesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeId = e.Node.Text;

            rbSelectedData.Checked = true;
            
            List<OpcUaNodeInfoModel> children = _opcUaBrowser.BrowseDirectNodeChildren(nodeId).ToList();

            serverNodesGridView.Rows.Clear();

            foreach (var childNode in children)
            {
                serverNodesGridView.Rows.Add(childNode.NodeId, childNode.NodeType, childNode.NodeValue);
            }

            SetOpcUaNodeChildrenInDatagrid(nodeId);
        }


        private void rbSelectedData_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedData.Checked && _opcUaConnector.IsClientConnected == true)
            {
                if (serverNodesTreeView.CanFocus)
                {
                    serverNodesTreeView.Focus();
                }

                serverNodesGridView.Rows.Clear();
            
                if (serverNodesTreeView.SelectedNode != null)
                {
                    string nodeId = serverNodesTreeView.SelectedNode.Text;
                    SetOpcUaNodeChildrenInDatagrid(nodeId);
                }
            }
        }

        private void rbConfiguredData_CheckedChanged(object sender, EventArgs e)
        {          
            if (rbConfiguredData.Checked && _opcUaConnector.IsClientConnected == true)
            {
                try
                {
                    _configuration = ConfigurationManager.LoadConfiguration();
                    _opcUaBrowser = Factory.CreateOpcUaBrowser(_configuration, _opcClient, _opcUaNodeCaster, _opcUaEnumHandler);

                    var node = _opcClient.BrowseNode(_configuration.OpcUaConfiguration.RootNodeId);

                    serverNodesGridView.Rows.Clear();
                    IEnumerable<OpcUaNodeInfoModel> serverNodes = _opcUaBrowser.GetBrowsedServerNodes(node, true);

                    DisplayServerNodesInGrid(serverNodes, serverNodesGridView);

                    _opcUaSubscriber.SubscribeNodes(1000, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        private void SetOpcUaNodeChildrenInDatagrid(string nodeId)
        {
            List<OpcUaNodeInfoModel> children = _opcUaBrowser.BrowseDirectNodeChildren(nodeId).ToList();

            serverNodesGridView.Rows.Clear();

            foreach (var childNode in children)
            {
                serverNodesGridView.Rows.Add(childNode.NodeId, childNode.NodeType, childNode.NodeValue);
            }
        }
    }
}

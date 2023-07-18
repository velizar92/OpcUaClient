namespace KomaxOpcUaClient.src.UI
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.serverNodesGridView = new System.Windows.Forms.DataGridView();
            this.NodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.serverNodesTreeView = new System.Windows.Forms.TreeView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.rbSelectedData = new System.Windows.Forms.RadioButton();
            this.rbConfiguredData = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.serverNodesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // serverNodesGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.serverNodesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serverNodesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNodesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serverNodesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serverNodesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serverNodesGridView.ColumnHeadersHeight = 29;
            this.serverNodesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NodeId,
            this.DataType,
            this.NodeValue,
            this.Details});
            this.serverNodesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serverNodesGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.serverNodesGridView.EnableHeadersVisualStyles = false;
            this.serverNodesGridView.Location = new System.Drawing.Point(320, 131);
            this.serverNodesGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverNodesGridView.Name = "serverNodesGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serverNodesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.serverNodesGridView.RowHeadersVisible = false;
            this.serverNodesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.serverNodesGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.serverNodesGridView.RowTemplate.Height = 24;
            this.serverNodesGridView.Size = new System.Drawing.Size(789, 552);
            this.serverNodesGridView.TabIndex = 0;
            this.serverNodesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serverNodesGridView_CellContentClick);
            // 
            // NodeId
            // 
            this.NodeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.NodeId.DefaultCellStyle = dataGridViewCellStyle3;
            this.NodeId.HeaderText = "Node Id";
            this.NodeId.MinimumWidth = 6;
            this.NodeId.Name = "NodeId";
            this.NodeId.Width = 91;
            // 
            // DataType
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataType.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataType.HeaderText = "Data Type";
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NodeValue
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodeValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.NodeValue.HeaderText = "Node Value";
            this.NodeValue.MinimumWidth = 6;
            this.NodeValue.Name = "NodeValue";
            // 
            // Details
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Details.DefaultCellStyle = dataGridViewCellStyle6;
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // serverNodesTreeView
            // 
            this.serverNodesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serverNodesTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.serverNodesTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverNodesTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNodesTreeView.ForeColor = System.Drawing.Color.White;
            this.serverNodesTreeView.HideSelection = false;
            this.serverNodesTreeView.Location = new System.Drawing.Point(12, 131);
            this.serverNodesTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverNodesTreeView.Name = "serverNodesTreeView";
            this.serverNodesTreeView.Size = new System.Drawing.Size(307, 553);
            this.serverNodesTreeView.TabIndex = 1;
            this.serverNodesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.serverNodesTreeView_NodeMouseClick);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(980, 76);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 37);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(846, 76);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(129, 37);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btnConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.Location = new System.Drawing.Point(846, 696);
            this.btnConfiguration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(129, 37);
            this.btnConfiguration.TabIndex = 5;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(980, 696);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 37);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemStatus.ForeColor = System.Drawing.Color.White;
            this.lblSystemStatus.Location = new System.Drawing.Point(9, 719);
            this.lblSystemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(46, 17);
            this.lblSystemStatus.TabIndex = 7;
            this.lblSystemStatus.Text = "label1";
            this.lblSystemStatus.Visible = false;
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAddress.ForeColor = System.Drawing.Color.White;
            this.lblServerAddress.Location = new System.Drawing.Point(9, 50);
            this.lblServerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(118, 20);
            this.lblServerAddress.TabIndex = 9;
            this.lblServerAddress.Text = "Server Address";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.BackgroundImage")));
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPictureBox.Location = new System.Drawing.Point(949, 11);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(160, 59);
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.txtServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerAddress.ForeColor = System.Drawing.Color.White;
            this.txtServerAddress.Location = new System.Drawing.Point(13, 76);
            this.txtServerAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServerAddress.Multiline = true;
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(830, 37);
            this.txtServerAddress.TabIndex = 12;
            // 
            // rbSelectedData
            // 
            this.rbSelectedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSelectedData.AutoSize = true;
            this.rbSelectedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelectedData.ForeColor = System.Drawing.Color.White;
            this.rbSelectedData.Location = new System.Drawing.Point(505, 696);
            this.rbSelectedData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSelectedData.Name = "rbSelectedData";
            this.rbSelectedData.Size = new System.Drawing.Size(167, 24);
            this.rbSelectedData.TabIndex = 13;
            this.rbSelectedData.Text = "Show selected data";
            this.rbSelectedData.UseVisualStyleBackColor = true;
            this.rbSelectedData.CheckedChanged += new System.EventHandler(this.rbSelectedData_CheckedChanged);
            // 
            // rbConfiguredData
            // 
            this.rbConfiguredData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbConfiguredData.AutoSize = true;
            this.rbConfiguredData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConfiguredData.ForeColor = System.Drawing.Color.White;
            this.rbConfiguredData.Location = new System.Drawing.Point(320, 696);
            this.rbConfiguredData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbConfiguredData.Name = "rbConfiguredData";
            this.rbConfiguredData.Size = new System.Drawing.Size(182, 24);
            this.rbConfiguredData.TabIndex = 14;
            this.rbConfiguredData.Text = "Show configured data";
            this.rbConfiguredData.UseVisualStyleBackColor = true;
            this.rbConfiguredData.CheckedChanged += new System.EventHandler(this.rbConfiguredData_CheckedChanged);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1118, 748);
            this.Controls.Add(this.rbConfiguredData);
            this.Controls.Add(this.rbSelectedData);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.lblSystemStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.serverNodesTreeView);
            this.Controls.Add(this.serverNodesGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Board";
            this.Text = "OPC UA Client";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverNodesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView serverNodesGridView;
        private System.Windows.Forms.TreeView serverNodesTreeView;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.RadioButton rbSelectedData;
        private System.Windows.Forms.RadioButton rbConfiguredData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeValue;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}
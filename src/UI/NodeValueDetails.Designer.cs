namespace KomaxOpcUaClient.src.UI
{
    partial class NodeValueDetails
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
            this.rtxtBoxNodeValueDetails = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtBoxNodeValueDetails
            // 
            this.rtxtBoxNodeValueDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.rtxtBoxNodeValueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBoxNodeValueDetails.ForeColor = System.Drawing.Color.White;
            this.rtxtBoxNodeValueDetails.Location = new System.Drawing.Point(32, 98);
            this.rtxtBoxNodeValueDetails.Name = "rtxtBoxNodeValueDetails";
            this.rtxtBoxNodeValueDetails.Size = new System.Drawing.Size(415, 717);
            this.rtxtBoxNodeValueDetails.TabIndex = 0;
            this.rtxtBoxNodeValueDetails.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Node Value Information";
            // 
            // NodeValueDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(479, 872);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtBoxNodeValueDetails);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 919);
            this.Name = "NodeValueDetails";
            this.Text = "NodeValueDetails";
            this.Load += new System.EventHandler(this.NodeValueDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBoxNodeValueDetails;
        private System.Windows.Forms.Label label1;
    }
}
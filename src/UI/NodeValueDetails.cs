using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpcUaClient.src.UI
{
    public partial class NodeValueDetails : Form
    {
        private string _valueText;
        public NodeValueDetails(string valueText)
        {
            InitializeComponent();
            _valueText = valueText;

            rtxtBoxNodeValueDetails.MinimumSize = new Size(250, 25);
          
            rtxtBoxNodeValueDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            rtxtBoxNodeValueDetails.ContentsResized += rtbComment_ContentResized;


        }

        private void rtbComment_ContentResized(object sender, ContentsResizedEventArgs e)
        {
            rtxtBoxNodeValueDetails.Size = e.NewRectangle.Size;

        }

        private void NodeValueDetails_Load(object sender, EventArgs e)
        {
           rtxtBoxNodeValueDetails.Text = _valueText;
        }
    }
}

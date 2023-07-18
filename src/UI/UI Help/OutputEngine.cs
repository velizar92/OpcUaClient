using System.Windows.Forms;

namespace OpcUaClient.src
{
    public class OutputEngine
    {
        public static void SetStatusMessage(string message, Label lblMessage)
        {
            lblMessage.Visible = true;
            lblMessage.Text = message;
        }
    }
}

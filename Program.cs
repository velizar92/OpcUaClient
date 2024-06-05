using OpcUaClient.src.UI;
using OpcUaClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpcUaClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "OpcUaClient";
            bool createdNew;

            Opc.UaFx.Licenser.LicenseKey = LicenseClass.s_licenseKey;

            var mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Board());
        }
    }
}

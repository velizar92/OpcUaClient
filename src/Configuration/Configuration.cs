using OpcUaClient.Interfaces;

namespace OpcUaClient
{
    public class Configuration : IConfiguration
    {
        public OpcUaConfiguration OpcUaConfiguration { get; set; }
    }
}

using OpcUaLibrary.Interfaces;

namespace OpcUaLibrary.Configuration
{
    public class Configuration : IConfiguration
    {
        public OpcUaConfiguration OpcUaConfiguration { get; set; }
    }
}

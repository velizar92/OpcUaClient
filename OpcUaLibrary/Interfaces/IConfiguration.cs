using OpcUaLibrary.Configuration;

namespace OpcUaLibrary.Interfaces
{
    public interface IConfiguration
    {
        OpcUaConfiguration OpcUaConfiguration { get; set; }
    }
}

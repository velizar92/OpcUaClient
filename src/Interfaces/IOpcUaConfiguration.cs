namespace KomaxOpcUaClient.src.Interfaces
{
    public interface IOpcUaConfiguration
    {
        string ServerPath { get; set; }
        string RootNodeId { get; set; }
        string[] OpcUaServerNodes { get; set; }
    }
}

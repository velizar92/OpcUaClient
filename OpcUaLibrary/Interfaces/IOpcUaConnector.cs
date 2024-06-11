namespace OpcUaLibrary.Interfaces
{
    public interface IOpcUaConnector
    {
        bool IsClientConnected { get; }
        void Connect();
        void Disconnect();
    }
}

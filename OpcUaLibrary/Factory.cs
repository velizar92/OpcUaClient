using Opc.UaFx.Client;
using OpcUaLibrary.Interfaces;
using OpcUaLibrary.OpcUa;
using OpcUaLibrary;

namespace OpcUaLibrary
{
    public class Factory
    {
        public static IOpcUaBrowser CreateOpcUaBrowser(IConfiguration configuration, OpcClient opcClient,
            IOpcUaNodeCaster opcNodeCaster, IOpcUaEnumHandler enumHandler)
        {
            return new OpcUaBrowser(configuration, opcClient, opcNodeCaster, enumHandler);
        }

        public static IOpcUaConnector CreateOpcUaConnector(OpcClient opcClient)
        {
            return new OpcUaConnector(opcClient);
        }

        public static IOpcUaSubscriber CreateOpcUaSubscriber(IConfiguration configuration, IOpcUaBrowser opcUaBrowser,
            OpcClient opcClient)
        {
            return new OpcUaSubscriber(configuration, opcUaBrowser, opcClient);
        }

     
        public static IOpcUaNodeCaster CreateOpcUaNodeCaster(OpcClient opcClient)
        {
            return new OpcNodeCaster(opcClient);
        }

        public static IOpcUaEnumHandler CreateOpcUaEnumHandler(OpcClient opcClient)
        {
            return new OpcUaEnumHandler(opcClient);
        }

        public static IOpcUaNodeValueGridOutputer CreateOpcUaComplexObjectGridOutputer(OpcClient opcClient, IOpcUaNodeCaster opcNodeCaster, int nodeValueColumnIndex)
        {
            return new ComplexObjectGridOutputer(opcClient, opcNodeCaster, nodeValueColumnIndex);
        }

        public static IOpcUaNodeValueGridOutputer CreateOpcUaInt32GridOutputer(OpcClient opcClient, IOpcUaEnumHandler enumHandler,
            int nodeValueColumnIndex, int nodeDataTypeColumnIndex)
        {
            return new Int32GridOutputer(opcClient, enumHandler, nodeValueColumnIndex, nodeDataTypeColumnIndex);
        }

        public static IOpcUaNodeValueGridOutputer CreateOpcUaEnumCollectionGridOutputer(OpcClient opcClient, IOpcUaEnumHandler enumHandler,
           int nodeValueColumnIndex, int nodeDataTypeColumnIndex)
        {
            return new EnumCollectionGridOutputer(opcClient, enumHandler, nodeValueColumnIndex, nodeDataTypeColumnIndex);
        }

        public static IOpcUaNodeValueGridOutputer CreateOpcUaStringGridOutputer(int nodeValueColumnIndex, int nodeDataTypeColumnIndex)
        {
            return new StringGridOutputer(nodeValueColumnIndex, nodeDataTypeColumnIndex);
        }
    }
}

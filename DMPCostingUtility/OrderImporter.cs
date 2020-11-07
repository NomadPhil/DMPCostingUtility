using FileHelpers;

namespace DMPCostingUtility
{
    class OrderImporter : IOrderImporter
    {
        public Order[] ImportFile(string fileName)
        {
            // Import orders              
            var engine = new FileHelperEngine<Order>();

            engine.ErrorManager.ErrorMode = ErrorMode.ThrowException;
            
            return engine.ReadFile(fileName);
        }
    }
}
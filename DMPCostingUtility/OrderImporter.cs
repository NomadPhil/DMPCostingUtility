using System;
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
            try
            {
                engine.ReadFile(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return engine.ReadFile(fileName);
        }
    }
}
namespace DMPCostingUtility
{
    internal interface IOrderImporter
    {
        Order[] ImportFile(string fileName);
    }
}
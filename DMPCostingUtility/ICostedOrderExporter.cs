namespace DMPCostingUtility
{
    interface ICostedOrderExporter
    {
        void ExportCosted(CostedOrder[] costed, string fileName);
    }
}
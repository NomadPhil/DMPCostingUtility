using FileHelpers;
using System;
using System.IO;

namespace DMPCostingUtility
{
    class CostedOrderExporter : ICostedOrderExporter
    {
        private readonly CostedOrderExporterSettings _settings;
        public CostedOrderExporter(CostedOrderExporterSettings settings)
        {
            _settings = settings;
        }

        public void ExportCosted(CostedOrder[] costed, string fileName)
        {
            var engine = new FileHelperEngine<CostedOrder> 
            { 
                HeaderText = typeof(CostedOrder).GetCsvHeader()
            };

            engine.WriteFile(Path.Combine(_settings.ExportDirectory, $"costed{DateTime.Now:_yyyyMMdd_HHmmss}-{fileName}"), costed);
        }
    }
}

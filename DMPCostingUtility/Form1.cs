using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DMPCostingUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBaseCost.Text = ConfigurationManager.AppSettings["BaseCost"];
            txtPerItemCost.Text = ConfigurationManager.AppSettings["PerItemCost"];
            txtImportDirectory.Text = ConfigurationManager.AppSettings["WooCommerceExportDirDefault"];
            txtExportDirectory.Text = ConfigurationManager.AppSettings["CostedDirectoryDefault"];
            txtProcessedDirectory.Text = ConfigurationManager.AppSettings["WooCommerceProcessedDirDefault"];
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string baseCostText = txtBaseCost.Text;
            double baseCost = 0;
            double perItemCost = 0;
            string perItemCostText = txtPerItemCost.Text;
            string importDirectory = txtImportDirectory.Text;
            string exportDirectory = txtExportDirectory.Text;
            string processedDirectory = txtProcessedDirectory.Text;

            bool hasErrors = false;

            if (string.IsNullOrWhiteSpace(baseCostText))
            {
                errorProvider1.SetError(txtBaseCost, "Base cost required!");
                hasErrors = true;
            }
            else if (!double.TryParse(baseCostText, out baseCost))
            {
                errorProvider1.SetError(txtBaseCost, "Base cost must be a numeric value!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(perItemCostText))
            {
                errorProvider1.SetError(txtPerItemCost, "Cost per additional item required!");
                hasErrors = true;
            }
            else if (!double.TryParse(perItemCostText, out perItemCost))
            {
                errorProvider1.SetError(txtPerItemCost, "Cost per additional item must be a numeric value!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(importDirectory))
            {
                errorProvider1.SetError(txtImportDirectory, "Directory of Woo Commerce Exported Files required!");
                hasErrors = true;
            }
            else if (!Directory.Exists(importDirectory))
            {
                errorProvider1.SetError(txtImportDirectory, "Directory of Woo Commerce Exported Files does not exist!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(exportDirectory))
            {
                errorProvider1.SetError(txtExportDirectory, "Directory of costed files required!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(processedDirectory))
            {
                errorProvider1.SetError(txtProcessedDirectory, "Directory of costed Woo Comerce Exported Files required!");
                hasErrors = true;
            }

            if (hasErrors)
                return;

            var fileProcessor = new FileProcessor(
                new FileProcessorSettings
                {
                    ImportDirectory = importDirectory,
                    ExportDirectory = exportDirectory,
                    ProcessedDirectory = processedDirectory
                },
                new OrderCoster(
                    new OrderCosterSettings
                    {
                        BaseCost =  baseCost,
                        PerItemCost = perItemCost
                    }
                    ),
                new CostedOrderExporter(
                    new CostedOrderExporterSettings
                    {
                        ExportDirectory = exportDirectory
                    }
                    ));

            string[] filesCosted = fileProcessor.ProcessFiles();

            var messageBuilder = new StringBuilder();

            if (filesCosted.Length > 0)
            {
                messageBuilder.AppendLine("Costed files:");

                foreach (var file in filesCosted)
                {
                    messageBuilder.AppendLine(file);
                }
            }
            else
            {
                messageBuilder.AppendLine("No files processed.");
                messageBuilder.AppendLine("If there are files there to process, make sure they are not open in a spreadsheet and they are in the correct format.");
            }

            MessageBox.Show(messageBuilder.ToString());
        }
    }
}

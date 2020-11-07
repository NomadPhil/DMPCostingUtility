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
            if (FormHasErrors(out double baseCost, out double perItemCost))
                return;

            var fileProcessor = GetFileProcessor(baseCost, perItemCost);

            string[] filesCosted = fileProcessor.ProcessFiles();

            MessageBox.Show(GetFileProcessingMessage(filesCosted));
        }

        private FileProcessor GetFileProcessor(double baseCost, double perItemCost)
        {
            var fileProcessor = new FileProcessor(
                new FileProcessorSettings
                {
                    ImportDirectory = txtImportDirectory.Text,
                    ExportDirectory = txtExportDirectory.Text,
                    ProcessedDirectory = txtProcessedDirectory.Text
                },
                new OrderCoster(
                    new OrderCosterSettings
                    {
                        BaseCost = baseCost,
                        PerItemCost = perItemCost
                    }
                ),
                new CostedOrderExporter(
                    new CostedOrderExporterSettings
                    {
                        ExportDirectory = txtExportDirectory.Text
                    }
                ),
                new OrderImporter());
            return fileProcessor;
        }

        private bool FormHasErrors(out double baseCost, out double perItemCost)
        {
            baseCost = 0;
            perItemCost = 0;
            string baseCostText = txtBaseCost.Text;
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

            return hasErrors;
        }

        private string GetFileProcessingMessage(string[] filesCosted)
        {
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

            return messageBuilder.ToString();
        }
    }
}

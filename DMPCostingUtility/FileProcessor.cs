using FileHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DMPCostingUtility
{
    class FileProcessor
    {
        private readonly FileProcessorSettings _settings;
        private readonly IOrderCoster _orderCoster;
        private readonly ICostedOrderExporter _costedOrderExporter;

        public FileProcessor(
            FileProcessorSettings settings, 
            IOrderCoster orderCoster,
            ICostedOrderExporter costedOrderExporter)
        {
            _settings = settings;
            _orderCoster = orderCoster;
            _costedOrderExporter = costedOrderExporter;
        }

        public string[] ProcessFiles()
        {
            string[] processedFiles = new string[0];

            try
            {
                string[] fileEntries = Directory.GetFiles(_settings.ImportDirectory);

                if (fileEntries.Length > 0)
                {
                    string[] validFiles = ValidFiles(fileEntries);

                    if (validFiles.Length > 0)
                    {
                        // Process the list of files found in the directory.
                        foreach (string filePathName in validFiles)
                        {
                            ProcessFile(filePathName);
                        }
                            
                        MoveToFolder(validFiles);

                        processedFiles = validFiles;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ProcessFiles(): Exception raised whilst processing file.", ex);
            }

            return processedFiles;
        }

        private string[] ValidFiles(string[] fileEntries)
        {
            var validFiles = new List<string>();
            // Process the list of files found in the directory.
            foreach (string filePathName in fileEntries)
            {
                string filename = Path.GetFileName(filePathName);

                // If file has a valid extension then upload it and move it to the processed folder
                if (!string.IsNullOrWhiteSpace(filename) &&
                    Path.GetExtension(filename) == ".csv")
                {
                    validFiles.Add(filePathName);
                }
            }

            return validFiles.ToArray();
        }

        private int MoveToFolder(string[] validFiles)
        {
            int processedFilesCount = 0;

            // Process the list of files found in the directory.
            foreach (string filePathName in validFiles)
            {
                string filename = Path.GetFileName(filePathName);

                // If file has a valid extension then upload it and move it to the processed folder
                if (!string.IsNullOrWhiteSpace(filename) &&
                    Path.GetExtension(filename) == ".csv")
                {
                    string destinationFile = Path.Combine(_settings.ProcessedDirectory, filename);

                    // Check if processed directory exists - if not create it
                    if (!Directory.Exists(_settings.ProcessedDirectory))
                    {
                        Directory.CreateDirectory(_settings.ProcessedDirectory);
                    }

                    // Move uploaded file to the processed Directory - if already there overwrite
                    if (File.Exists(destinationFile))
                    {
                        File.Delete(destinationFile);
                    }

                    File.Move(filePathName, destinationFile);

                    processedFilesCount++;
                }
            }

            return processedFilesCount;
        }

        public int ProcessFile(string validFile)
        {
            // Import orders              
            var engine = new FileHelperEngine<Order>();

            engine.ErrorManager.ErrorMode = ErrorMode.ThrowException;

            List<Order> importRecords = engine.ReadFile(validFile).ToList();

            CostedOrder[] costed = _orderCoster.ProcessOrders(importRecords);

            _costedOrderExporter.ExportCosted(costed, Path.GetFileName(validFile));

            return costed.Length;
        }
    }
}

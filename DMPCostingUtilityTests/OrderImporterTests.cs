using DMPCostingUtility;
using System;
using System.IO;
using Shouldly;
using Xunit;

namespace DMPCostingUtilityTests
{
    public class OrderImporterTests
    {
        private readonly OrderImporter _orderImporter = new OrderImporter();

        [Fact]
        public void ImportsOrdersFileWithNoException()
        {
            // Arrange
            string ordersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFiles", "orders.csv");

            // Act & Assert
            Should.NotThrow(() => _orderImporter.ImportFile(ordersFile));
        }

        [Fact]
        public void ImportsAllOrders()
        {
            // Arrange
            string ordersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFiles", "orders.csv");

            // Act
            Order[] orders = _orderImporter.ImportFile(ordersFile);

            // Assert
            orders.Length.ShouldBe(982);
        }
    }
}

using FileHelpers;

namespace DMPCostingUtility
{
    [DelimitedRecord(",")]
    class CostedOrder
    {
        [FieldOrder(1), FieldTitle("Order Number")]
        public string OrderNumber;
        [FieldOrder(2), FieldTitle("Order Date")]
        public string OrderDate;
        [FieldOrder(3), FieldTitle("Number of Products")]
        public int NumberOfProducts;
        [FieldOrder(4), FieldTitle("Cost")]
        public double Cost;
        [FieldOrder(5), FieldTitle("Order Shipping Amount")]
        public double OrderShippingAmount;
    }
}

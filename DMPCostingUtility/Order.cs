using FileHelpers;

namespace DMPCostingUtility
{
    [DelimitedRecord(","), IgnoreFirst(1)]
    class Order
    {
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDate { get; set; }
        [FieldQuoted]
        public string CustomerNote { get; set; }
        public string FirstNameBilling { get; set; }
        public string LastNameBilling { get; set; }
        public string Sku { get; set; }
        public string ItemNumber { get; set; }
        [FieldQuoted]
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string ItemCost { get; set; }
        public string CouponCode { get; set; }
        public string DiscountAmount { get; set; }
        public string DiscountAmountTax { get; set; }
    }
}

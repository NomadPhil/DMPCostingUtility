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

        [FieldQuoted]
        public string BillingFirstName { get; set; }

        [FieldQuoted]
        public string BillingLastName { get; set; }

        [FieldQuoted]
        public string BillingCompany { get; set; }

        [FieldQuoted]
        public string BillingAddress { get; set; }

        [FieldQuoted]
        public string BillingCity { get; set; }

        [FieldQuoted]
        public string BillingStateCode { get; set; }

        [FieldQuoted]
        public string BillingPostcode { get; set; }

        [FieldQuoted]
        public string BillingCountryCode { get; set; }

        [FieldQuoted]
        public string BillingEmail { get; set; }

        [FieldQuoted]
        public string BillingPhone { get; set; }

        [FieldQuoted]
        public string ShippingFirstName { get; set; }

        [FieldQuoted]
        public string ShippingLastName { get; set; }

        [FieldQuoted]
        public string ShippingAddress { get; set; }

        [FieldQuoted]
        public string ShippingCity { get; set; }

        [FieldQuoted]
        public string ShippingStateCode { get; set; }

        [FieldQuoted]
        public string ShippingPostcode { get; set; }

        [FieldQuoted]
        public string ShippingCountryCode { get; set; }

        [FieldQuoted]
        public string PaymentMethodTitle { get; set; }

        [FieldNullValue(0d)]
        public double CartDiscountAmount { get; set; }

        [FieldNullValue(0d)]
        public double OrderSubtotalAmount { get; set; }

        [FieldQuoted]
        public string ShippingMethodTitle { get; set; }

        [FieldNullValue(0d)]
        public double OrderShippingAmount { get; set; }

        [FieldNullValue(0d)]
        public double OrderRefundAmount { get; set; }

        [FieldNullValue(0d)]
        public double OrderTotalAmount { get; set; }

        [FieldNullValue(0d)]
        public double OrderTotalTaxAmount { get; set; }

        [FieldQuoted]
        public string Sku { get; set; }

        [FieldNullValue(0)]
        public int ItemNumber { get; set; }

        [FieldQuoted]
        public string ItemName { get; set; }

        [FieldNullValue(0)]
        public int Quantity { get; set; }

        [FieldNullValue(0d)]
        public double ItemCost { get; set; }

        [FieldQuoted]
        public string CouponCode { get; set; }

        [FieldNullValue(0d)]
        public double DiscountAmount { get; set; }
        [FieldNullValue(0d)]
        public double DiscountAmountTax { get; set; }
    }
}

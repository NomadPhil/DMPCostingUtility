using System.Collections.Generic;
using System.Linq;

namespace DMPCostingUtility
{
    class OrderCoster : IOrderCoster
    {
        private readonly OrderCosterSettings _settings;

        public OrderCoster(OrderCosterSettings settings)
        {
            _settings = settings;
        }

        public CostedOrder[] ProcessOrders(Order[] orders)
        {
            var costedOrders = new Dictionary<string, CostedOrder>();

            // Get a list of orders to cost with number of SKUs / Products for each order
            foreach (var order in orders)
            {
                // Ignore lines with blank SKU - not costed
                if (!string.IsNullOrWhiteSpace(order.Sku))
                {
                    if (costedOrders.ContainsKey(order.OrderNumber))
                    {
                        costedOrders[order.OrderNumber].NumberOfProducts++;
                    }
                    else
                    {
                        costedOrders.Add(
                            order.OrderNumber,
                            new CostedOrder
                            {
                                OrderDate = order.OrderDate,
                                OrderNumber = order.OrderNumber,
                                NumberOfProducts = 1,
                                OrderShippingAmount = order.OrderShippingAmount
                            });
                    }
                }
            }

            // Calculate costs for each order using number of products
            foreach (var costedOrder in costedOrders.Values)
            {
                costedOrder.Cost = _settings.BaseCost + ((costedOrder.NumberOfProducts - 1) * _settings.PerItemCost);
            }

            return costedOrders.Values.ToArray();
        }
    }
}

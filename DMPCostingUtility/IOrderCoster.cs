﻿using System.Collections.Generic;

namespace DMPCostingUtility
{
    interface IOrderCoster
    {
        CostedOrder[] ProcessOrders(Order[] orders);
    }
}
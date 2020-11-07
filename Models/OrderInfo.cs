using System;
using System.Collections.Generic;

namespace Narvar.SDK.Models
{
    public class OrderInfo
    {
        public string order_number { get; set; }
        public DateTime order_date { get; set; }
        public List<OrderItem> order_items { get; set; }
        public List<object> shipments { get; set; }
        public List<object> pickups { get; set; }
        public Billing billing { get; set; }
        public Customer customer { get; set; }
    }
}

namespace Narvar.SDK.Models
{
    public class OrderItem
    {
        public string item_id { get; set; }
        public object retailer { get; set; }
        public string sku { get; set; }
        public object customer_comment { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }
        public object discount_amount { get; set; }
        public object discount_percent { get; set; }
        public object categories { get; set; }
        public string item_image { get; set; }
        public string item_url { get; set; }
        public object is_final_sale { get; set; }
        public object is_active { get; set; }
        public string fulfillment_status { get; set; }
        public object fulfillment_type { get; set; }
        public bool is_gift { get; set; }
        public object final_sale_date { get; set; }
        public object product_type { get; set; }
        public object product_id { get; set; }
        public object line_number { get; set; }
        public Attributes attributes { get; set; }
        public object dimensions { get; set; }
        public object is_backordered { get; set; }
        public object vendor { get; set; }
        public object item_promise_date { get; set; }
        public object return_reason_code { get; set; }
        public object events { get; set; }
        public object vendors { get; set; }
        public object color { get; set; }
        public object size { get; set; }
        public object style { get; set; }
        public object line_price { get; set; }
        public object original_unit_price { get; set; }
        public object original_line_price { get; set; }
    }
}

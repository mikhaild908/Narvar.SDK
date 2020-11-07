namespace Narvar.SDK.Models
{
    public class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public Address address { get; set; }
        public string customer_id { get; set; }
    }
}

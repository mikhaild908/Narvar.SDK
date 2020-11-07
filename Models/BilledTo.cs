namespace Narvar.SDK.Models
{
    public class BilledTo
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public Address address { get; set; }
    }
}

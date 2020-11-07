using System.Collections.Generic;

namespace Narvar.SDK.Models
{
    // NarvarResponse myDeserializedClass = JsonConvert.DeserializeObject<NarvarResponse>(myJsonResponse);

    public class NarvarResponse
    {
        public OrderInfo order_info { get; set; }
        public string status { get; set; }
        public List<Message> messages { get; set; }
    }
}
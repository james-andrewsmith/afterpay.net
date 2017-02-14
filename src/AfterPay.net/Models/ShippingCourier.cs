using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#shipping-courier-object
    /// </summary>
    public class ShippingCourier
    {
        [JsonProperty("shippedAt")]
        public string ShippedAt
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("tracking")]
        public string Tracking
        {
            get;
            set;
        }

        [JsonProperty("priority")]
        public string Priority
        {
            get;
            set;
        }
    }
}

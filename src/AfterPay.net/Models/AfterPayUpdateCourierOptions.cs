using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayUpdateCourierOptions
    {
        [JsonIgnore]
        public string PaymentID
        {
            get;
            set;
        }

        [JsonProperty("shippedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippedAt
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("tracking", NullValueHandling = NullValueHandling.Ignore)]
        public string Tracking
        {
            get;
            set;
        }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority
        {
            get;
            set;
        }
         

    }
}

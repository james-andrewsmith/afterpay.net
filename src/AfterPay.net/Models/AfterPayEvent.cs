using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#webhooks
    /// </summary>
    public class AfterPayEvent
    {
        [JsonProperty("eventId")]
        public string EventID
        {
            get;
            set;
        }

        [JsonProperty("eventType")]
        public string EventType
        {
            get;
            set;
        }

        [JsonProperty("occurredAt")]
        public string OccurredAt
        {
            get;
            set;
        }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl
        {
            get;
            set;
        }

        [JsonProperty("meta")]
        public Dictionary<string, string> Meta
        {
            get;
            set;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayCaptureOptions
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("merchantReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantReference
        {
            get;
            set;
        }

        [JsonProperty("webhookEventUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string WebhookEventUrl
        {
            get;
            set;
        }
    }
}

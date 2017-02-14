using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#create-refund
    /// </summary>
    public class AfterPayRefundOptions
    {
        [JsonIgnore]
        public string PaymentID
        {
            get;
            set;
        }

        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestID
        {
            get;
            set;
        }

        [JsonProperty("amount")]
        public Money Amount
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
    }
}

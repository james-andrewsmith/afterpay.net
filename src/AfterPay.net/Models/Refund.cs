using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#refund-object
    /// </summary>
    public class Refund
    {
        [JsonProperty("id")]
        public string ID
        {
            get;
            set;
        }

        [JsonProperty("refundedAt")]
        public string RefundedAt
        {
            get;
            set;
        }

        [JsonProperty("merchantReference")]
        public string MerchantReference
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
    }
}

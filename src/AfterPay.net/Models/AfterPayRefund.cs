using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public sealed class AfterPayRefund
    {
        [JsonProperty("refundId")]
        public string RefundID
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

        [JsonProperty("requestId")]
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

        [JsonProperty("merchantReference")]
        public string MerchantReference
        {
            get;
            set;
        }
    }
}

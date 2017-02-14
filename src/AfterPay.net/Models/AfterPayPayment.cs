using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public sealed class AfterPayPayment
    {
        [JsonProperty("id")]
        public string ID
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public string Created
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty("totalAmount")]
        public Money TotalAmount
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

        [JsonProperty("events")]
        public PaymentEvent[] Events
        {
            get;
            set;
        }

        [JsonProperty("refunds")]
        public Refund[] Refunds
        {
            get;
            set;
        }

        [JsonProperty("orderDetails")]
        public OrderDetails OrderDetails
        {
            get;
            set;
        }
    }
}

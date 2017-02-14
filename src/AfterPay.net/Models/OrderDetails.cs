using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#order-details-object
    /// </summary>
    public class OrderDetails
    {
        [JsonProperty("consumer")]
        public Consumer Consumer
        {
            get;
            set;
        }

        [JsonProperty("billing")]
        public Contact Billing
        {
            get;
            set;
        }

        [JsonProperty("courier")]
        public ShippingCourier Courier
        {
            get;
            set;
        }

        [JsonProperty("items")]
        public Item[] Items
        {
            get;
            set;
        }

        [JsonProperty("discounts")]
        public Discount[] Discounts
        {
            get;
            set;
        }

        [JsonProperty("taxAmount")]
        public Money TaxAmount
        {
            get;
            set;
        }

        [JsonProperty("shippingAmount")]
        public Money ShippingAmount
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayOrder
    {
        [JsonProperty("totalAmount")]
        public Money TotalAmount
        {
            get;
            set;
        }

        [JsonProperty("consumer")]
        public Consumer Consumer
        {
            get;
            set;
        }

        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public Contact Billing
        {
            get;
            set;
        }

        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Contact Shipping
        {
            get;
            set;
        }

        [JsonProperty("courier", NullValueHandling = NullValueHandling.Ignore)]
        public ShippingCourier Courier
        {
            get;
            set;
        }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Item[] Items
        {
            get;
            set;
        }

        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public Discount[] Discounts
        {
            get;
            set;
        }

        [JsonProperty("merchant")]
        public MerchantUrls Merchant
        {
            get;
            set;
        }


        [JsonProperty("paymentType")]
        public string PaymentType
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#item-object
    /// </summary>
    public class Item
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("sku")]
        public string Sku
        {
            get;
            set;
        }

        [JsonProperty("quantity")]
        public long Quantity
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public Money Price
        {
            get;
            set;
        }
    }
}

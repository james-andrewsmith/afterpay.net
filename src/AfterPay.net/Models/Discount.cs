using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#discount-object
    /// </summary>
    public class Discount
    {
        [JsonProperty("displayName")]
        public string DisplayName
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

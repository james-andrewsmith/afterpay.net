using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{

    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#get-configuration
    /// </summary>
    public class AfterPayConfiguration
    {
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("minimumAmount")]
        public Money MinimumAmount
        {
            get;
            set;
        }

        [JsonProperty("maximumAmount")]
        public Money MaximumAmount
        {
            get;
            set;
        }
    }
}

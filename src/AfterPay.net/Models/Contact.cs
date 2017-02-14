using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#contact-object
    /// </summary>
    public class Contact
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("line1")]
        public string Line1
        {
            get;
            set;
        }

        [JsonProperty("line2")]
        public string Line2
        {
            get;
            set;
        }

        [JsonProperty("suburb")]
        public string Suburb
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("postcode")]
        public string Postcode
        {
            get;
            set;
        }

        [JsonProperty("countryCode")]
        public string CountryCode
        {
            get;
            set;
        }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}

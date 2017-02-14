using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#consumer-object
    /// </summary>
    public class Consumer
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber
        {
            get;
            set;
        }

        [JsonProperty("givenNames")]
        public string GivenNames
        {
            get;
            set;
        }

        [JsonProperty("surname")]
        public string Surname
        {
            get;
            set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get;
            set;
        }
    }
}

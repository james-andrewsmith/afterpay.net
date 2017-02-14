using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayOrderToken
    {
        [JsonProperty("expires")]
        public string Expires
        {
            get;
            set;
        }

        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class MerchantUrls
    {
        [JsonProperty("redirectConfirmUrl")]
        public string RedirectConfirmUrl
        {
            get;
            set;
        }

        [JsonProperty("redirectCancelUrl")]
        public string RedirectCancelUrl
        {
            get;
            set;
        }
    }
}

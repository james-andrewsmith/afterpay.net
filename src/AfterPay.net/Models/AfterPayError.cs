using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayError
    {
        [JsonIgnore()]
        public int HttpStatusCode
        {
            get;
            set;
        }

        [JsonProperty("errorId")]
        public string ID
        {
            get;
            set;
        }

        [JsonProperty("errorCode")]
        public string Code
        {
            get;
            set;
        }

        [JsonProperty("errorMessage")]
        public string Message
        {
            get;
            set;
        }
    }
}

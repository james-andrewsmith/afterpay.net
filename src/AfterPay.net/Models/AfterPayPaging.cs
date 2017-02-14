using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public sealed class AfterPayPaging<T>
    {
        [JsonProperty("totalResults")]
        public long TotalResults
        {
            get;
            set;
        }

        [JsonProperty("offset")]
        public long Offset
        {
            get;
            set;
        }

        [JsonProperty("limit")]
        public long Limit
        {
            get;
            set;
        }

        [JsonProperty("results")]
        public T[] Results
        {
            get;
            set;
        }
    }
}

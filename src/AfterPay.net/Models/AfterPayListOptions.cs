using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AfterPay.Models
{
    public class AfterPayListOptions
    {
        [JsonProperty("toCreatedDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToCreatedDate
        {
            get;
            set;    
        }

        [JsonProperty("fromCreatedDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromCreatedDate
        {
            get;
            set;
        }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long Limit
        {
            get;
            set;
        }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long Offset
        {
            get;
            set;
        }

        [JsonProperty("tokens", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tokens
        {
            get;
            set;
        }

        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IDs
        {
            get;
            set;
        }

        [JsonProperty("merchantReferences", NullValueHandling = NullValueHandling.Ignore)]
        public string[] MerchantReferences
        {
            get;
            set;
        }

        [JsonProperty("statuses", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Statuses
        {
            get;
            set;
        }

        [JsonProperty("orderBy", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy
        {
            get;
            set;
        }

        [JsonProperty("ascending", NullValueHandling = NullValueHandling.Ignore)]
        public string Ascending
        {
            get;
            set;
        }
    }
}

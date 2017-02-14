using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using AfterPay;
using AfterPay.Models;

namespace AfterPay
{

    public static class Mapper<T>
    {
        public static List<T> MapCollectionFromJson(string json, string token = "data", AfterPayResponse stripeResponse = null)
        {
            var jObject = JObject.Parse(json);

            var allTokens = jObject.SelectToken(token);

            return allTokens.Select(tkn => MapFromJson(tkn.ToString(), null, stripeResponse)).ToList();
        }

        public static List<T> MapCollectionFromJson(AfterPayResponse stripeResponse, string token = "data")
        {
            return MapCollectionFromJson(stripeResponse.ResponseJson, token, stripeResponse);
        }

        // the ResponseJson on a list method is the entire list (as json) returned from stripe. 
        // the ObjectJson is so we can store only the json for a single object in the list on that entity for
        // logging and/or debugging
        public static T MapFromJson(string json, string parentToken = null, AfterPayResponse stripeResponse = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();            
            return JsonConvert.DeserializeObject<T>(jsonToParse);
        }

        public static T MapFromJson(AfterPayResponse response, string parentToken = null)
        {
            return MapFromJson(response.ResponseJson, parentToken, response);
        }
         
    }
}

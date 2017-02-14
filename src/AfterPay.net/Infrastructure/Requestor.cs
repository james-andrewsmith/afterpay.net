using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AfterPayError = AfterPay.Models.AfterPayError;
using AfterPayResponse = AfterPay.Models.AfterPayResponse;
using AfterPayException = AfterPay.Exceptions.AfterPayException;
using AfterPayConfiguration = AfterPay.Infrastructure.AfterPayConfiguration;

namespace AfterPay
{
    internal static class Requestor
    {
        internal static HttpClient HttpClient { get; private set; }

        static Requestor()
        {
            HttpClient =
                AfterPayConfiguration.HttpMessageHandler != null
                    ? new HttpClient(AfterPayConfiguration.HttpMessageHandler)
                    : new HttpClient();
        }

        // Sync
        public static AfterPayResponse GetString(string url, AfterPayRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequest(wr);
        }

        public static AfterPayResponse PostString(string url, AfterPayRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequest(wr);
        }

        public static AfterPayResponse Delete(string url, AfterPayRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequest(wr);
        }
         
         
        private static AfterPayResponse ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = HttpClient.SendAsync(requestMessage).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
                return BuildResponseData(response, responseText);

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
        }


        // Async
        public static Task<AfterPayResponse> GetStringAsync(string url, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<AfterPayResponse> PostStringAsync(string url, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostStringAsync(url, null, requestOptions, cancellationToken);
        }

        public static Task<AfterPayResponse> PostStringAsync(string url, string postJson, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<AfterPayResponse> PutStringAsync(string url, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PutStringAsync(url, null, requestOptions, cancellationToken);
        }

        public static Task<AfterPayResponse> PutStringAsync(string url, string putJson, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Put, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<AfterPayResponse> DeleteAsync(string url, AfterPayRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }                

        private static async Task<AfterPayResponse> ExecuteRequestAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken);

            if (response.IsSuccessStatusCode)
                return BuildResponseData(response, await response.Content.ReadAsStringAsync());

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, await response.Content.ReadAsStringAsync());
        }



        private static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, AfterPayRequestOptions requestOptions)
        {            
#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

            var request = BuildRequest(method, url);

            request.Headers.Add("Authorization",
                GetAuthorizationHeaderValue(requestOptions.MerchantID, requestOptions.MerchantSecretKey)
            );

            request.Headers.Add("Accept", "application/json");

            // http://docs.afterpay.com.au/merchant-api-v1.html#idempotent-requests
            // if (requestOptions.RequestID != null)
            //     request.Headers.Add("requestId", requestOptions.RequestID);
            
            return request;
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string url)
        {
            if (method != HttpMethod.Post && 
                method != HttpMethod.Put)
                return new HttpRequestMessage(method, new Uri(url));

            var postData = string.Empty;
            var newUrl = url;

            if (!string.IsNullOrEmpty(new Uri(url).Query))
            {
                postData = new Uri(url).Query.Substring(1);
                newUrl = url.Substring(0, url.IndexOf("?", StringComparison.CurrentCultureIgnoreCase));
            }

            var request = new HttpRequestMessage(method, new Uri(newUrl))
            {
                Content = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            return request;
        }

        private static string GetAuthorizationHeaderValue(string merchantID, string merchantSecretKey)
        {
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{merchantID}:{merchantSecretKey}"));
            return $"Basic {token}";
        }
        

        private static AfterPayException BuildStripeException(HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = Mapper<AfterPayError>.MapFromJson(responseContent);
            return new AfterPayException(stripeError);
        }

        private static AfterPayResponse BuildResponseData(HttpResponseMessage response, string responseText)
        {
            var result = new AfterPayResponse
            {
                HttpStatusCode = (int)response.StatusCode,
                ResponseJson = responseText
            };

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using AfterPay.Models;

namespace AfterPay.Services
{
    public class StatusService : AfterPayService
    {
        public StatusService(AfterPayRequestOptions serviceOptions = null) : base(serviceOptions)
        {

        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#ping
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<bool> PingAsync(AfterPayRequestOptions requestOptions = null)
        {
            var response = await Requestor.GetStringAsync(
                $"{Urls.Version}/ping",
                SetupRequestOptions(requestOptions)
            );

            return (response.HttpStatusCode == 200);                
        }

    }
}

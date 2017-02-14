using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using AfterPay.Models;

namespace AfterPay.Services
{
    public class OrderService : AfterPayService
    {
        public OrderService(AfterPayRequestOptions serviceOptions = null) : base(serviceOptions)
        {

        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#create-order
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayOrderToken> Create(AfterPayOrder order, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayOrderToken>.MapFromJson(
                await Requestor.PostStringAsync(
                    $"{Urls.Version}/{Urls.Orders}",
                    JsonConvert.SerializeObject(order),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#get-order
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayOrder> Get(string token, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayOrder>.MapFromJson(
                await Requestor.GetStringAsync(
                    $"{Urls.Version}/{Urls.Orders}/{token}",
                    SetupRequestOptions(requestOptions)
                )
            );
        }

    }
}

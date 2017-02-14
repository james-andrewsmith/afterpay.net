using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfterPay.Models;

namespace AfterPay.Services
{
    public class ConfigurationService : AfterPayService
    {
        public ConfigurationService(AfterPayRequestOptions serviceOptions = null) : base(serviceOptions)
        {

        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#get-configuration
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayConfiguration[]> GetAsync(AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayConfiguration[]>.MapFromJson(
                await Requestor.PostStringAsync(
                    $"{Urls.Version}/{Urls.Configuration}", 
                    SetupRequestOptions(requestOptions)
                )
            );
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AfterPay.Services
{
    public abstract class AfterPayService
    {
        public AfterPayService(AfterPayRequestOptions serviceOptions = null)
        {
            _serviceOptions = serviceOptions;
        }

        private readonly AfterPayRequestOptions _serviceOptions;

        protected AfterPayRequestOptions SetupRequestOptions(AfterPayRequestOptions requestOptions)
        {
            // Build options from the request, 
            // then from the service, 
            // then from the configuration static object


            // https://api.secure-afterpay.com.au/v1/
            // https://api-sandbox.secure-afterpay.com.au/v1/
            // Add accept header "application/json"


            return requestOptions;
        }



    }
}

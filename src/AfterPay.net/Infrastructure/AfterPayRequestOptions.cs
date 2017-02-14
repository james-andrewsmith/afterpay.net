using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterPay
{
    public class AfterPayRequestOptions
    {
        public bool UseSandbox
        {
            get;
            set;
        }

        public string MerchantID
        {
            get;
            set;
        }

        public string MerchantSecretKey
        {
            get;
            set;
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#idempotent-requests
        /// </summary>
        public string RequestID
        {
            get;
            set;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AfterPay.Infrastructure
{
    public class AfterPayConfiguration
    {
        public static HttpMessageHandler HttpMessageHandler
        {
            get;
            set;
        }
    }
}

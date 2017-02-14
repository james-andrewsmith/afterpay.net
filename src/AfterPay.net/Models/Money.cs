using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterPay.Models
{
    /// <summary>
    /// http://docs.afterpay.com.au/merchant-api-v1.html#money-object
    /// </summary>
    public class Money
    {
        public string Amount
        {
            get;
            set;
        }

        public string Currency
        {
            get;
            set;
        }
    }
}

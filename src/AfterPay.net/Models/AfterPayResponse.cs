using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterPay.Models
{
    public sealed class AfterPayResponse
    {

        public int HttpStatusCode
        {
            get;
            set;
        }

        public string ResponseJson
        {
            get;
            set;
        }

    }
}

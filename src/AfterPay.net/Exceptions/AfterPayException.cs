using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AfterPay.Models;

namespace AfterPay.Exceptions
{
    public class AfterPayException : Exception
    {
        public AfterPayException(AfterPayError error) : base(error.Message)
        {
            ErrorID = error.ID;
            ErrorCode = error.Code;
            HttpStatusCode = error.HttpStatusCode;            
        }

        public int HttpStatusCode
        {
            get;
            set;
        }

        public string ErrorID
        {
            get;
            set;
        }

        public string ErrorCode
        {
            get;
            set;
        }
    }
}

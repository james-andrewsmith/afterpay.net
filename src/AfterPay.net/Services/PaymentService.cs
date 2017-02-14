using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AfterPay.Models;
using Newtonsoft.Json;

namespace AfterPay.Services
{
    public class PaymentService : AfterPayService
    {
        public PaymentService(AfterPayRequestOptions serviceOptions = null) : base(serviceOptions)
        {

        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#direct-capture-payment
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayPayment> CaptureAsync(AfterPayCaptureOptions captureOptions, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayPayment>.MapFromJson(
                await Requestor.PostStringAsync(
                    $"{Urls.Version}/{Urls.Payments}/capture",
                    JsonConvert.SerializeObject(captureOptions),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#update-shipping-courier
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayPayment> UpdateShippingCourierAsync(AfterPayUpdateCourierOptions courierOptions, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayPayment>.MapFromJson(
                await Requestor.PutStringAsync(
                    $"{Urls.Version}/{Urls.Payments}/{courierOptions.PaymentID}/courier",
                    JsonConvert.SerializeObject(courierOptions),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#get-payment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayPayment> GetAsync(string id, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayPayment>.MapFromJson(
                await Requestor.GetStringAsync(
                    $"{Urls.Version}/{Urls.Payments}/{id}",                    
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#get-payment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayPayment> GetByTokenAsync(string token, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayPayment>.MapFromJson(
                await Requestor.GetStringAsync(
                    $"{Urls.Version}/{Urls.Payments}/token:{token}",
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#list-payments
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayPaging<AfterPayPayment>> ListAsync(AfterPayListOptions listOptions, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayPaging<AfterPayPayment>>.MapFromJson(
                await Requestor.GetStringAsync(
                    $"{Urls.Version}/{Urls.Payments}{Urls.BuildQueryString(listOptions)}",
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        /// <summary>
        /// http://docs.afterpay.com.au/merchant-api-v1.html#create-refund
        /// </summary>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public async Task<AfterPayRefund> RefundAsync(AfterPayRefundOptions refundOptions, AfterPayRequestOptions requestOptions = null)
        {
            return Mapper<AfterPayRefund>.MapFromJson(
                await Requestor.PostStringAsync(
                    $"{Urls.Version}/{Urls.Payments}/{refundOptions.PaymentID}/refund",
                    JsonConvert.SerializeObject(refundOptions),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

    }
}

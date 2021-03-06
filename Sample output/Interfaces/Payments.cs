//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class Payments
    {
        /// <summary>
        /// <para>POST /payments/v1/pmc-start-url</para>
        /// </summary>
        [Endpoint("/payments/v1/pmc-start-url")]
        public static Task<PaymentsFrontEndResult> PostPaymentsV1PmcStartUrl([Parameter("options", "body")] PaymentsFrontEndRequest options)
            => Sender.Request<PaymentsFrontEndResult>("post", $"/payments/v1/pmc-start-url", options);

        public static string GetURL(string methodName)
        {
            return typeof(Payments).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}

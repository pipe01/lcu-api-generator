using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class Payments
    {
        public static Task<PaymentsFrontEndResult> PostPaymentsV1PmcStartUrl([Parameter("options", "body")] PaymentsFrontEndRequest options)
            => Sender.Request<PaymentsFrontEndResult>("post", $"/payments/v1/pmc-start-url", options);
    }
}

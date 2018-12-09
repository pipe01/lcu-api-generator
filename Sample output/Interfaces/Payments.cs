using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Payments
    {
        public static Task<PaymentsFrontEndResult> PostPaymentsV1PmcStartUrl([Parameter("options", "body")] PaymentsFrontEndRequest options)
            => Sender.Request<PaymentsFrontEndResult>("post", $"/payments/v1/pmc-start-url", options);
    }
}

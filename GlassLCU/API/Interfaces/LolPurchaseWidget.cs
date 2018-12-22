using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolPurchaseWidget
    {
        public static Task<LolPurchaseWidgetPurchaseWidgetConfig> GetLolPurchaseWidgetV1Configuration()
            => Sender.Request<LolPurchaseWidgetPurchaseWidgetConfig>("get", $"/lol-purchase-widget/v1/configuration");
        public static Task<object> PostLolPurchaseWidgetV1PurchaseItems([Parameter("purchaseRequest", "body")] LolPurchaseWidgetPurchaseRequest purchaseRequest)
            => Sender.Request<object>("post", $"/lol-purchase-widget/v1/purchaseItems", purchaseRequest);
        public static Task<object> PostLolPurchaseWidgetV1ValidateItems([Parameter("validationRequest", "body")] LolPurchaseWidgetValidationRequest validationRequest)
            => Sender.Request<object>("post", $"/lol-purchase-widget/v1/validateItems", validationRequest);
    }
}

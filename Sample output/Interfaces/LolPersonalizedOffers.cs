using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPersonalizedOffers
    {
        public static Task<LolPersonalizedOffersUIOffer[]> GetLolPersonalizedOffersV1Offers()
            => Sender.Request<LolPersonalizedOffersUIOffer[]>("get", $"/lol-personalized-offers/v1/offers");
        public static Task<LolPersonalizedOffersPurchaseResponse> PostLolPersonalizedOffersV1OffersPurchase([Parameter("offerRequests", "body")] LolPersonalizedOffersOfferRequests offerRequests)
            => Sender.Request<LolPersonalizedOffersPurchaseResponse>("post", $"/lol-personalized-offers/v1/offers/purchase", offerRequests);
        public static Task<LolPersonalizedOffersUIOffer[]> PostLolPersonalizedOffersV1OffersReveal([Parameter("offerIds", "body")] LolPersonalizedOffersOfferIds offerIds)
            => Sender.Request<LolPersonalizedOffersUIOffer[]>("post", $"/lol-personalized-offers/v1/offers/reveal", offerIds);
        public static Task<LolPersonalizedOffersPurchaseResponse> PostLolPersonalizedOffersV1OffersByIdPurchase([Parameter("id", "path")] string id)
            => Sender.Request<LolPersonalizedOffersPurchaseResponse>("post", $"/lol-personalized-offers/v1/offers/{id}/purchase");
        public static Task<LolPersonalizedOffersUIOffer[]> PostLolPersonalizedOffersV1OffersByIdReveal([Parameter("id", "path")] string id)
            => Sender.Request<LolPersonalizedOffersUIOffer[]>("post", $"/lol-personalized-offers/v1/offers/{id}/reveal");
        public static Task<LolPersonalizedOffersUIStatus> GetLolPersonalizedOffersV1Status()
            => Sender.Request<LolPersonalizedOffersUIStatus>("get", $"/lol-personalized-offers/v1/status");
        public static Task<bool> GetLolPersonalizedOffersV1Themed()
            => Sender.Request<bool>("get", $"/lol-personalized-offers/v1/themed");
    }
}

using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolRecommendations
    {
        public static Task<LolRecommendationsRecommendationsCollection> GetLolRecommendationsV1Recommendations([Parameter("numberOfRecommendations", "query")] int numberOfRecommendations)
            => Sender.Request<LolRecommendationsRecommendationsCollection>("get", $"/lol-recommendations/v1/recommendations?numberOfRecommendations={System.Net.WebUtility.UrlEncode(numberOfRecommendations.ToString())}");
    }
}

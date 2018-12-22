using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolRecommendations
    {
        public static Task<LolRecommendationsRecommendationsCollection> GetLolRecommendationsV1Recommendations([Parameter("numberOfRecommendations", "query")] int numberOfRecommendations = default)
            => Sender.Request<LolRecommendationsRecommendationsCollection>("get", $"/lol-recommendations/v1/recommendations?{(numberOfRecommendations != default ? $"numberOfRecommendations={System.Net.WebUtility.UrlEncode(numberOfRecommendations.ToString())}" : null)}");
    }
}

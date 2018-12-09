using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolSuggestedPlayers
    {
        public static Task PostLolSuggestedPlayersV1ReportedPlayer([Parameter("resource", "body")] LolSuggestedPlayersSuggestedPlayersReportedPlayer resource)
            => Sender.Request("post", $"/lol-suggested-players/v1/reported-player", resource);
        public static Task<LolSuggestedPlayersSuggestedPlayersSuggestedPlayer[]> GetLolSuggestedPlayersV1SuggestedPlayers()
            => Sender.Request<LolSuggestedPlayersSuggestedPlayersSuggestedPlayer[]>("get", $"/lol-suggested-players/v1/suggested-players");
        public static Task<object> DeleteLolSuggestedPlayersV1SuggestedPlayersBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("delete", $"/lol-suggested-players/v1/suggested-players/{summonerId}");
        public static Task PostLolSuggestedPlayersV1VictoriousComrade([Parameter("resource", "body")] LolSuggestedPlayersSuggestedPlayersVictoriousComrade resource)
            => Sender.Request("post", $"/lol-suggested-players/v1/victorious-comrade", resource);
    }
}

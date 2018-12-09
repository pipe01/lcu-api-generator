using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolEndOfGame
    {
        public static Task<LolEndOfGameChampionMasteryUpdate> GetLolEndOfGameV1ChampionMasteryUpdates()
            => Sender.Request<LolEndOfGameChampionMasteryUpdate>("get", $"/lol-end-of-game/v1/champion-mastery-updates");
        public static Task<LolEndOfGameEndOfGameStats> GetLolEndOfGameV1EogStatsBlock()
            => Sender.Request<LolEndOfGameEndOfGameStats>("get", $"/lol-end-of-game/v1/eog-stats-block");
        public static Task<long[]> GetLolEndOfGameV1ReportedPlayers()
            => Sender.Request<long[]>("get", $"/lol-end-of-game/v1/reported-players");
        public static Task<object> PostLolEndOfGameV1StateDismissStats()
            => Sender.Request<object>("post", $"/lol-end-of-game/v1/state/dismiss-stats");
        public static Task<LolEndOfGameEndOfGamePlayerComplaintV2> PostLolEndOfGameV2PlayerComplaints([Parameter("complaint", "body")] LolEndOfGameEndOfGamePlayerComplaintV2 complaint)
            => Sender.Request<LolEndOfGameEndOfGamePlayerComplaintV2>("post", $"/lol-end-of-game/v2/player-complaints", complaint);
    }
}

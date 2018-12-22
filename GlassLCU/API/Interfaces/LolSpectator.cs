using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolSpectator
    {
        public static Task<LolSpectatorSummonerOrTeamAvailabilty> PostLolSpectatorV1BuddySpectate([Parameter("summonerOrTeamNames", "body")] string[] summonerOrTeamNames)
            => Sender.Request<LolSpectatorSummonerOrTeamAvailabilty>("post", $"/lol-spectator/v1/buddy/spectate", summonerOrTeamNames);
        public static Task<LolSpectatorSpectateGameInfo> GetLolSpectatorV1Spectate()
            => Sender.Request<LolSpectatorSpectateGameInfo>("get", $"/lol-spectator/v1/spectate");
        public static Task<object> PostLolSpectatorV1SpectateLaunch([Parameter("spectateGameInfo", "body")] LolSpectatorSpectateGameInfo spectateGameInfo)
            => Sender.Request<object>("post", $"/lol-spectator/v1/spectate/launch", spectateGameInfo);
    }
}

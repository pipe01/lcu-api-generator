using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolMaps
    {
        public static Task PostLolMapsV1Map([Parameter("map", "body")] LolMapsMaps map)
            => Sender.Request("post", $"/lol-maps/v1/map", map);
        public static Task<LolMapsMaps> GetLolMapsV1MapById([Parameter("id", "path")] long id)
            => Sender.Request<LolMapsMaps>("get", $"/lol-maps/v1/map/{id}");
        public static Task<LolMapsMaps[]> GetLolMapsV1Maps()
            => Sender.Request<LolMapsMaps[]>("get", $"/lol-maps/v1/maps");
        public static Task<LolMapsMaps> GetLolMapsV2MapByIdByGameMode([Parameter("id", "path")] long id, [Parameter("gameMode", "path")] string gameMode)
            => Sender.Request<LolMapsMaps>("get", $"/lol-maps/v2/map/{id}/{gameMode}");
        public static Task<LolMapsMaps> GetLolMapsV2MapByIdByGameModeByGameMutator([Parameter("id", "path")] long id, [Parameter("gameMode", "path")] string gameMode, [Parameter("gameMutator", "path")] string gameMutator)
            => Sender.Request<LolMapsMaps>("get", $"/lol-maps/v2/map/{id}/{gameMode}/{gameMutator}");
        public static Task<LolMapsMaps[]> GetLolMapsV2Maps()
            => Sender.Request<LolMapsMaps[]>("get", $"/lol-maps/v2/maps");
    }
}

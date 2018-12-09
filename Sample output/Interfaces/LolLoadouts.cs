using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolLoadouts
    {
        public static Task<LolLoadoutsScopedLoadout> PostLolLoadoutsV4Loadouts([Parameter("loadout", "body")] LolLoadoutsCreateLoadoutDTO loadout)
            => Sender.Request<LolLoadoutsScopedLoadout>("post", $"/lol-loadouts/v4/loadouts", loadout);
        public static Task<LolLoadoutsScopedLoadout[]> GetLolLoadoutsV4LoadoutsScopeAccount()
            => Sender.Request<LolLoadoutsScopedLoadout[]>("get", $"/lol-loadouts/v4/loadouts/scope/account");
        public static Task<LolLoadoutsScopedLoadout[]> GetLolLoadoutsV4LoadoutsScopeByScopeByScopeItemId([Parameter("scope", "path")] string scope, [Parameter("scopeItemId", "path")] int scopeItemId)
            => Sender.Request<LolLoadoutsScopedLoadout[]>("get", $"/lol-loadouts/v4/loadouts/scope/{scope}/{scopeItemId}");
        public static Task DeleteLolLoadoutsV4LoadoutsById([Parameter("id", "path")] string id)
            => Sender.Request("delete", $"/lol-loadouts/v4/loadouts/{id}");
        public static Task<LolLoadoutsScopedLoadout> PatchLolLoadoutsV4LoadoutsById([Parameter("id", "path")] string id, [Parameter("loadout", "body")] LolLoadoutsUpdateLoadoutDTO loadout)
            => Sender.Request<LolLoadoutsScopedLoadout>("patch", $"/lol-loadouts/v4/loadouts/{id}", loadout);
        public static Task<LolLoadoutsScopedLoadout> PutLolLoadoutsV4LoadoutsById([Parameter("id", "path")] string id, [Parameter("loadout", "body")] LolLoadoutsUpdateLoadoutDTO loadout)
            => Sender.Request<LolLoadoutsScopedLoadout>("put", $"/lol-loadouts/v4/loadouts/{id}", loadout);
        public static Task<LolLoadoutsScopedLoadout> GetLolLoadoutsV4LoadoutsByLoadoutId([Parameter("loadoutId", "path")] string loadoutId)
            => Sender.Request<LolLoadoutsScopedLoadout>("get", $"/lol-loadouts/v4/loadouts/{loadoutId}");
    }
}

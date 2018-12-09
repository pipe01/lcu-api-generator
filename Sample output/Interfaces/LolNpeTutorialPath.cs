using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolNpeTutorialPath
    {
        public static Task<LolNpeTutorialPathAccountSettingsHowToWinStats> GetLolNpeTutorialPathV1HowToWinStats()
            => Sender.Request<LolNpeTutorialPathAccountSettingsHowToWinStats>("get", $"/lol-npe-tutorial-path/v1/how-to-win-stats");
        public static Task<object> PostLolNpeTutorialPathV1HowToWinStatsMarkAsSeen()
            => Sender.Request<object>("post", $"/lol-npe-tutorial-path/v1/how-to-win-stats/mark-as-seen");
        public static Task<LolNpeTutorialPathCollectionsChampion> GetLolNpeTutorialPathV1RewardsChamp()
            => Sender.Request<LolNpeTutorialPathCollectionsChampion>("get", $"/lol-npe-tutorial-path/v1/rewards/champ");
        public static Task<LolNpeTutorialPathAccountSettingsTutorial> GetLolNpeTutorialPathV1Settings()
            => Sender.Request<LolNpeTutorialPathAccountSettingsTutorial>("get", $"/lol-npe-tutorial-path/v1/settings");
        public static Task PatchLolNpeTutorialPathV1Settings([Parameter("settings", "body")] LolNpeTutorialPathAccountSettingsTutorial settings)
            => Sender.Request("patch", $"/lol-npe-tutorial-path/v1/settings", settings);
        public static Task<LolNpeTutorialPathTutorial[]> GetLolNpeTutorialPathV1Tutorials()
            => Sender.Request<LolNpeTutorialPathTutorial[]>("get", $"/lol-npe-tutorial-path/v1/tutorials");
        public static Task PatchLolNpeTutorialPathV1TutorialsInit()
            => Sender.Request("patch", $"/lol-npe-tutorial-path/v1/tutorials/init");
        public static Task PutLolNpeTutorialPathV1TutorialsByTutorialIdView([Parameter("tutorialId", "path")] string tutorialId)
            => Sender.Request("put", $"/lol-npe-tutorial-path/v1/tutorials/{tutorialId}/view");
    }
}

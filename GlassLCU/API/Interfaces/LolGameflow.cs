using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolGameflow
    {
        public static Task PostLolGameflowV1AckFailedToLaunch()
            => Sender.Request("post", $"/lol-gameflow/v1/ack-failed-to-launch");
        public static Task<bool> GetLolGameflowV1ActivePatcherLock()
            => Sender.Request<bool>("get", $"/lol-gameflow/v1/active-patcher-lock");
        public static Task<LolGameflowGameflowAvailability> GetLolGameflowV1Availability()
            => Sender.Request<LolGameflowGameflowAvailability>("get", $"/lol-gameflow/v1/availability");
        public static Task<bool> GetLolGameflowV1BasicTutorial()
            => Sender.Request<bool>("get", $"/lol-gameflow/v1/basic-tutorial");
        public static Task<object> PostLolGameflowV1BasicTutorialStart()
            => Sender.Request<object>("post", $"/lol-gameflow/v1/basic-tutorial/start");
        public static Task<bool> GetLolGameflowV1BattleTraining()
            => Sender.Request<bool>("get", $"/lol-gameflow/v1/battle-training");
        public static Task<object> PostLolGameflowV1BattleTrainingStart()
            => Sender.Request<object>("post", $"/lol-gameflow/v1/battle-training/start");
        public static Task<object> PostLolGameflowV1BattleTrainingStop()
            => Sender.Request<object>("post", $"/lol-gameflow/v1/battle-training/stop");
        public static Task PostLolGameflowV1ClientReceivedMessage([Parameter("messsage", "body")] string messsage)
            => Sender.Request("post", $"/lol-gameflow/v1/client-received-message", messsage);
        public static Task<string[]> GetLolGameflowV1ExtraGameClientArgs()
            => Sender.Request<string[]>("get", $"/lol-gameflow/v1/extra-game-client-args");
        public static Task PostLolGameflowV1ExtraGameClientArgs([Parameter("extraGameClientArgs", "body")] string[] extraGameClientArgs)
            => Sender.Request("post", $"/lol-gameflow/v1/extra-game-client-args", extraGameClientArgs);
        public static Task<LolGameflowPlayerStatus> GetLolGameflowV1GameflowMetadataPlayerStatus()
            => Sender.Request<LolGameflowPlayerStatus>("get", $"/lol-gameflow/v1/gameflow-metadata/player-status");
        public static Task PostLolGameflowV1GameflowMetadataPlayerStatus([Parameter("playerStatus", "body")] LolGameflowPlayerStatus playerStatus)
            => Sender.Request("post", $"/lol-gameflow/v1/gameflow-metadata/player-status", playerStatus);
        public static Task<LolGameflowRegistrationStatus> GetLolGameflowV1GameflowMetadataRegistrationStatus()
            => Sender.Request<LolGameflowRegistrationStatus>("get", $"/lol-gameflow/v1/gameflow-metadata/registration-status");
        public static Task PostLolGameflowV1GameflowMetadataRegistrationStatus([Parameter("registrationStatus", "body")] LolGameflowRegistrationStatus registrationStatus)
            => Sender.Request("post", $"/lol-gameflow/v1/gameflow-metadata/registration-status", registrationStatus);
        public static Task<LolGameflowGameflowPhase> GetLolGameflowV1GameflowPhase()
            => Sender.Request<LolGameflowGameflowPhase>("get", $"/lol-gameflow/v1/gameflow-phase");
        public static Task PostLolGameflowV1PreEndGameTransition([Parameter("enabled", "query")] bool enabled)
            => Sender.Request("post", $"/lol-gameflow/v1/pre-end-game-transition?enabled={System.Net.WebUtility.UrlEncode(enabled.ToString())}");
        public static Task<object> PostLolGameflowV1Reconnect()
            => Sender.Request<object>("post", $"/lol-gameflow/v1/reconnect");
        public static Task<LolGameflowGameflowSession> GetLolGameflowV1Session()
            => Sender.Request<LolGameflowGameflowSession>("get", $"/lol-gameflow/v1/session");
        public static Task PostLolGameflowV1SessionDodge([Parameter("dodgeData", "body")] LolGameflowGameflowGameDodge dodgeData)
            => Sender.Request("post", $"/lol-gameflow/v1/session/dodge", dodgeData);
        public static Task PostLolGameflowV1SessionEvent([Parameter("session", "body")] string session)
            => Sender.Request("post", $"/lol-gameflow/v1/session/event", session);
        public static Task PostLolGameflowV1SessionGameConfiguration([Parameter("queue", "body")] LolGameflowQueue queue)
            => Sender.Request("post", $"/lol-gameflow/v1/session/game-configuration", queue);
        public static Task<bool> PostLolGameflowV1SessionRequestEnterGameflow([Parameter("eventType", "body")] string eventType)
            => Sender.Request<bool>("post", $"/lol-gameflow/v1/session/request-enter-gameflow", eventType);
        public static Task<bool> PostLolGameflowV1SessionRequestLobby()
            => Sender.Request<bool>("post", $"/lol-gameflow/v1/session/request-lobby");
        public static Task<bool> PostLolGameflowV1SessionRequestTournamentCheckin()
            => Sender.Request<bool>("post", $"/lol-gameflow/v1/session/request-tournament-checkin");
        public static Task PostLolGameflowV1SessionTournamentEnded()
            => Sender.Request("post", $"/lol-gameflow/v1/session/tournament-ended");
        public static Task<bool> GetLolGameflowV1Spectate()
            => Sender.Request<bool>("get", $"/lol-gameflow/v1/spectate");
        public static Task GetLolGameflowV1SpectateDelayedLaunch()
            => Sender.Request("get", $"/lol-gameflow/v1/spectate/delayed-launch");
        public static Task<object> PostLolGameflowV1SpectateLaunch([Parameter("summonerName", "body")] string summonerName = default)
            => Sender.Request<object>("post", $"/lol-gameflow/v1/spectate/launch", summonerName);
        public static Task<object> PostLolGameflowV1SpectateQuit()
            => Sender.Request<object>("post", $"/lol-gameflow/v1/spectate/quit");
        public static Task PostLolGameflowV1Tick()
            => Sender.Request("post", $"/lol-gameflow/v1/tick");
        public static Task<LolGameflowGameflowWatchPhase> GetLolGameflowV1Watch()
            => Sender.Request<LolGameflowGameflowWatchPhase>("get", $"/lol-gameflow/v1/watch");
        public static Task<object> PostLolGameflowV1WatchLaunch([Parameter("args", "body")] string[] args)
            => Sender.Request<object>("post", $"/lol-gameflow/v1/watch/launch", args);
    }
}

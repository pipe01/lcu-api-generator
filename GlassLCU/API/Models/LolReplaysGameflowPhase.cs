using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolReplaysGameflowPhase
    {
        None,
        Lobby,
        Matchmaking,
        CheckedIntoTournament,
        ReadyCheck,
        ChampSelect,
        GameStart,
        FailedToLaunch,
        InProgress,
        Reconnect,
        WaitingForStats,
        PreEndOfGame,
        EndOfGame,
        TerminatedInError,
    }
}

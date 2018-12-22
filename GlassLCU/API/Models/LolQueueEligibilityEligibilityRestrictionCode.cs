using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolQueueEligibilityEligibilityRestrictionCode
    {
        QueueDisabled,
        QueueUnsupported,
        PlayerLevelRestriction,
        PlayerTimedRestriction,
        PlayerBannedRestriction,
        PlayerAvailableChampionRestriction,
        TeamDivisionRestriction,
        TeamMaxSizeRestriction,
        TeamMinSizeRestriction,
        PlayerBingeRestriction,
        PlayerDodgeRestriction,
        PlayerInGameRestriction,
        PlayerLeaverBustedRestriction,
        PlayerLeaverTaintedWarningRestriction,
        PlayerMaxLevelRestriction,
        PlayerMinLevelRestriction,
        PlayerMinorRestriction,
        PlayerTimePlayedRestriction,
        PlayerRankedSuspensionRestriction,
        TeamHighMMRMaxSizeRestriction,
        TeamSizeRestriction,
        PrerequisiteQueuesNotPlayedRestriction,
        UnknownRestriction,
        BanInfoNotAvailable,
        MinorInfoNotAvailable,
        SummonerInfoNotAvailable,
        LeaguesInfoNotAvailable,
        InventoryChampsInfoNotAvailable,
        InventoryQueuesInfoNotAvailable,
    }
}

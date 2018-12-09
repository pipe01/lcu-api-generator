using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolLobbyEligibilityRestrictionCode
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
        QueueEntryNotEntitledRestriction,
        UnknownRestriction,
        BanInfoNotAvailable,
        MinorInfoNotAvailable,
        SummonerInfoNotAvailable,
        LeaguesInfoNotAvailable,
        InventoryChampsInfoNotAvailable,
        InventoryQueuesInfoNotAvailable,
    }
}
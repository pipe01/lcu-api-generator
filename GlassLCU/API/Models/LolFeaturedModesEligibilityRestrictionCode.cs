using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolFeaturedModesEligibilityRestrictionCode
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
        PlayerRankedSuspensionRestriction,
        TeamHighMMRMaxSizeRestriction,
        TeamSizeRestriction,
        PrerequisiteQueuesNotPlayedRestriction,
        QueueEntryNotEntitledRestriction,
        UnknownRestriction,
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterWithdraw
    {
        [JsonProperty("declineWithdrawMembers")]
        public long[] DeclineWithdrawMembers { get; set; }
        [JsonProperty("gameStartBufferMs")]
        public long GameStartBufferMs { get; set; }
        [JsonProperty("initVoteMember")]
        public long InitVoteMember { get; set; }
        [JsonProperty("initVoteTime")]
        public long InitVoteTime { get; set; }
        [JsonProperty("lockoutTimeMs")]
        public long LockoutTimeMs { get; set; }
        [JsonProperty("voteTimeoutMs")]
        public long VoteTimeoutMs { get; set; }
        [JsonProperty("voteWithdrawMembers")]
        public long[] VoteWithdrawMembers { get; set; }
    }
}

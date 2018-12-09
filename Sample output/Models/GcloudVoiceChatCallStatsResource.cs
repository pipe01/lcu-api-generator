using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GcloudVoiceChatCallStatsResource
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }
        [JsonProperty("captureDeviceConsecutivelyReadCount")]
        public long[] CaptureDeviceConsecutivelyReadCount { get; set; }
        [JsonProperty("codecName")]
        public string CodecName { get; set; }
        [JsonProperty("currentBars")]
        public long CurrentBars { get; set; }
        [JsonProperty("currentOpusBandwidth")]
        public long CurrentOpusBandwidth { get; set; }
        [JsonProperty("currentOpusBitRate")]
        public long CurrentOpusBitRate { get; set; }
        [JsonProperty("currentOpusComplexity")]
        public long CurrentOpusComplexity { get; set; }
        [JsonProperty("currentOpusMaxPacketSize")]
        public long CurrentOpusMaxPacketSize { get; set; }
        [JsonProperty("currentOpusVbrMode")]
        public long CurrentOpusVbrMode { get; set; }
        [JsonProperty("incomingDiscarded")]
        public long IncomingDiscarded { get; set; }
        [JsonProperty("incomingOutOfTime")]
        public long IncomingOutOfTime { get; set; }
        [JsonProperty("incomingPacketloss")]
        public long IncomingPacketloss { get; set; }
        [JsonProperty("incomingReceived")]
        public long IncomingReceived { get; set; }
        [JsonProperty("lastLatencyMeasured")]
        public float LastLatencyMeasured { get; set; }
        [JsonProperty("latencyMeasurementCount")]
        public long LatencyMeasurementCount { get; set; }
        [JsonProperty("latencyPacketsDropped")]
        public long LatencyPacketsDropped { get; set; }
        [JsonProperty("latencyPacketsLost")]
        public long LatencyPacketsLost { get; set; }
        [JsonProperty("latencyPacketsMalformed")]
        public long LatencyPacketsMalformed { get; set; }
        [JsonProperty("latencyPacketsNegativeLatency")]
        public long LatencyPacketsNegativeLatency { get; set; }
        [JsonProperty("latencyPacketsSent")]
        public long LatencyPacketsSent { get; set; }
        [JsonProperty("latencySum")]
        public float LatencySum { get; set; }
        [JsonProperty("maxLatency")]
        public float MaxLatency { get; set; }
        [JsonProperty("minLatency")]
        public float MinLatency { get; set; }
        [JsonProperty("outgoingSent")]
        public long OutgoingSent { get; set; }
        [JsonProperty("plcOn")]
        public long PlcOn { get; set; }
        [JsonProperty("plcSyntheticFrames")]
        public long PlcSyntheticFrames { get; set; }
        [JsonProperty("rFactor")]
        public float RFactor { get; set; }
        [JsonProperty("renderDeviceErrors")]
        public long RenderDeviceErrors { get; set; }
        [JsonProperty("renderDeviceOverruns")]
        public long RenderDeviceOverruns { get; set; }
        [JsonProperty("renderDeviceUnderruns")]
        public long RenderDeviceUnderruns { get; set; }
        [JsonProperty("sampleIntervalBegin")]
        public float SampleIntervalBegin { get; set; }
        [JsonProperty("sampleIntervalEnd")]
        public float SampleIntervalEnd { get; set; }
    }
}

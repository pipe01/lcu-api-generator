using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class VoiceChat
    {
        public static Task<VoiceChatAudioPropertiesResource> GetVoiceChatV1AudioProperties()
            => Sender.Request<VoiceChatAudioPropertiesResource>("get", $"/voice-chat/v1/audio-properties");
        public static Task<VoiceChatCallStatsResource> GetVoiceChatV1CallStatsAggregate()
            => Sender.Request<VoiceChatCallStatsResource>("get", $"/voice-chat/v1/call-stats/aggregate");
        public static Task<VoiceChatCallStatsResource[]> GetVoiceChatV1CallStatsById([Parameter("id", "path")] string id)
            => Sender.Request<VoiceChatCallStatsResource[]>("get", $"/voice-chat/v1/call-stats/{id}");
        public static Task<VoiceChatCodecSettingsResource> GetVoiceChatV1CodecSettings()
            => Sender.Request<VoiceChatCodecSettingsResource>("get", $"/voice-chat/v1/codec-settings");
        public static Task PutVoiceChatV1CodecSettings([Parameter("settings", "body")] VoiceChatUpdateCodecSettingsResource settings)
            => Sender.Request("put", $"/voice-chat/v1/codec-settings", settings);
        public static Task<VoiceChatConfigResource> GetVoiceChatV1Config()
            => Sender.Request<VoiceChatConfigResource>("get", $"/voice-chat/v1/config");
        public static Task<VoiceChatVoiceErrorCounterResource[]> GetVoiceChatV1Errors()
            => Sender.Request<VoiceChatVoiceErrorCounterResource[]>("get", $"/voice-chat/v1/errors");
        public static Task<VoiceChatPushToTalkResource> GetVoiceChatV1PushToTalk()
            => Sender.Request<VoiceChatPushToTalkResource>("get", $"/voice-chat/v1/push-to-talk");
        public static Task<object> PutVoiceChatV1PushToTalk([Parameter("pushToTalk", "body")] VoiceChatPushToTalkResource pushToTalk)
            => Sender.Request<object>("put", $"/voice-chat/v1/push-to-talk", pushToTalk);
        public static Task<bool> PostVoiceChatV1PushToTalkCheckAvailable([Parameter("prompt", "body")] int prompt)
            => Sender.Request<bool>("post", $"/voice-chat/v1/push-to-talk/check-available", prompt);
        public static Task<VoiceChatSessionResource> PostVoiceChatV1SessionsById([Parameter("id", "path")] string id)
            => Sender.Request<VoiceChatSessionResource>("post", $"/voice-chat/v1/sessions/{id}");
        public static Task<VoiceChatDeviceResource[]> GetVoiceChatV2DevicesCapture()
            => Sender.Request<VoiceChatDeviceResource[]>("get", $"/voice-chat/v2/devices/capture");
        public static Task<VoiceChatCaptureDevicePermissionStatus> GetVoiceChatV2DevicesCapturePermission()
            => Sender.Request<VoiceChatCaptureDevicePermissionStatus>("get", $"/voice-chat/v2/devices/capture/permission");
        public static Task PutVoiceChatV2DevicesCapturePromptForPermission()
            => Sender.Request("put", $"/voice-chat/v2/devices/capture/prompt-for-permission");
        public static Task<VoiceChatDeviceResource[]> GetVoiceChatV2DevicesRender()
            => Sender.Request<VoiceChatDeviceResource[]>("get", $"/voice-chat/v2/devices/render");
        public static Task DeleteVoiceChatV2Sessions()
            => Sender.Request("delete", $"/voice-chat/v2/sessions");
        public static Task<VoiceChatSessionResource[]> GetVoiceChatV2Sessions()
            => Sender.Request<VoiceChatSessionResource[]>("get", $"/voice-chat/v2/sessions");
        public static Task<VoiceChatSessionResource> PostVoiceChatV2Sessions([Parameter("JWT", "header")] string JWT)
            => Sender.Request<VoiceChatSessionResource>("post", $"/voice-chat/v2/sessions");
        public static Task DeleteVoiceChatV2SessionsById([Parameter("id", "path")] string id)
            => Sender.Request("delete", $"/voice-chat/v2/sessions/{id}");
        public static Task<VoiceChatSessionResource> GetVoiceChatV2SessionsById([Parameter("id", "path")] string id)
            => Sender.Request<VoiceChatSessionResource>("get", $"/voice-chat/v2/sessions/{id}");
        public static Task<VoiceChatSessionResource> PostVoiceChatV2SessionsById([Parameter("id", "path")] string id, [Parameter("JWT", "header")] string JWT)
            => Sender.Request<VoiceChatSessionResource>("post", $"/voice-chat/v2/sessions/{id}");
        public static Task<VoiceChatParticipantResource> GetVoiceChatV2SessionsBySessionIdParticipantsByParticipantId([Parameter("sessionId", "path")] string sessionId, [Parameter("participantId", "path")] string participantId)
            => Sender.Request<VoiceChatParticipantResource>("get", $"/voice-chat/v2/sessions/{sessionId}/participants/{participantId}");
        public static Task PutVoiceChatV2SessionsBySessionIdParticipantsByParticipantId([Parameter("sessionId", "path")] string sessionId, [Parameter("participantId", "path")] string participantId, [Parameter("participant", "body")] VoiceChatUpdateParticipantResource participant)
            => Sender.Request("put", $"/voice-chat/v2/sessions/{sessionId}/participants/{participantId}", participant);
        public static Task<VoiceChatSettingsResource> GetVoiceChatV2Settings()
            => Sender.Request<VoiceChatSettingsResource>("get", $"/voice-chat/v2/settings");
        public static Task PutVoiceChatV2Settings([Parameter("settings", "body")] VoiceChatUpdateSettingsResource settings)
            => Sender.Request("put", $"/voice-chat/v2/settings", settings);
        public static Task<VoiceChatStateResource> GetVoiceChatV2State()
            => Sender.Request<VoiceChatStateResource>("get", $"/voice-chat/v2/state");
    }
}

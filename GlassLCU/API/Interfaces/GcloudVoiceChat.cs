using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class GcloudVoiceChat
    {
        public static Task<GcloudVoiceChatAudioPropertiesResource> GetGcloudVoiceChatV1AudioProperties()
            => Sender.Request<GcloudVoiceChatAudioPropertiesResource>("get", $"/gcloud-voice-chat/v1/audio-properties");
        public static Task<GcloudVoiceChatCallStatsResource> GetGcloudVoiceChatV1CallStatsAggregate()
            => Sender.Request<GcloudVoiceChatCallStatsResource>("get", $"/gcloud-voice-chat/v1/call-stats/aggregate");
        public static Task<GcloudVoiceChatCallStatsResource[]> GetGcloudVoiceChatV1CallStatsById([Parameter("id", "path")] string id)
            => Sender.Request<GcloudVoiceChatCallStatsResource[]>("get", $"/gcloud-voice-chat/v1/call-stats/{id}");
        public static Task<GcloudVoiceChatCodecSettingsResource> GetGcloudVoiceChatV1CodecSettings()
            => Sender.Request<GcloudVoiceChatCodecSettingsResource>("get", $"/gcloud-voice-chat/v1/codec-settings");
        public static Task PutGcloudVoiceChatV1CodecSettings([Parameter("settings", "body")] GcloudVoiceChatUpdateCodecSettingsResource settings)
            => Sender.Request("put", $"/gcloud-voice-chat/v1/codec-settings", settings);
        public static Task<GcloudVoiceChatConfigResource> GetGcloudVoiceChatV1Config()
            => Sender.Request<GcloudVoiceChatConfigResource>("get", $"/gcloud-voice-chat/v1/config");
        public static Task<GcloudVoiceChatVoiceErrorCounterResource[]> GetGcloudVoiceChatV1Errors()
            => Sender.Request<GcloudVoiceChatVoiceErrorCounterResource[]>("get", $"/gcloud-voice-chat/v1/errors");
        public static Task<GcloudVoiceChatPushToTalkResource> GetGcloudVoiceChatV1PushToTalk()
            => Sender.Request<GcloudVoiceChatPushToTalkResource>("get", $"/gcloud-voice-chat/v1/push-to-talk");
        public static Task<object> PutGcloudVoiceChatV1PushToTalk([Parameter("pushToTalk", "body")] GcloudVoiceChatPushToTalkResource pushToTalk)
            => Sender.Request<object>("put", $"/gcloud-voice-chat/v1/push-to-talk", pushToTalk);
        public static Task<bool> PostGcloudVoiceChatV1PushToTalkCheckAvailable([Parameter("prompt", "body")] int prompt)
            => Sender.Request<bool>("post", $"/gcloud-voice-chat/v1/push-to-talk/check-available", prompt);
        public static Task<GcloudVoiceChatSessionResource> PostGcloudVoiceChatV1SessionsById([Parameter("id", "path")] string id)
            => Sender.Request<GcloudVoiceChatSessionResource>("post", $"/gcloud-voice-chat/v1/sessions/{id}");
        public static Task<GcloudVoiceChatDeviceResource[]> GetGcloudVoiceChatV2DevicesCapture()
            => Sender.Request<GcloudVoiceChatDeviceResource[]>("get", $"/gcloud-voice-chat/v2/devices/capture");
        public static Task<string> GetGcloudVoiceChatV2DevicesCapturePermission()
            => Sender.Request<string>("get", $"/gcloud-voice-chat/v2/devices/capture/permission");
        public static Task PutGcloudVoiceChatV2DevicesCapturePromptForPermission()
            => Sender.Request("put", $"/gcloud-voice-chat/v2/devices/capture/prompt-for-permission");
        public static Task<GcloudVoiceChatDeviceResource[]> GetGcloudVoiceChatV2DevicesRender()
            => Sender.Request<GcloudVoiceChatDeviceResource[]>("get", $"/gcloud-voice-chat/v2/devices/render");
        public static Task DeleteGcloudVoiceChatV2Sessions()
            => Sender.Request("delete", $"/gcloud-voice-chat/v2/sessions");
        public static Task<GcloudVoiceChatSessionResource[]> GetGcloudVoiceChatV2Sessions()
            => Sender.Request<GcloudVoiceChatSessionResource[]>("get", $"/gcloud-voice-chat/v2/sessions");
        public static Task<GcloudVoiceChatSessionResource> PostGcloudVoiceChatV2Sessions([Parameter("JWT", "header")] string JWT)
            => Sender.Request<GcloudVoiceChatSessionResource>("post", $"/gcloud-voice-chat/v2/sessions");
        public static Task DeleteGcloudVoiceChatV2SessionsById([Parameter("id", "path")] string id)
            => Sender.Request("delete", $"/gcloud-voice-chat/v2/sessions/{id}");
        public static Task<GcloudVoiceChatSessionResource> GetGcloudVoiceChatV2SessionsById([Parameter("id", "path")] string id)
            => Sender.Request<GcloudVoiceChatSessionResource>("get", $"/gcloud-voice-chat/v2/sessions/{id}");
        public static Task<GcloudVoiceChatSessionResource> PostGcloudVoiceChatV2SessionsById([Parameter("id", "path")] string id, [Parameter("JWT", "header")] string JWT)
            => Sender.Request<GcloudVoiceChatSessionResource>("post", $"/gcloud-voice-chat/v2/sessions/{id}");
        public static Task<GcloudVoiceChatParticipantResource> GetGcloudVoiceChatV2SessionsBySessionIdParticipantsByParticipantId([Parameter("sessionId", "path")] string sessionId, [Parameter("participantId", "path")] string participantId)
            => Sender.Request<GcloudVoiceChatParticipantResource>("get", $"/gcloud-voice-chat/v2/sessions/{sessionId}/participants/{participantId}");
        public static Task PutGcloudVoiceChatV2SessionsBySessionIdParticipantsByParticipantId([Parameter("sessionId", "path")] string sessionId, [Parameter("participantId", "path")] string participantId, [Parameter("participant", "body")] GcloudVoiceChatUpdateParticipantResource participant)
            => Sender.Request("put", $"/gcloud-voice-chat/v2/sessions/{sessionId}/participants/{participantId}", participant);
        public static Task<GcloudVoiceChatSettingsResource> GetGcloudVoiceChatV2Settings()
            => Sender.Request<GcloudVoiceChatSettingsResource>("get", $"/gcloud-voice-chat/v2/settings");
        public static Task PutGcloudVoiceChatV2Settings([Parameter("settings", "body")] GcloudVoiceChatUpdateSettingsResource settings)
            => Sender.Request("put", $"/gcloud-voice-chat/v2/settings", settings);
        public static Task<GcloudVoiceChatStateResource> GetGcloudVoiceChatV2State()
            => Sender.Request<GcloudVoiceChatStateResource>("get", $"/gcloud-voice-chat/v2/state");
    }
}

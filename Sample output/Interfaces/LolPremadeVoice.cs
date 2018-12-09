using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPremadeVoice
    {
        public static Task<LolPremadeVoiceVoiceAvailability> GetLolPremadeVoiceV1Availability()
            => Sender.Request<LolPremadeVoiceVoiceAvailability>("get", $"/lol-premade-voice/v1/availability");
        public static Task<LolPremadeVoiceDeviceResource[]> GetLolPremadeVoiceV1Capturedevices()
            => Sender.Request<LolPremadeVoiceDeviceResource[]>("get", $"/lol-premade-voice/v1/capturedevices");
        public static Task PutLolPremadeVoiceV1Capturedevices([Parameter("handle", "body")] string handle)
            => Sender.Request("put", $"/lol-premade-voice/v1/capturedevices", handle);
        public static Task<LolPremadeVoiceFirstExperience> GetLolPremadeVoiceV1FirstExperience()
            => Sender.Request<LolPremadeVoiceFirstExperience>("get", $"/lol-premade-voice/v1/first-experience");
        public static Task PostLolPremadeVoiceV1FirstExperienceGame()
            => Sender.Request("post", $"/lol-premade-voice/v1/first-experience/game");
        public static Task PostLolPremadeVoiceV1FirstExperienceLcu()
            => Sender.Request("post", $"/lol-premade-voice/v1/first-experience/lcu");
        public static Task PostLolPremadeVoiceV1FirstExperienceReset()
            => Sender.Request("post", $"/lol-premade-voice/v1/first-experience/reset");
        public static Task PostLolPremadeVoiceV1GameClientUpdatedPTTKey([Parameter("newKey", "body")] string newKey)
            => Sender.Request("post", $"/lol-premade-voice/v1/gameClientUpdatedPTTKey", newKey);
        public static Task<object> DeleteLolPremadeVoiceV1MicTest()
            => Sender.Request<object>("delete", $"/lol-premade-voice/v1/mic-test");
        public static Task<LolPremadeVoiceAudioPropertiesResource> GetLolPremadeVoiceV1MicTest()
            => Sender.Request<LolPremadeVoiceAudioPropertiesResource>("get", $"/lol-premade-voice/v1/mic-test");
        public static Task<object> PostLolPremadeVoiceV1MicTest()
            => Sender.Request<object>("post", $"/lol-premade-voice/v1/mic-test");
        public static Task<LolPremadeVoicePremadeVoiceParticipantDto[]> GetLolPremadeVoiceV1ParticipantRecords()
            => Sender.Request<LolPremadeVoicePremadeVoiceParticipantDto[]>("get", $"/lol-premade-voice/v1/participant-records");
        public static Task<LolPremadeVoicePremadeVoiceParticipantDto[]> GetLolPremadeVoiceV1Participants()
            => Sender.Request<LolPremadeVoicePremadeVoiceParticipantDto[]>("get", $"/lol-premade-voice/v1/participants");
        public static Task PutLolPremadeVoiceV1ParticipantsByPuuidMute([Parameter("puuid", "path")] string puuid, [Parameter("muted", "body")] int muted)
            => Sender.Request("put", $"/lol-premade-voice/v1/participants/{puuid}/mute", muted);
        public static Task PutLolPremadeVoiceV1ParticipantsByPuuidVolume([Parameter("puuid", "path")] string puuid, [Parameter("volume", "body")] int volume)
            => Sender.Request("put", $"/lol-premade-voice/v1/participants/{puuid}/volume", volume);
        public static Task<bool> PostLolPremadeVoiceV1PushToTalkCheckAvailable([Parameter("prompt", "body")] int prompt)
            => Sender.Request<bool>("post", $"/lol-premade-voice/v1/push-to-talk/check-available", prompt);
        public static Task PutLolPremadeVoiceV1SelfActivationSensitivity([Parameter("sensitivity", "body")] int sensitivity)
            => Sender.Request("put", $"/lol-premade-voice/v1/self/activationSensitivity", sensitivity);
        public static Task PutLolPremadeVoiceV1SelfInputMode([Parameter("inputMode", "body")] string inputMode)
            => Sender.Request("put", $"/lol-premade-voice/v1/self/inputMode", inputMode);
        public static Task PutLolPremadeVoiceV1SelfMicLevel([Parameter("micLevel", "body")] int micLevel)
            => Sender.Request("put", $"/lol-premade-voice/v1/self/micLevel", micLevel);
        public static Task PutLolPremadeVoiceV1SelfMute([Parameter("muted", "body")] int muted)
            => Sender.Request("put", $"/lol-premade-voice/v1/self/mute", muted);
        public static Task DeleteLolPremadeVoiceV1Session()
            => Sender.Request("delete", $"/lol-premade-voice/v1/session");
        public static Task PostLolPremadeVoiceV1Session()
            => Sender.Request("post", $"/lol-premade-voice/v1/session");
        public static Task<LolPremadeVoiceSettingsResource> GetLolPremadeVoiceV1Settings()
            => Sender.Request<LolPremadeVoiceSettingsResource>("get", $"/lol-premade-voice/v1/settings");
        public static Task PostLolPremadeVoiceV1SettingsReset()
            => Sender.Request("post", $"/lol-premade-voice/v1/settings/reset");
    }
}

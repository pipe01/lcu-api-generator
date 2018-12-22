using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum TracingModuleTypeV1
    {
        KUnknown,
        KRemoteAppModule,
        KBackEndPlugin,
        KBackendOther,
        KFrontEndPlugin,
        KRemotingSource,
    }
}

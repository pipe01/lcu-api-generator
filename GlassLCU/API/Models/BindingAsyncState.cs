using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum BindingAsyncState
    {
        None,
        Running,
        Cancelling,
        Cancelled,
        Succeeded,
        Failed,
    }
}

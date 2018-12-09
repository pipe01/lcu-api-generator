using Newtonsoft.Json;

namespace LCU_API_Generator
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

public interface ISender
{
    System.Threading.Tasks.Task<T> Request<T>(string method, string path, object body = null);
    System.Threading.Tasks.Task Request(string method, string path, object body = null);
}

internal static class GenerationUtils
{
    public static ISender Sender { get; set; }
}
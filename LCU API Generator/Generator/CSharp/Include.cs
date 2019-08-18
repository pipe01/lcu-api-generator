using System.Threading.Tasks;

public interface ISender
{
    Task<T> Request<T>(string method, string path, object body = null);
    Task Request(string method, string path, object body = null);
}

internal static class GenerationUtils
{
    public static ISender Sender { get; set; }
}
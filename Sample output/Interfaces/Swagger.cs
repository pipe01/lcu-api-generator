using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Swagger
    {
        /// <summary>
        /// Retrieves the API documentation resource listing
        /// </summary>
        public static Task<object> Http2ApiDocsV1()
            => Sender.Request<object>("get", $"/swagger/v1/api-docs");
        /// <summary>
        /// Retrieves the API declaration for a supported API
        /// </summary>
        /// <param name="api">API to get a declaration for</param>
        public static Task<object> Http2ApiDeclarationV1([Parameter("api", "path")] string api)
            => Sender.Request<object>("get", $"/swagger/v1/api-docs/{api}");
        /// <summary>
        /// Retrieves the API documentation
        /// </summary>
        public static Task<object> HttpApiDocsV2()
            => Sender.Request<object>("get", $"/swagger/v2/swagger.json");
        /// <summary>
        /// Retrieves the API documentation
        /// </summary>
        public static Task<object> Http2ApiDocsV3()
            => Sender.Request<object>("get", $"/swagger/v3/openapi.json");
    }
}

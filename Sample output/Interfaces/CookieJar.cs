using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class CookieJar
    {
        /// <summary>
        /// Get all cookies.
        /// </summary>
        public static Task<cookie[]> GetCookieJarV1Cookies()
            => Sender.Request<cookie[]>("get", $"/cookie-jar/v1/cookies");
        /// <summary>
        /// Set a cookie.
        /// </summary>
        /// <param name="cookie">Cookie to set</param>
        public static Task<object> PostCookieJarV1Cookies([Parameter("cookie", "body")] cookie[] cookie)
            => Sender.Request<object>("post", $"/cookie-jar/v1/cookies", cookie);
    }
}
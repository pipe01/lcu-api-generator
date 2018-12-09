using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Recofriender
    {
        public static Task<RecofrienderConfig> GetRecofrienderV1Config()
            => Sender.Request<RecofrienderConfig>("get", $"/recofriender/v1/config");
        public static Task<RecofrienderNetworkConfig> GetRecofrienderV1ConfigByNetwork([Parameter("network", "path")] string network)
            => Sender.Request<RecofrienderNetworkConfig>("get", $"/recofriender/v1/config/{network}");
        public static Task<RecofrienderContactResource[]> GetRecofrienderV1Contacts([Parameter("accountId", "query")] long accountId, [Parameter("source", "query")] string source, [Parameter("friendState", "query")] string friendState)
            => Sender.Request<RecofrienderContactResource[]>("get", $"/recofriender/v1/contacts?accountId={System.Net.WebUtility.UrlEncode(accountId.ToString())}&source={System.Net.WebUtility.UrlEncode(source.ToString())}&friendState={System.Net.WebUtility.UrlEncode(friendState.ToString())}");
        public static Task<RecofrienderContactStateResource> PostRecofrienderV1ContactsByAccountIdAvailable([Parameter("accountId", "path")] long accountId, [Parameter("retainInCache", "query")] bool retainInCache)
            => Sender.Request<RecofrienderContactStateResource>("post", $"/recofriender/v1/contacts/{accountId}/available?retainInCache={System.Net.WebUtility.UrlEncode(retainInCache.ToString())}");
        public static Task<RecofrienderContactStateResource> PostRecofrienderV1ContactsByAccountIdDismissed([Parameter("accountId", "path")] long accountId, [Parameter("retainInCache", "query")] bool retainInCache)
            => Sender.Request<RecofrienderContactStateResource>("post", $"/recofriender/v1/contacts/{accountId}/dismissed?retainInCache={System.Net.WebUtility.UrlEncode(retainInCache.ToString())}");
        public static Task<RecofrienderContactStateResource> PostRecofrienderV1ContactsByAccountIdInvited([Parameter("accountId", "path")] long accountId, [Parameter("retainInCache", "query")] bool retainInCache)
            => Sender.Request<RecofrienderContactStateResource>("post", $"/recofriender/v1/contacts/{accountId}/invited?retainInCache={System.Net.WebUtility.UrlEncode(retainInCache.ToString())}");
        public static Task<RecofrienderDebugConfig> GetRecofrienderV1Debug()
            => Sender.Request<RecofrienderDebugConfig>("get", $"/recofriender/v1/debug");
        public static Task<RecofrienderDebugConfig> PutRecofrienderV1Debug([Parameter("debugConfiguration", "body")] RecofrienderDebugConfig debugConfiguration)
            => Sender.Request<RecofrienderDebugConfig>("put", $"/recofriender/v1/debug", debugConfiguration);
        public static Task<RecofrienderUrlResource> GetRecofrienderV1FaqUrl()
            => Sender.Request<RecofrienderUrlResource>("get", $"/recofriender/v1/faq-url");
        public static Task<RecofrienderLinkResource[]> GetRecofrienderV1Registrations([Parameter("cb", "query")] string cb)
            => Sender.Request<RecofrienderLinkResource[]>("get", $"/recofriender/v1/registrations?cb={System.Net.WebUtility.UrlEncode(cb.ToString())}");
        public static Task<object> DeleteRecofrienderV1RegistrationsByNetwork([Parameter("network", "path")] string network)
            => Sender.Request<object>("delete", $"/recofriender/v1/registrations/{network}");
        public static Task<RecofrienderLinkResource> GetRecofrienderV1RegistrationsByNetwork([Parameter("network", "path")] string network)
            => Sender.Request<RecofrienderLinkResource>("get", $"/recofriender/v1/registrations/{network}");
        public static Task<RecofrienderUrlResource> PostRecofrienderV1RegistrationsByNetwork([Parameter("network", "path")] string network)
            => Sender.Request<RecofrienderUrlResource>("post", $"/recofriender/v1/registrations/{network}");
        public static Task DeleteRecofrienderV2Contacts()
            => Sender.Request("delete", $"/recofriender/v2/contacts");
        public static Task<RecofrienderContactResource[]> GetRecofrienderV2Contacts()
            => Sender.Request<RecofrienderContactResource[]>("get", $"/recofriender/v2/contacts");
        public static Task<RecofrienderContactPaginationResource> GetRecofrienderV2ContactsPage([Parameter("start", "query")] long start, [Parameter("limit", "query")] long limit)
            => Sender.Request<RecofrienderContactPaginationResource>("get", $"/recofriender/v2/contacts/page?start={System.Net.WebUtility.UrlEncode(start.ToString())}&limit={System.Net.WebUtility.UrlEncode(limit.ToString())}");
        public static Task<RecofrienderContactResource> GetRecofrienderV2ContactsByAccountId([Parameter("accountId", "path")] long accountId)
            => Sender.Request<RecofrienderContactResource>("get", $"/recofriender/v2/contacts/{accountId}");
        public static Task DeleteRecofrienderV2Dismissed()
            => Sender.Request("delete", $"/recofriender/v2/dismissed");
        public static Task<RecofrienderContactResource[]> GetRecofrienderV2Dismissed()
            => Sender.Request<RecofrienderContactResource[]>("get", $"/recofriender/v2/dismissed");
        public static Task<RecofrienderContactPaginationResource> GetRecofrienderV2DismissedPage([Parameter("start", "query")] long start, [Parameter("limit", "query")] long limit)
            => Sender.Request<RecofrienderContactPaginationResource>("get", $"/recofriender/v2/dismissed/page?start={System.Net.WebUtility.UrlEncode(start.ToString())}&limit={System.Net.WebUtility.UrlEncode(limit.ToString())}");
    }
}

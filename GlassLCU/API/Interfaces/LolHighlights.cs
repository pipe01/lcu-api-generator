using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolHighlights
    {
        public static Task<LolHighlightsHighlightsConfig> GetLolHighlightsV1Config()
            => Sender.Request<LolHighlightsHighlightsConfig>("get", $"/lol-highlights/v1/config");
        public static Task<object> PostLolHighlightsV1FileBrowserByHighlightId([Parameter("highlightId", "path")] long highlightId)
            => Sender.Request<object>("post", $"/lol-highlights/v1/file-browser/{highlightId}");
        public static Task<LolHighlightsHighlight[]> GetLolHighlightsV1Highlights()
            => Sender.Request<LolHighlightsHighlight[]>("get", $"/lol-highlights/v1/highlights");
        public static Task<LolHighlightsHighlight[]> PostLolHighlightsV1Highlights()
            => Sender.Request<LolHighlightsHighlight[]>("post", $"/lol-highlights/v1/highlights");
        public static Task<string> GetLolHighlightsV1HighlightsFolderPath()
            => Sender.Request<string>("get", $"/lol-highlights/v1/highlights-folder-path");
        public static Task<string> GetLolHighlightsV1HighlightsFolderPathDefault()
            => Sender.Request<string>("get", $"/lol-highlights/v1/highlights-folder-path/default");
        public static Task<LolHighlightsHighlight> DeleteLolHighlightsV1HighlightsById([Parameter("id", "path")] long id)
            => Sender.Request<LolHighlightsHighlight>("delete", $"/lol-highlights/v1/highlights/{id}");
        public static Task<LolHighlightsHighlight> GetLolHighlightsV1HighlightsById([Parameter("id", "path")] long id)
            => Sender.Request<LolHighlightsHighlight>("get", $"/lol-highlights/v1/highlights/{id}");
        public static Task<LolHighlightsHighlight> PutLolHighlightsV1HighlightsById([Parameter("id", "path")] long id, [Parameter("highlight", "body")] LolHighlightsHighlight highlight)
            => Sender.Request<LolHighlightsHighlight>("put", $"/lol-highlights/v1/highlights/{id}", highlight);
    }
}

using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class Telemetry
    {
        /// <summary>
        /// Gets the millisecond UNIX timestamp of when the application was started.
        /// </summary>
        public static Task<long> GetTelemetryV1ApplicationStartTime()
            => Sender.Request<long>("get", $"/telemetry/v1/application-start-time");
        /// <summary>
        /// Adds/updates a common data key and value to be sent with every subsequent event.
        /// </summary>
        /// <param name="key">The name of the common data key</param>
        /// <param name="value">The value of the common data key</param>
        public static Task PostTelemetryV1CommonDataByKey([Parameter("key", "path")] string key, [Parameter("value", "body")] string value)
            => Sender.Request("post", $"/telemetry/v1/common-data/{key}", value);
        /// <summary>
        /// Adds a new event to be sent to Dradis and/or other analytics/monitoring data sinks. This will include current performance information along with the passed in data. Each call will record the performance counters then reset them for use in the next call. All events will have their eventType prefixed with ""
        /// </summary>
        /// <param name="eventType">The name of the event type</param>
        /// <param name="eventData">A map of event data</param>
        public static Task PostTelemetryV1EventsWithPerfInfoByEventType([Parameter("eventType", "path")] string eventType, [Parameter("eventData", "body")] object eventData)
            => Sender.Request("post", $"/telemetry/v1/events-with-perf-info/{eventType}", eventData);
        /// <summary>
        /// Adds a new event to be sent to Dradis and/or other analytics/monitoring data sinks. All events will have their eventType prefixed with ""
        /// </summary>
        /// <param name="eventType">The name of the event type</param>
        /// <param name="eventData">A map of event data</param>
        public static Task PostTelemetryV1EventsByEventType([Parameter("eventType", "path")] string eventType, [Parameter("eventData", "body")] object eventData)
            => Sender.Request("post", $"/telemetry/v1/events/{eventType}", eventData);
    }
}

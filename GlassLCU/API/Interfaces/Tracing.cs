using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class Tracing
    {
        /// <summary>
        /// Record a tracing event.
        /// </summary>
        public static Task PostTracingV1TraceEvent([Parameter("tracingEvent", "body")] TracingEventV1 tracingEvent)
            => Sender.Request("post", $"/tracing/v1/trace/event", tracingEvent);
        /// <summary>
        /// Record a module description.
        /// </summary>
        public static Task PostTracingV1TraceModule([Parameter("module", "body")] TracingModuleV1 module)
            => Sender.Request("post", $"/tracing/v1/trace/module", module);
        /// <summary>
        /// Record a tracing phase beginning.
        /// </summary>
        public static Task PostTracingV1TracePhaseBegin([Parameter("phaseBegin", "body")] TracingPhaseBeginV1 phaseBegin)
            => Sender.Request("post", $"/tracing/v1/trace/phase/begin", phaseBegin);
        /// <summary>
        /// Record a tracing phase ending.
        /// </summary>
        public static Task PostTracingV1TracePhaseEnd([Parameter("phaseEnd", "body")] TracingPhaseEndV1 phaseEnd)
            => Sender.Request("post", $"/tracing/v1/trace/phase/end", phaseEnd);
    }
}

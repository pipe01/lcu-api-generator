using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace LCU_API_Generator.CodeDom
{
    public class Method : CodeItem, ITypeContainer
    {
        public string Path { get; }
        public IDictionary<string, Parameter> Parameters { get; }
        public HttpMethod HttpMethod { get; }
        public VariableType ResponseType { get; }

        internal Method(string name, Documentation documentation, string path, IDictionary<string, Parameter> parameters,
            HttpMethod httpMethod, VariableType responseType) : base(name, documentation)
        {
            this.Path = path;
            this.Parameters = parameters;
            this.HttpMethod = httpMethod;
            this.ResponseType = responseType;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => ResponseType == null
            ? Parameters.Select(o => o.Value.Type)
            : Parameters.Select(o => o.Value.Type).Append(ResponseType);
    }
}

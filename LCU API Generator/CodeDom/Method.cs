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
        public VariableType RequestType { get; }

        internal Method(string name, Documentation documentation, string path, IDictionary<string, Parameter> parameters,
            HttpMethod httpMethod, VariableType responseType, VariableType requestType) : base(name, documentation)
        {
            this.Path = path;
            this.Parameters = parameters;
            this.HttpMethod = httpMethod;
            this.ResponseType = responseType;
            this.RequestType = requestType;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes()
        {
            var ret = Parameters.Select(o => o.Value.Type);

            if (ResponseType != null)
                ret = ret.Append(ResponseType);

            if (RequestType != null)
                ret = ret.Append(RequestType);

            return ret;
        }
    }
}

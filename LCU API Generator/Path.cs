using System.Collections.Generic;
using System.Diagnostics;

namespace LCU_API_Generator
{
    [DebuggerDisplay("{OperationID}: {Method} {PathName}")]
    public class Path
    {
        public class Parameter : Definition
        {
            public string In;
            public bool Required;
            public Definition Schema;
        }

        public class Response
        {
            public int Code;

            public string Description;
            public Definition Schema;
        }

        public string Method;
        public string PathName;

        public string OperationID;
        public string Summary;
        public string[] Tags;

        public Parameter[] Parameters;
        public Dictionary<int, Response> Responses;
    }
}

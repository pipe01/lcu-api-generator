using LCU_API_Generator.CodeDom;
using System.Collections.Generic;

namespace LCU_API_Generator.Generator
{
    public interface IGenerator
    {
        string LanguageKey { get; }

        void Setup(Workspace workspace);
        void GenerateSchema(Class schema, Workspace workspace);
        void GenerateInterface(PathsClass paths, Workspace workspace);
        void Finish(Workspace workspace);
    }
}

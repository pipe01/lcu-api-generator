using LCU_API_Generator.CodeDom;

namespace LCU_API_Generator.Generator
{
    public interface IGenerator
    {
        string Key { get; }

        void GenerateSchema(Class schema, Workspace workspace);
    }
}

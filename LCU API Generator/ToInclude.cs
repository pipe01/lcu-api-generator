using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    sealed class ParameterAttribute : Attribute
    {
        public enum Position
        {
            Query,
            Path,
            Header,
            Body
        }

        public string Name { get; }
        public Position InPosition { get; }

        public ParameterAttribute(string name, string inPosition)
        {
            this.Name = name;
            this.InPosition = Enum.Parse<Position>(inPosition, true);
        }
    }

    public interface ISender
    {
        Task<T> Request<T>(string method, string path, object body = null);
        Task Request(string method, string path, object body = null);
    }

    public static class GenerationUtils
    {
        public static ISender Sender { get; }
    }
}

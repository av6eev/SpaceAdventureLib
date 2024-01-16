using System.Collections.Generic;

namespace Specification
{
    public interface ISpecification
    {
        string Id { get; }
        void Fill(IDictionary<string, object> node);
    }
}
using System;
using System.Collections.Generic;

namespace Specification
{
    [Serializable]
    public abstract class BaseSpecification : ISpecification
    {
        public string _id;
        public string Id => _id;

        public virtual void Fill(IDictionary<string, object> node)
        {
            
        }
    }
}
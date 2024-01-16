﻿using System;
using System.Collections.Generic;

namespace Specification
{
    [Serializable]
    public abstract class Specification : ISpecification
    {
        public string _id;
        public string Id => _id;

        public abstract void Fill(IDictionary<string, object> node);
    }
}
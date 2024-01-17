using System;
using Awaiter;

namespace Loader.Object
{
    public interface ILoadObjectModel<T> : ILoadElement, IDisposable
    {
        CustomAwaiter LoadAwaiter { get; }
        CustomAwaiter UnloadAwaiter { get; }
        T Result { get; }
    }
}
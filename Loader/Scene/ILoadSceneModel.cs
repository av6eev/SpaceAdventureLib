using System;
using Awaiter;

namespace Loader.Scene
{
    public interface ILoadSceneModel : ILoadElement, IDisposable
    {
        CustomAwaiter LoadAwaiter { get; }
        CustomAwaiter UnloadAwaiter { get; }
    }
}
using Awaiter;
using Specification.Scene;

namespace Loader.Scene
{
    public class LoadSceneModel : ILoadSceneToWrapperModel, ILoadSceneModel
    {
        public CustomAwaiter LoadAwaiter { get; } = new();
        public CustomAwaiter UnloadAwaiter { get; } = new();
        
        public SceneSpecification Specification { get; }

        public LoadSceneModel(SceneSpecification specification)
        {
            Specification = specification;
        }
        
        public void CompleteLoad()
        {
            LoadAwaiter.Complete();
        }

        public void CompleteUnload()
        {
            UnloadAwaiter.Complete();
        }

        public void Dispose()
        {
        }
    }
}
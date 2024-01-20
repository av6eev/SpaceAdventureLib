using Specification.Scene;

namespace Loader.Scene
{
    public interface ILoadScenesModel
    {
        ILoadSceneModel Load(SceneSpecification specification);
        void Unload(ILoadSceneModel model);
    }
}
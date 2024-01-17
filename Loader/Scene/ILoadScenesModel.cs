using Specification.Scene;

namespace Loader.Scene
{
    public interface ILoadScenesModel
    {
        ILoadSceneModel Load(IGameModel gameModel, SceneSpecification specification);
        void Unload(ILoadSceneModel model);
    }
}
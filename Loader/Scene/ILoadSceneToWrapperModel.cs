using Specification.Scene;

namespace Loader.Scene
{
    public interface ILoadSceneToWrapperModel : IWrapperLoadModel 
    {
        SceneSpecification Specification { get; }
    }
}
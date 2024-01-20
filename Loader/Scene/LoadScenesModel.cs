using Specification.Scene;

namespace Loader.Scene
{
    public class LoadScenesModel : ILoadScenesModel
    {
        private readonly ILoadSceneWrapper _wrapper;

        public LoadScenesModel(ILoadSceneWrapper wrapper)
        {
            _wrapper = wrapper;
        }
        
        public ILoadSceneModel Load(SceneSpecification specification)
        {
            var model = new LoadSceneModel(specification);
            
            _wrapper.Load(model);
            
            return model;
        }

        public void Unload(ILoadSceneModel model)
        {
            _wrapper.Unload(model);
        }
    }
}
namespace Loader.Scene
{
    public interface ILoadSceneWrapper
    {
        void Load(LoadSceneModel model);
        void Unload(ILoadSceneModel loadElement);
    }
}
namespace Loader.Scene
{
    public interface ILoadSceneWrapper
    {
        void Load(IGameModel gameModel, LoadSceneModel model);
        void Unload(ILoadSceneModel loadElement);
    }
}